<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;

class Operating extends Admin
{
	public function index() {
		parent::userauth2(82);
		$keyword      = input('request.keyword');
		$Url          = input('get.Url');
		$Ip           = input('get.Ip');
		$Uid          = input('get.Uid');
		$Status       = input('request.Status');
		$operating    = new \app\common\model\Operating;
		$user         = new \app\common\model\User;
		$where = array();
		//$where['Username']=$keyword;
		if(input('request.Status')!=null){
		    $where['Status']  =   $Status;
		}
		if ($keyword!=null) {
		    $where['Description'] =array('like',"%$keyword%");;
		}
		if ($Url!=null) {
		    $where['Url'] = $Url;
		}
		if ($Ip!=null) {
		    $where['Ip'] = $Ip;
		}
		if ($Uid!=null) {
		    $where['Uid'] = intval($Uid);
		}
		
		$lists  = $operating->where($where)->order('ID desc')->paginate();
		$volist = $lists->toArray();
		foreach($volist['data'] as $k=>$v){
		    $volist['data'][$k]['Username'] = $user->where("ID='{$v['Uid']}'")->value('Username');
		}
		$this->assign('volist',$volist);			
		$this->assign('keyword',$keyword);
		$this->assign('lists',$lists);
		$this->assign('Status',$Status);
		return $this->fetch("public/operatinglog");
	}
	//删除数据
	public function del() {
		//验证用户权限
		parent::userauth(83);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			if (input('post.post') == 'ok') {
				$id = input('post.id');
				if ($id=='' || !is_numeric($id)) {
					return array('s'=>'参数ID类型错误');
				}else {
					$id=intval($id);
					$operating= new \app\common\model\Operating;
					$where=array('ID'=>$id);
					if ($operating->where($where)->value('ID')) {
						$operating->where($where)->delete();
						return array('s'=>'ok');
					}else {
						return array('s'=>'数据不存在');
					}
				}
			}else {
				return array('s'=>'非法请求');
			}
		}else {
			return array('s'=>'非法请求');
		}
	}
	//批量删除
	public function indel() {
		//验证用户权限
		parent::userauth(83);
		if (request()->isAjax()) {
			if (!$delid=explode(',',input('post.delid'))) {
				return array('s'=>'请选中后再删除');
			}
			//将最后一个元素弹出栈
			array_pop($delid);
			$id=join(',',$delid);
			$operating= new \app\common\model\Operating;
			if ($operating->where('ID','IN',$id)->delete("$id")) {
				return array('s'=>'ok');
			}else {
				return array('s'=>'删除失败');
			}
		}else {
			return array('s'=>'非法请求');
		}
	}
}
?>