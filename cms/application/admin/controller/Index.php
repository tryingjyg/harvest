<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;
use think\Session;

class Index extends Controller
{
    public function index()
    {
        return $this->fetch();
    }
	public function login() {
		if (request()->isAjax()) {
			$login = array();
			$username =  input('request.username');
			$password =  input('request.password');
			if (!preg_match('/^[\x{4e00}-\x{9fa5}a-zA-Z0-9_-]{2,16}$/u',$username)) {
				return array('s'=>'请输入合法的用户名');
			}
			if (strlen($password)<6 || strlen($password)>18) {
				return array('s'=>'请输入6位数以上的密码');
			}
			if (!captcha_check(input('request.code'))) {
				return array('s'=>'请输入正确的验证码');
			}
			$area = $this->area();
			$dip  = new \app\common\model\Ip;
			$whereIP['Ip'] = $area['ip'];
			$resip = $dip->where($whereIP)->find();
			if ($resip) {
				if ($resip['Status'] == 1) {
					$this->loginlog(0,'未知','<div class="de2">被封锁IP尝试登录</div>',$area['country'].'.'.$area['area'],$area['ip']);
					return array('s'=>'您的IP异常已被封禁，请等待管理员解除封禁！');
				}else {
					$endtime = strtotime($resip['EndTime']);		//结束时间
					if (($endtime - date('Y-m-d')) > 1) {
						$this->loginlog(0,'未知','<div class="de2">被封锁帐号尝试登录</div>',$area['country'].'.'.$area['area'],$area['ip']);
						return array('s'=>'您的IP异常已被封禁，请等待管理员解除封禁！');
					}
				}
			}
			$where['Username'] = $username;
			$user = new \app\common\model\User;
			if ($re = $user->where($where)->count()) {
				$where['Status']=0;
				if (!$user->where($where)->count()) {
					$this->loginlog($re['ID'],$username,'<div class="de2">违规帐号登录</div>',$area['country'].'.'.$area['area'],$area['ip']);
					return array('s'=>'当前帐号已被封禁，请等待解除～！');
				}
				$where['Password']=sha1(md5($password));
				if (!$result=$user->where($where)->value('ID,Username,Password,Roleid,Status,Competence,Loginarea,Logincount')) {
					$this->loginlog($re['ID'],$username,'<div class="de2">登录密码错误</div>',$area['country'].'.'.$area['area'],$area['ip']);
					return array('s'=>'登录密码错误！');
				}
				$arr=$user->where($where)->find();
				//IP地址位置获取
				$loginlog['Loginarea'] = $area['country'].'.'.$area['area'];
				$loginlog['Loginip'] = $area['ip'];
				$loginlog['Logintime'] = date('Y-m-d H:i:s');
				$er = $user->where('ID = '.$arr['ID'])->setField($loginlog);
				$user->where('ID = '.$arr['ID'])->setInc('Logincount'); 	//登录次数加1
				//日志记录
				$this->loginlog($arr['ID'],$username,'<div class="de1">登录成功</div>',$area['country'].'.'.$area['area'],$area['ip']);
				$arr['Loginarea'] = $area['country'].'.'.$area['area'];
				$arr['Loginip'] = $area['ip'];
				$arr['Logintime'] = time();
				$arr['Logincount'] = $arr['Logincount']+1;
				$subordinate_arr = $user->where('leader_id = '.$arr['ID'])->column('ID');
				$arr['subordinate_id'] = implode(",", $subordinate_arr);
				session('ThinkUser',$arr);
				//销毁验证码session
				session('verify',null);
				session('expire',3600);
				return array('s'=>'ok');
			}else {
				$this->loginlog(0,$username,'<div class="de2">用户不存在</div>',$area['country'].'.'.$area['area'],$area['ip']);
				return array('s'=>'用户名不存在');
			}
		}else {
			return array('s'=>'非法请求');
		}
	}
	//管理界面
	public function main() {
	    new \app\admin\controller\Admin;
        $module = new \app\common\model\Module;
        $list   =   $module->where('Sid = 0')->order('Msort asc')->select();
        $volist =   $module->where('Sid > 0')->order('Msort asc')->select();
        foreach($volist as $k=>$v){
            if($v['Competence'] != "" && $v['Competence'] != 0){
                if(!$this->checkCompetence($v)){
                    unset($volist[$k]);
                }
            }
        }
        //echo "<pre>";print_r($volist);exit;
	    foreach($list as $k=>$v){
            if(!$this->checkModule($v['ID'],$volist)){
                unset($list[$k]);
            }
        }
	    $this->assign('list', $list);
	    $this->assign('volist', $volist);
	    //===模块导航结束===
	    return $this->fetch();
	}
	//判断用户是否登录的方法
	public function checkCompetence($data) {
        $competence = new \app\common\model\Competence;
        $competence_info = $competence->where("ID = '{$data['Competence']}'")->find();
        $competence_arr  = $competence->where("Sid = '{$competence_info['ID']}'")->column('ID');
        foreach($competence_arr as $k=>$v){
            $comp=explode(',',Session::get('ThinkUser.Competence'));			//当前用户权限获取
    		array_pop($comp);
    		if (in_array($v,$comp)) {
                return true;
    		}
        }
        return false;
	}
	//判断用户是否登录的方法
	public function checkModule($id,$data) {
	    $module = new \app\common\model\Module;
	    $module_arr = $module->where("Sid = '{$id}'")->column('ID');
	    $array = array();
	    foreach ($data as $k=>$v){
	        $array[] = $v['ID'];
	    }
	    foreach($module_arr as $k=>$v){
	        if (in_array($v,$array)) {
	            return true;
	        }
	    }
	    return false;
	}
	//地理位置信息获取
	public function area() {
	    $area = array();
	    //位置获取
	    $Ip = new \Net\IpLocation('UTFWry.dat');			// 实例化类 参数表示IP地址库文件
	    $area = $Ip->getlocation();					// 获取某个IP地址所在的位
	    return $area;
	}
	public function loginlog($uid,$username,$description,$area,$cip) {
	    //登录日志记录
	    $hlog['Uid'] = $uid;
	    $hlog['User'] = $username;
	    $hlog['Description'] = $description;
	    $hlog['Area'] = $area;
	    $hlog['Loginip'] = $cip;
	    $hlog['Dtime'] = date('Y-m-d H:i:s');
	    $log = new \app\common\model\Loginlog;
	    $log->insert($hlog);
	}
	//退出登录
	public function quit() {
	    $statis = new \app\common\model\Statis;
	    $where['Uid'] = session('ID');
	    $statis->where($where)->delete();
	    \think\Session::clear('think');
	    $this->redirect('Index/index');
	}
	//框架显示
	public function content() {
	    new \app\admin\controller\Admin;
        //获取系统信息
        $systeminfo['THINK_VERSION'] = THINK_VERSION;
        $systeminfo['SERVER_SOFTWARE'] = $_SERVER["SERVER_SOFTWARE"];
        $systeminfo['PHP_OS'] = PHP_OS;

        $statis = new \app\common\model\Statis;
        $usercount = $statis->count();
        
        $mysql=\think\Db::query("select version() AS version");
        $systeminfo['mysql']['version'] =$mysql[0]['version'];
        $info = $systeminfo;
        $this->assign('info',$info);
	    $this->assign('usercount',$usercount);
	    return $this->fetch();
	}
}
