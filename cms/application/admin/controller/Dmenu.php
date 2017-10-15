<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;

class Dmenu extends Admin
{
	//下拉菜单
	public function index() {
		parent::userauth2(60);
	    $dmenu = new \app\common\model\Dmenu;
	    $user = new \app\common\model\User;
	    $where = array();
	    $sid  = input('request.sid');
	    if ($sid!='') {
	        $where['Sid'] = $sid;
	    }else {
	        $where['Sid'] = 0;
	    }

		$lists  = $dmenu->where($where)->paginate();
		$volist = $lists->toArray();
		$list   = $dmenu->where('Sid = 0')->select();
		foreach($volist['data'] as $k=>$v){
		    $volist['data'][$k]['Username'] = $user->where("ID='{$v['Uid']}'")->value('Username');
		}
		$this->assign('volist',$volist);
		$this->assign('sid',$sid);
		$this->assign('lists',$lists);
		$this->assign('list',$list);
		return $this->fetch('system/dmenu');
	}
	//添加
	public function dmenuadd() {
		parent::win_userauth(61);
		$dmenu =  new \app\common\model\Dmenu;
		$list=$dmenu->where('Sid = 0')->order('Sortid asc')->column('ID,Sid,MenuName,Sortid');
		$this->assign('list',$list);
		return $this->fetch('system/dmenuadd');
	}
	//添加处理
	public function dmenuadd_do() {
		parent::userauth(61);
		if (request()->isAjax()) {
			$data['Sid']         = input('post.sid');
			$data['MenuName']    = input('post.menuname');
			$data['Description'] = input('post.description');
			$data['Sortid']      = input('post.sortid');
			$data['Uid']         = session('ThinkUser.ID');
			$dmenu = new \app\common\model\Dmenu;
			if ($dmenu->save($data)) {
				parent::operating(request()->path(),0,'新增成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'新增失败：'.$dmenu->getError());
				return array('s'=>$dmenu->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//修改
	public function dmenuedit() {
		parent::win_userauth(62);
		$id = input('get.id');
		if ($id=='' || !is_numeric($id)) {
			parent::operating(request()->path(),1,'参数错误');
			$this->assign('content','参数ID类型错误，请关闭本窗口');
			return $this->fetch('Public/err');
		}
		$id=intval($id);
		$dmenu=  new \app\common\model\Dmenu;
		//获取分类信息
		$data=array('ID' => $id);
		if ($result=$dmenu->where($data)->find()) {
			$this->result=$result;
			$list=$dmenu->where('Sid = 0')->order('Sortid asc')->column('ID,Sid,MenuName,Sortid');
			$this->assign('list',$list);
			$this->assign('result',$result);
			return $this->fetch('system/dmenuedit');
		}else {
			parent::operating(request()->path(),1,'没有找到数据');
			$this->assign('content','没有找到相关数据，请关闭本窗口');
			return $this->fetch('Public/err');
		}
	}
	//修改处理
	public function dmenuedit_do() {
		parent::userauth(62);
		if (request()->isAjax()) {
			$ID                  = input('post.id');
			$data['Sid']         = input('post.sid');
			$data['MenuName']    = input('post.menuname');
			$data['Description'] = input('post.description');
			$data['Sortid']      = input('post.sortid');
			$dmenu =  new \app\common\model\Dmenu;
			if ($dmenu->save($data,"ID=".$ID)) {
				parent::operating(request()->path(),0,'更新成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'更新失败'.$dmenu->getError());
				return array('s'=>$dmenu->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//删除
	public function del() {
		//验证用户权限
		parent::userauth(63);
		if (request()->isAjax()) {
			if (!$delid=explode(',',input('post.delid'))) {
				return array('s'=>'请选中后再删除');
			}
			//将最后一个元素弹出栈
			array_pop($delid);
			$id=join(',',$delid);
			$dmenu=  new \app\common\model\Dmenu;
			if ($dmenu->where('ID','IN',$id)->delete()) {
				parent::operating(request()->path(),0,'删除成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'删除失败：'.$dmenu->getError());
				return array('s'=>'删除失败');
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
}
