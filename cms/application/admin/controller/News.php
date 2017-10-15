<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;

class News extends Admin
{
	public function classindex() {
		parent::userauth2(45);
		$newsclass = new \app\common\model\Newsclass;
		$user = new \app\common\model\User;
		$where = array();
		$lists  = $newsclass->where($where)->paginate();
		$volist = $lists->toArray();
		foreach($volist['data'] as $k=>$v){
		    $volist['data'][$k]['Username'] = $user->where("ID=".$v['Uid'])->value('Username');
		}
		$this->assign('volist',$volist);			
		$this->assign('lists',$lists);
		return $this->fetch();
	}
	//添加分类
	public function classadd() {
		parent::win_userauth(46);
		return $this->fetch();
	}
	//添加分类处理
	public function classadd_do() {
		parent::userauth(46);
		if (request()->isAjax()) {
			$data = array();
			$data['ClassName']   = input('post.classname');
			$data['Description'] = input('post.description');
			$newsclass = new \app\common\model\Newsclass;
			//自动创建并验证数据
			if ($newsclass->save($data)) {
				parent::operating(request()->path(),0,'新增成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'新增失败:'.$newsclass->getError());
				return array('s'=>$newsclass->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//修改分类
	public function classedit() {
		parent::win_userauth(47);
		$id = input('get.id');
		if ($id=='' || !is_numeric($id)) {
			parent::operating(request()->path(),1,'参数错误');
			$this->assign('content','参数ID类型错误，请关闭本窗口');
			return $this->fetch('Public/err');
		}
		$id=intval($id);
		$newsclass= new \app\common\model\Newsclass;
		if ($result=$newsclass->where("ID=$id")->find()) {
			$this->assign('result',$result);
			return $this->fetch();
		}else {
			parent::operating(request()->path(),1,'数据不存在');
			$this->assign('content','没有找到相关数据，请关闭本窗口');
			return $this->fetch('Public/err');
		}
	}
	//修改分类处理
	public function classedit_do() {
		parent::userauth(47);
		if (request()->isAjax()) {
			$data = array();
			$ID                  = input('post.id');
			$data['ClassName']   = input('post.classname');
			$data['Description'] = input('post.description');
			$newsclass = new \app\common\model\Newsclass;
			//自动创建并验证数据
			if ($newsclass->save($data,"ID=".$ID)) {
				parent::operating(request()->path(),0,'更新成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'更新失败'.$newsclass->getError());
				return array('s'=>$newsclass->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
	//删除分类
	public function classdel() {
		//验证用户权限
		parent::userauth(48);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$id = input('post.id');
			if ($id=='' || !is_numeric($id)) {
				parent::operating(request()->path(),1,'参数错误');
				return array('s'=>'参数ID类型错误');
			}else {
				$id=intval($id);
				$newsclass= new \app\common\model\Newsclass;
				if ($newsclass->where("ID=$id")->delete()) {
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
	}
	
	//内容管理
	public function news() {		
		parent::userauth2(84);
	    $where = array();
		$sid   = input('request.sid');
		if ($sid!='') {
		    $where['Sid'] = intval($sid);
		}
		$news  = new \app\common\model\News;
		$user  = new \app\common\model\User;
		$newsclass= new \app\common\model\Newsclass;
		$lists  = $news->where($where)->paginate();
		$volist = $lists->toArray();
		foreach($volist['data'] as $k=>$v){
		    $volist['data'][$k]['Username']   = $user->where("ID=".$v['Uid'])->value('Username');
		    $volist['data'][$k]['ClassName']  = $newsclass->where("ID=".$v['Sid'])->value('ClassName');
		}
		$clist = $newsclass->order('ID asc')->select();
		$this->assign('volist',$volist);
		$this->assign('sid',$sid);
		$this->assign('clist',$clist);
		$this->assign('lists',$lists);
		return $this->fetch();
	}
	//添加内容
	public function add() {
		parent::win_userauth(49);
		$newsclass = new \app\common\model\Newsclass;
		$clist = $newsclass->order('Dtime asc')->select();
		$this->assign('clist',$clist);
		//排序ID
		$news = $user = new \app\common\model\News;
		$Sortid = $news->count()+1;
		$this->assign('Sortid',$Sortid);
		return $this->fetch();
	}
	//添加处理
	public function add_do() {
		parent::userauth2(49);
		$request = Request::instance();
		if (request()->isPost()) {
			$data = array();
			$data['Sid']     = input('post.Sid');
			$data['Title']   = htmlspecialchars(input('post.Title'));
			//$data['Aliases'] = htmlspecialchars($_POST['Aliases']);
			$data['Sortid']      = input('post.Sortid');
			$data['Description'] = htmlspecialchars(input('post.Description'));
			$data['Content']     = input('post.Content');
			$news = new \app\common\model\News;
			//自动创建并验证数据
			if ($news->data($data)) {
				$news->save();
				parent::operating($request->path(),0,'新增成功');
				$this->success('添加成功',url('News/news'),3);
			}else {
				parent::operating($request->path(),1,'新增失败'.$news->getError());
				$this->error($news->getError());
			}
		}else {
			parent::operating($request->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//更新文章
	public function edit() {
		parent::win_userauth(50);
		$id = input('get.id');
		if ($id=='' || !is_numeric($id)) {
			parent::operating(request()->path(),1,'参数错误');
			$this->error('参数ID类型错误');
		}
		$id=intval($id);
		$news= new \app\common\model\News;
		if ($result=$news->where("ID=$id")->find()) {
			//分类数据
			$newsclass = new \app\common\model\Newsclass;
			$clist = $newsclass->order('ID asc')->select();
			$this->assign('result',$result);
			$this->assign('clist',$clist);
			return $this->fetch();
		}else {
			parent::operating(request()->path(),1,'数据不存在');
			$this->error('没有找到相关数据');
		}
	}
	//修改处理
	public function edit_do() {
		parent::userauth2(50);
		if (request()->isPost()) {
			$data = array();
			$ID                  = input('post.ID');
			$data['Sid']         = input('post.Sid');
			$data['Title']       = htmlspecialchars(input('post.Title'));
			$data['Sortid']      = input('post.Sortid');
			$data['Description'] = htmlspecialchars(input('post.Description'));
			$data['Content']     = input('post.Content');
			$news = new \app\common\model\News;
			//自动创建并验证数据
			if ($news->save($data,"ID=".$ID)) {
				parent::operating(request()->path(),0,'更新成功');
				$this->success('修改成功',url('News/news'),3);
			}else {
				parent::operating(request()->path(),1,'更新失败：'.$news->getError());
				$this->error($news->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//文章详情
	public function article() {
		$id = input('get.id');
		if ($id =='' && !is_numeric($id)) {
			$this->error('参数错误');
		}
		$id = intval($id);
		$news = new \app\common\model\News;
		$user = new \app\common\model\User;
		$result=$news->where("ID = $id")->find();
		$result['Username'] = $user->where("ID='{$result['Uid']}'")->value("Username");
		$news->where("ID = $id")->setInc('View');
		//分类数据
		$newsclass = new \app\common\model\Newsclass;
		$clist = $newsclass->order('ID asc')->select();
		$this->assign('result',$result);
		$this->assign('clist',$clist);
		return $this->fetch();
	}
	//删除
	public function newsdel() {
		//验证用户权限
		parent::userauth(51);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$id = input('post.id');
			if ($id=='' || !is_numeric($id)) {
				parent::operating(request()->path(),1,'参数错误');
				return array('s'=>'参数ID类型错误');
			}else {
				$id=intval($id);
				$news= new \app\common\model\News;
				if ($news->where("ID=$id")->delete()) {
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
	}
	//批量删除
	public function newsindel() {
		//验证用户权限
		parent::userauth(51);
		if (request()->isAjax()) {
			if (!$delid=explode(',',input('post.delid',''))) {
				return array('s'=>'请选中后再删除');
			}
			//将最后一个元素弹出栈
			array_pop($delid);
			$id=join(',',$delid);
			$news= new \app\common\model\News;
			if ($news->where('ID','IN',$id)->delete()) {
				parent::operating(request()->path(),0,'删除成功');
				return array('s'=>'ok');
			}else {
				parent::operating(request()->path(),1,'删除失败');
				return array('s'=>'删除失败');
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			return array('s'=>'非法请求');
		}
	}
}
