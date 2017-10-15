<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;

class Competence extends Admin
{
	public function index() {
		parent::userauth2(12);
		$keyword = input('request.keyword');
		$user = new \app\common\model\Competence;
		$where  = array();
		$where1 = array();

		if($keyword!=""){
		    $where['Cname']=$keyword;
		}
		$where['Sid']     = array("EQ",0);
		$where1['Sid']    = array("NEQ",0);
		
		$sidlist  = $user->where($where1)->order('Dtime')->select();
		$lists    = $user->where($where)->paginate(4);
		$volist   = $lists->toArray();
		$this->assign('volist',$volist);
		$this->assign('sidlist',$sidlist);
		$this->assign('keyword',$keyword);
		$this->assign('lists',$lists);
		return $this->fetch();
	}
	public function cadd() {
		parent::win_userauth(13);
		$co= new \app\common\model\Competence;
		$volist=$co->where('Sid=0 AND Status=0')->order('Dtime')->column('ID,Cname,Status');
		$this->assign('volist',$volist);
		return $this->fetch('add');
	}
	//新增权限
	public function cadd_do() {
		//验证用户权限
		parent::userauth(13);
		$data=array();
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$data['Sid']         = input('post.sid');
			$data['Cname']       = input('post.cname');
			$data['Description'] = input('post.description');
			$data['Status']      = input('post.status');
			$co= new \app\common\model\Competence;
			//自动创建并验证数据
			if ($co->data($data)) {
				$co->save();
				parent::operating(request()->path(),0,'新增成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'新增失败'.$co->getError());
				return array('s'=>$co->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//修改权限信息
	public function cedit() {
		parent::win_userauth(14);
		$id = input('get.id');
		if ($id=='' || !is_numeric($id)) {
			$this->assign('content','参数ID类型错误，请关闭本窗口');
			return $this->fetch('Public\err');
		}
		$id=intval($id);
		$co= new \app\common\model\Competence;
		//获取分类信息
		$volist=$co->where('Sid=0 AND Status=0')->order('Dtime')->column('ID,Cname,Status');
		$data=array('ID' => $id);
		if ($result=$co->where($data)->find()) {
			$this->assign('volist',$volist);
			$this->assign('result',$result);
			return $this->fetch('edit');
		}else {
			parent::operating(request()->path(),1,'没有找到相关数据：'.$id);
			$this->assign('content','没有找到相关数据，请关闭本窗口');
			return $this->fetch('Public\err');
		}
	}
	//修改处理
	public function cedit_do() {
		//验证用户权限
		parent::userauth(14);
		$data=array();
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$ID                  = input('post.id');
			$data['Sid']         = input('post.sid');
			$data['Cname']       = input('post.cname');
			$data['Description'] = input('post.description');
			$data['Status']      = input('post.status');
			//自动创建数据及完成验证
			$co= new \app\common\model\Competence;
			if ($co->save($data,"ID=".$ID)) {
				parent::operating(request()->path(),0,'更新成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'更新失败'.$co->getError());
				return array('s'=>$co->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//删除数据
	public function cdel() {
		//验证用户权限
		parent::userauth(15);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			if (input('post.post') == 'ok') {
				$id = input('post.id');
				if ($id=='' || !is_numeric($id)) {
					parent::operating(request()->path(),1,'参数错误');
					return array('s'=>'参数ID类型错误');
				}else {
					$id=intval($id);
					$role= new \app\common\model\Competence;
					if ($role->where("ID=$id")->value('ID')) {
						$role->where('ID',$id)->whereOr('Sid',$id)->delete();
						parent::operating(request()->path(),0,'删除成功');
						return array('s'=>'ok');
					}else {
						parent::operating(request()->path(),1,'删除失败');
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
?>