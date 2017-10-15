<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;

class Role extends Admin
{
	public function index() {
		parent::userauth2(7);
		$keyword = input('request.keyword');
		$user = new \app\common\model\Role;
		$where = array();
		//$where['Username']=$keyword;
		$lists  = $user->where($where)->paginate();
		$volist = $lists->toArray();

		$this->assign('volist',$volist);			
		$this->assign('keyword',$keyword);
		$this->assign('lists',$lists);
		return $this->fetch();
	}
	public function roleadd() {
		parent::win_userauth(8);
		$co = new \app\common\model\Competence;
		$volist = $co->where('Sid=0 AND Status=0')->order('Dtime asc')->column('ID,Cname,Status');
		$slist = $co->where('Sid<>0 AND Status=0')->order('Dtime asc')->column('ID,Sid,Cname,Status');
		$this->assign('slist',$slist);
		$this->assign('volist',$volist);
		return $this->fetch('add');
	}
	//新增角色
	public function roleadd_do() {
		//验证用户权限
		parent::userauth(8);
		$data=array();
		if (request()->isAjax()) {
			$data['Rolename']    = input('post.rolename');
			$data['Description'] = input('post.description');
			$data['Competence']  = input('post.comp');
			$data['Status']      = input('post.status');
			$role= new \app\common\model\Role;
			if ($role->data($data)) {
				$role->save();
				parent::operating(request()->path(),0,'新增成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'新增失败'.$role->getError());
				return array('s'=>$role->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//修改角色信息
	public function roleedit() {
		parent::win_userauth(9);
		$id = input('get.id');
		if ($id == '' || !is_numeric($id)) {
			parent::operating(request()->path(),1,'参数错误');
			$this->assign('content','参数ID类型错误，请关闭本窗口');
			return $this->fetch('Public:err');
		}
		$id = intval($id);
		$role = new \app\common\model\Role;
		if ($result = $role->where("ID = $id")->find()) {
			$this->assign('result',$result);
			//获取权限数据
			$co = new \app\common\model\Competence;
			$volist = $co->where('Sid=0 AND Status=0')->order('Dtime asc')->column('ID,Cname,Status');
			$slist = $co->where('Sid<>0 AND Status=0')->order('Dtime asc')->column('ID,Sid,Cname,Status');
			$this->assign('volist',$volist);
			$this->assign('slist',$slist);
			return $this->fetch('edit');
		}else {
			parent::operating(request()->path(),1,'数据不存在');
			$this->assign('content','没有找到相关数据，请关闭本窗口');
			return $this->fetch('Public/err');
		}
	}
	//修改处理
	public function roleedit_do() {
		//验证用户权限
		parent::userauth(9);
		$data=array();
		if (request()->isAjax()) {
			$ID                  = input('post.id');
			$data['Rolename']    = input('post.rolename');
			$data['Description'] = input('post.description');
			$data['Competence']  = input('post.comp');
			$data['Status']      = input('post.status');
			$role = new \app\common\model\Role;
			$where = array('ID'=>$ID);
			if ($role->save($data,$where)) {
				//修改所有属于该角色的用户权限
				$user = new \app\common\model\User;
				$user->where('Roleid='.$ID)->setField(array('Competence'=>$data['Competence']));
				parent::operating(request()->path(),0,'更新成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'更新失败：'.$role->getError());
				return array('s'=>$role->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//删除数据
	public function roledel() {
		//验证用户权限
		parent::userauth(10);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			if (input('post.post')=='ok') {
				$id = input('post.id');
				if ($id == '' || !is_numeric($id)) {
					parent::operating(request()->path(),1,'参数错误');
					return array('s'=>'参数ID类型错误');
				}else {
					$id = intval($id);
					if ($id==1) {
						parent::operating(request()->path(),1,'不能删除系统默认角色');
						return array('s'=>'不能删除此角色');
					}
					$role = new \app\common\model\Role;
					$where = array('ID'=>$id);
					if ($role->where($where)->value('ID')) {
						$role->where($where)->delete();
						parent::operating(request()->path(),0,'删除成功');
						return array('s'=>'ok');
					}else {
						parent::operating(request()->path(),1,'数据不存在：'.$id);
						return array('s'=>'数据不存在');
					}
				}
			}else {
				parent::operating(request()->path(),1,'非法请求');
				return array('s'=>'非法请求');
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
}
