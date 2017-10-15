<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;

class System extends Admin
{
	//IP操作开始
	public function ip() {
		parent::userauth2(21);
		$keyword  = input('request.keyword');
		$ip       = new \app\common\model\Ip;
		$user     = new \app\common\model\User;
		$where    = array();
	    if ($keyword!=null) {
			$where['Ip'] = $keyword;
		}
		$lists  = $ip->where($where)->paginate();
		$volist = $lists->toArray();
        foreach($volist['data'] as $k=>$v){
            $volist['data'][$k]['Username'] = $user->where("ID=".$v['Uid'])->value('Username');
        }
		$this->assign('volist',$volist);			
		$this->assign('keyword',$keyword);
		$this->assign('lists',$lists);
		return $this->fetch();
	}
	public function ipadd() {
		parent::win_userauth(22);
		return $this->fetch();
	}
	public function ipadd_do() {
		//验证用户权限
		parent::userauth(22);
		//判断请求类型
		if (request()->isAjax()) {
			$data['Uid']         = session('ThinkUser.ID');
			$data['Ip']          = input('post.ip');
			$data['StartTime']   = input('post.stime');
			$data['EndTime']     = input('post.etime');
			$data['Status']      = input('post.status');
			$data['Description'] = input('post.description');
			$data['Dtime']       = date('Y-m-d H:i:s');
			$ip = new \app\common\model\Ip;
			if ($ip->data($data)) {
				$ip->save();
				parent::operating(request()->path(),0,'新增IP限制登录成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'新增失败：',$ip->getError());
				return array('s'=>$ip->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//删除数据
	public function del() {
		//验证用户权限
		parent::userauth(23);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$id = input('post.id');
			if ($id=='' || !is_numeric($id)) {
				parent::operating(request()->path(),1,'参数错误');
				return array('s'=>'参数ID类型错误');
			}else {
				$id=intval($id);
				$ip=new \app\common\model\Ip;
				$where=array('ID'=>$id);
				if ($ip->where($where)->value('ID')) {
					$ip->where($where)->delete();
					parent::operating(request()->path(),0,'删除成功');
					return array('s'=>'ok');
				}else {
					parent::operating(request()->path(),1,'数据不存在');
					return array('s'=>'数据不存在');
				}
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//批量删除
	public function indel() {
		//验证用户权限
		parent::userauth(23);
		if (request()->isAjax()) {
			if (!$delid=explode(',',$this->_post('delid'))) {
				return array('s'=>'请选中后再删除');
			}
			//将最后一个元素弹出栈
			array_pop($delid);
			$id=join(',',$delid);
			$ip=new \app\common\model\Ip;
			if ($ip->delete("$id")) {
				parent::operating(request()->path(),0,'删除成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'删除失败：'.$ip->getError());
				return array('s'=>'删除失败');
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//IP操作结束
	
	//模块管理开始
	public function module() {
		parent::userauth2(25);
		$module   = new \app\common\model\Module;
		$user     = new \app\common\model\User;
		$where    = array();
		$volist   = $module->where($where)->select();
		$volist = $this->classid($volist);
		foreach($volist as $k=>$v){
		    $volist[$k]['Username'] = $user->where("ID=".$v['Uid'])->value('Username');
		}
		$this->assign('volist',$volist);
		return $this->fetch();
	}
	//添加模块
	public function module_add() {
		parent::win_userauth(26);
		$module = new \app\common\model\Module;
		$list=$module->order('Msort asc')->column('ID,Sid,ModuleName,Msort');
		$competence = new \app\common\model\Competence;
		$competence_list=$competence->where("Sid = 0")->order('ID DESC')->select();
		$arr=$this->classid($list);
		$this->assign('list',$arr);
		$this->assign('competence_list',$competence_list);
		return $this->fetch('moduleadd');
	}
	//无限循环分类
	protected function classid($volist,$nan=0,$html='──',$level=0) {
		$arr=array();
		foreach($volist as $val) {
			if ($val['Sid'] == $nan) {
				$val['classname'] = $val['ModuleName'];
				$val['html'] = str_repeat($html,$level);
				$arr[] = $val;
				$arr = array_merge($arr,self::classid($volist,$val['ID'],$html,$level+1));
			}
		}
		return $arr;
	}
	//添加模块处理
	public function module_add_do() {
		parent::userauth(26);
		if (request()->isAjax()) {
			$data['Sid']         = input('post.sid');
			$data['ModuleName']  = input('post.mname');
			$data['ModuleImg']   = input('post.img');
			$data['ModuleUrl']   = input('post.url');
			$data['Status']      = input('post.status');
			$data['Msort']       = input('post.msort');
			$data['Description'] = input('post.description');
			$data['Competence']  = input('post.Competence');
			$module = new \app\common\model\Module;
			if ($module->data($data)) {
				$module->save();
				parent::operating(request()->path(),0,'新增模块成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'新增失败：'.$module->getError());
				return array('s'=>$module->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//修改模块
	public function module_edit() {
		parent::win_userauth(27);
		$id = input('get.id');
		if ($id=='' || !is_numeric($id)) {
			parent::operating(request()->path(),1,'参数错误');
			$this->assign('content','参数ID类型错误，请关闭本窗口');
			return $this->fetch('Public/err');
		}
		$id=intval($id);
		$module=new \app\common\model\Module;
		//获取分类信息
		$data=array('ID' => $id);
		if ($result=$module->where($data)->find()) {
			$this->result=$result;
			$list=$module->order('Msort asc')->column('ID,Sid,ModuleName,Msort');
			$arr=$this->classid($list);
			$competence = new \app\common\model\Competence;
			$competence_list=$competence->where("Sid = 0")->order('ID DESC')->select();
			$this->assign('list',$arr);
			$this->assign('competence_list',$competence_list);
			$this->assign('result',$result);
			return $this->fetch('moduleedit');
		}else {
			parent::operating(request()->path(),1,'数据不存在');
			$this->assign('content','没有找到相关数据，请关闭本窗口');
			return $this->fetch('Public/err');
		}
	}
	//图标列表
	public function img () {
		$this->display('img');
	}
	//图标列表请求
	public function img_do() {
		$imgcount=1031;			//图标总数
		$speed=100;				//分页数
		if (request()->isAjax()) {
			$page = input('post.page');
			$html='';
			if (floor($imgcount/$speed)+1 == $page) {
				$stratpage=1000;
				$endpage = $imgcount;
			}else {
				$stratpage=$page*$speed;
				if ($page>1) {
					$stratpage-=$speed;
				}else {
					$stratpage=$page;
				}
				$endpage=$page*$speed;
			}
			for ($i = $stratpage; $i <= $endpage; $i++) {
				$html['y'.$i]="/img/$i.png";
			}
			echo json_encode($html);
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//修改模块处理
	public function module_edit_do() {
		parent::userauth(27);
		if (request()->isAjax()) {
			$ID                  = input('post.id');
			$data['Sid']         = input('post.sid');
			$data['ModuleName']  = input('post.mname');
			$data['ModuleImg']   = input('post.img');
			$data['ModuleUrl']   = input('post.url');
			$data['Status']      = input('post.status');
			$data['Msort']       = input('post.msort');
			$data['Description'] = input('post.description');
			$data['Competence']  = input('post.Competence');
			
			$module = new \app\common\model\Module;
			if ($module->save($data,"ID=".$ID)) {
				parent::operating(request()->path(),0,'更新成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'更新失败：'.$module->getError());
				return array('s'=>$module->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//模块删除
	public function moduledel() {
		//验证用户权限
		parent::userauth(28);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$id = input('post.id');
			if ($id=='' || !is_numeric($id)) {
				parent::operating(request()->path(),1,'参数错误');
				return array('s'=>'参数ID类型错误');
			}else {
				$id=intval($id);
				$module= new \app\common\model\Module;
				$where=array('ID'=>$id);
				if ($module->where($where)->value('ID')) {
					$module->where($where)->delete();
					parent::operating(request()->path(),0,'删除模块成功');
					return array('s'=>'ok');
				}else {
					parent::operating(request()->path(),1,'数据不存在');
					return array('s'=>'数据不存在');
				}
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//系统配置
	public function systemconfig() {
		parent::userauth2(30);
		$config['tarce'] = C('SHOW_PAGE_TRACE');
		$config['debug'] = C('APP_STATUS');
		$config['sessionuser'] = C('USER_AUTH_SESSION');
		$config['log'] = C('LOG_RECORD');
		$logclass = explode(',',C('LOG_LEVEL'));
		$config['url'] = C('URL_MODEL');						//URL模式
		$config['urlcase'] = C('URL_CASE_INSENSITIVE');			//URL大小写是否开启
		$config['tokenon'] = C('TOKEN_ON');						// 是否开启令牌验证
		$config['tokenreset'] = C('TOKEN_RESET');				//令牌验证出错后是否重置令牌 默认为true
		$config['dbfieldcheck'] = C('DB_FIELDTYPE_CHECK');		//是否开启字段类型验证
		foreach($logclass as $val) {
			$config['typelog'][$val]=$val;
		}
		$this->assign('config',$config);
		$this->display();
	}
	//系统配置修改
	public function systemconfig_do() {
		//验证用户权限
		parent::userauth2(30);
		if (request()->isPost()) {
			$config['SHOW_PAGE_TRACE']       = input('post.trace');
			$config['APP_STATUS']            = input('post.debug');
			$config['USER_AUTH_SESSION']     = input('post.sessionuser');
			$config['LOG_RECORD']            = input('post.log');
			$config['LOG_LEVEL']             = join(',',$_POST['typelog']);
			$config['URL_MODEL']             = input('post.url');						//Url模式
			$config['URL_CASE_INSENSITIVE']  = input('post.urlcase');			//URL大小写是否开启
			$config['TOKEN_ON']              = input('post.tokenon');
			$config['TOKEN_RESET']           = input('post.tokenreset');
			$config['DB_FIELDTYPE_CHECK']    = input('post.dbfieldcheck');
			$settingstr="<?php \n return array(\n";
			foreach($config as $key => $val){
				if ($val == 'false') {
					$settingstr.= "\t'".$key."'=>false,\n";
				}elseif ($val == 'true') {
					$settingstr.= "\t'".$key."'=>true,\n";
				}else {
					$settingstr.= "\t'".$key."'=>'".$val."',\n";
				}
			}
			$settingstr.="\n);\n?>";
			if (file_put_contents(CONF_PATH.'setting.php',$settingstr,FILE_USE_INCLUDE_PATH)) {
				parent::operating(request()->path(),0,'系统配置修改成功');
				$this->success('修改成功','systemconfig',2);
			}else {
				parent::operating(request()->path(),1,'系统配置修改失败');
				$this->error('修改失败，可能是由于没有写入权限导致。');
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//核心配置
	public function systemcore() {
		parent::userauth2(33);
		$config = require(CONF_PATH.'core.php');
		$this->assign('config',$config);
		$this->display();
	}
	//核心配置修改
	public function systemcore_do() {
		//验证用户权限
		parent::userauth2(33);
		if (request()->isPost()) {
			$config = $_POST;
			$settingstr="<?php \n return array(\n";
			foreach($config as $key => $val){
				$settingstr.= "\t'".$key."'=>'".strtolower($val)."',\n";
			}
			$settingstr.="\n);\n?>";
			if (file_put_contents(CONF_PATH.'core.php',$settingstr,FILE_USE_INCLUDE_PATH)) {
				parent::operating(request()->path(),0,'核心配置文件修改成功');
				$this->success('修改成功','systemcore',2);
			}else {
				parent::operating(request()->path(),1,'核心配置文件修改失败，可能是没有写入权限导致');
				$this->error('修改失败，可能是由于没有写入权限导致。');
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//网站配置
	public function systemwebsite() {
		parent::userauth2(53);
		$config = require(CONF_PATH.'webconfig.php');
		$this->assign('config',$config);
		$this->display();
	}
	//网站配置修改
	public function systemwebsite_do() {
		//验证用户权限
		parent::userauth2(53);
		if (request()->isPost()) {
			$config = $_POST;
			$settingstr="<?php \n return array(\n";
			foreach($config as $key => $val){
				$settingstr.= "\t'".$key."'=>'".$val."',\n";
			}
			$settingstr.="\n);\n?>";
			if (file_put_contents(CONF_PATH.'webconfig.php',$settingstr,FILE_USE_INCLUDE_PATH)) {
				parent::operating(request()->path(),0,'网站配置文件修改成功');
				$this->success('修改成功','systemwebsite',2);
			}else {
				parent::operating(request()->path(),1,'网站配置文件修改失败');
				$this->error('修改失败，可能是由于没有写入权限导致。');
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
}
