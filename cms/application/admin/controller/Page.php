<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;
use think\Response;

class Page extends Admin
{
	public function index() {
		parent::userauth2(110);
		if ($this->request->isAjax())
		{
		    $title        = input('get.title');
		    $title_alias  = input('get.title_alias');
    		$page = new \app\common\model\Page;
    		$where = array();
    		if($title!=""){
    		    $where['title'] = array("LIKE","%$title%");
    		}
    		if($title_alias!=""){
    		    $where['title_alias'] = array("LIKE","%$title_alias%");
    		}
    		$lists  = $page->where($where)->paginate();
    		$volist = $lists->toArray();
            return Response::create($volist, 'json');
		}
		return $this->fetch();
	}
	//添加内容
	public function add() {
		parent::win_userauth(115);
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
		parent::userauth2(115);
		$request = Request::instance();
		if (request()->isPost()) {
		    $data = array();
		    if(!empty($_FILES['attach_thumb']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['attach_thumb']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
			$data['title']               = input('post.title');
			$data['title_second']        = input('post.title_second');
			$data['title_alias']         = input('post.title_alias');
			$data['intro']               = input('post.intro');
			$data['content']             = input('post.content');
			$data['seo_title']           = input('post.seo_title');
			$data['seo_keywords']        = input('post.seo_keywords');
			$data['seo_description']     = input('post.seo_description');

			$data['create_time']         = time();
			$page = new \app\common\model\Page;
			//自动创建并验证数据
			if ($page->data($data)) {
				$page->save();
				parent::operating($request->path(),0,'新增成功');
				$this->success('添加成功',url('Page/index'),3);
			}else {
				parent::operating($request->path(),1,'新增失败'.$page->getError());
				$this->error($page->getError());
			}
		}else {
			parent::operating($request->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//更新文章
	public function edit() {
		parent::win_userauth(116);
		$id = input('get.id');
		if ($id=='' || !is_numeric($id)) {
			parent::operating(request()->path(),1,'参数错误');
			$this->error('参数ID类型错误');
		}
		$id=intval($id);
		$page= new \app\common\model\Page;
		if ($result=$page->where("id=$id")->find()) {
			$this->assign('result',$result);
			return $this->fetch();
		}else {
			parent::operating(request()->path(),1,'数据不存在');
			$this->error('没有找到相关数据');
		}
	}
	//修改处理
	public function edit_do() {
		parent::userauth2(116);
		if (request()->isPost()) {
		    $data = array();
		    if(!empty($_FILES['attach_thumb']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['attach_thumb']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
		    $id                          = input('post.id');
			$data['title']               = input('post.title');
			$data['title_second']        = input('post.title_second');
			$data['title_alias']         = input('post.title_alias');
			$data['intro']               = input('post.intro');
			$data['content']             = input('post.content');
			$data['seo_title']           = input('post.seo_title');
			$data['seo_keywords']        = input('post.seo_keywords');
			$data['seo_description']     = input('post.seo_description');
			
			$page = new \app\common\model\Page;
			//自动创建并验证数据
			if ($page->save($data,"id=".$id)) {
				parent::operating(request()->path(),0,'更新成功');
				$this->success('修改成功',url('Page/index'),3);
			}else {
				parent::operating(request()->path(),1,'更新失败：'.$page->getError());
				$this->error($page->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//删除
	public function del() {
		//验证用户权限
		parent::userauth(117);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$id = input('post.id');
			if ($id=='' || !is_numeric($id)) {
				parent::operating(request()->path(),1,'参数错误');
				return array('s'=>'参数ID类型错误');
			}else {
				$id=intval($id);
				$page= new \app\common\model\Page;
				if ($page->where("id=$id")->delete()) {
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
	public function indel() {
		//验证用户权限
		parent::userauth(117);
		if (request()->isAjax()) {
			if (!$delid=explode(',',input('post.delid',''))) {
				return array('s'=>'请选中后再删除');
			}
			$id=join(',',$delid);
			$page= new \app\common\model\Page;
			if ($page->where('id','IN',$id)->delete()) {
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
	public function upload(){
	    // 获取表单上传文件 例如上传了001.jpg
	    $file = request()->file('attach_thumb');
	    // 移动到框架应用根目录/public/uploads/ 目录下
	    $info = $file->move(ROOT_PATH . 'public' . DS . 'uploads'. DS . 'page');
	    if($info){
	        // 成功上传后 获取上传信息
	        // 输出 jpg
	        //echo $info->getExtension();
	        // 输出 20160820/42a79759f284b767dfcb2a0197904287.jpg
	        //echo $info->getSaveName();
	        // 输出 42a79759f284b767dfcb2a0197904287.jpg
	        //echo $info->getFilename();
	    }else{
	        // 上传失败获取错误信息
	        //echo $file->getError();
	    }
	    return $info;
	}
	//修改处理
	public function editfield() {
	    parent::userauth2(116);
	    if (request()->isPost()) {
	        $data = array();
	        $id        = input('post.id');
	        $data      = input('post.');
	        $page = new \app\common\model\Page;
	        //自动创建并验证数据
	        if ($page->save($data,"id=".$id)) {
	            parent::operating(request()->path(),0,'更新成功');
	            $this->success('修改成功',url('Page/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'更新失败：'.$page->getError());
	            $this->error($page->getError());
	        }
	    }else {
	        parent::operating(request()->path(),1,'非法请求');
	        $this->error('非法请求');
	    }
	}
	//修改处理
	public function deleteimage() {
	    parent::userauth2(116);
	    if (request()->isPost()) {
	        $data = array();
	        //echo "<pre>";print_r($_REQUEST);exit;
	        $id           = input('post.key');
	        $data['attach_file']        = "";
	        $page = new \app\common\model\Page;
	        //自动创建并验证数据
	        if ($page->save($data,"id=".$id)) {
	            parent::operating(request()->path(),0,'图片删除成功');
	            $this->success('修改成功',url('Page/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'图片删除失败：'.$page->getError());
	            $this->error($page->getError());
	        }
	    }else {
	        parent::operating(request()->path(),1,'非法请求');
	        $this->error('非法请求');
	    }
	}
}
