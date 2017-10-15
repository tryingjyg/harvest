<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;
use think\Response;

class Link extends Admin
{
	public function index() {
		parent::userauth2(92);
		if ($this->request->isAjax())
		{
		    $link_title = input('get.link_title');
    		$link = new \app\common\model\Link;
    		$where = array();
    		if($link_title!=""){
    		    $where['link_title'] = array("LIKE","%$link_title%");
    		}
    		$lists  = $link->where($where)->paginate();
    		$volist = $lists->toArray();
            return Response::create($volist, 'json');
		}
		return $this->fetch();
	}
	//添加内容
	public function add() {
		parent::win_userauth(93);
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
		parent::userauth2(93);
		$request = Request::instance();
		if (request()->isPost()) {
		    $data = array();
		    if(!empty($_FILES['link_pic']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['link_pic']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
			$data['link_title']          = input('post.link_title');
			$data['link_url']            = input('post.link_url');
			$data['link_sort']           = input('post.link_sort');
			$link = new \app\common\model\Link;
			//自动创建并验证数据
			if ($link->data($data)) {
				$link->save();
				parent::operating($request->path(),0,'新增成功');
				$this->success('添加成功',url('Link/index'),3);
			}else {
				parent::operating($request->path(),1,'新增失败'.$link->getError());
				$this->error($link->getError());
			}
		}else {
			parent::operating($request->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//更新文章
	public function edit() {
		parent::win_userauth(94);
		$id = input('get.id');
		if ($id=='' || !is_numeric($id)) {
			parent::operating(request()->path(),1,'参数错误');
			$this->error('参数ID类型错误');
		}
		$id=intval($id);
		$link= new \app\common\model\Link;
		if ($result=$link->where("link_id=$id")->find()) {
			$this->assign('result',$result);
			return $this->fetch();
		}else {
			parent::operating(request()->path(),1,'数据不存在');
			$this->error('没有找到相关数据');
		}
	}
	//修改处理
	public function edit_do() {
		parent::userauth2(94);
		if (request()->isPost()) {
		    $data = array();
		    if(!empty($_FILES['link_pic']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['link_pic']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
		    $link_id                     = input('post.link_id');
			$data['link_title']          = input('post.link_title');
			$data['link_url']            = input('post.link_url');
			$data['link_sort']           = input('post.link_sort');
			$link = new \app\common\model\Link;
			//自动创建并验证数据
			if ($link->save($data,"link_id=".$link_id)) {
				parent::operating(request()->path(),0,'更新成功');
				$this->success('修改成功',url('Link/index'),3);
			}else {
				parent::operating(request()->path(),1,'更新失败：'.$link->getError());
				$this->error($link->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//删除
	public function del() {
		//验证用户权限
		parent::userauth(95);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$id = input('post.id');
			if ($id=='' || !is_numeric($id)) {
				parent::operating(request()->path(),1,'参数错误');
				return array('s'=>'参数ID类型错误');
			}else {
				$id=intval($id);
				$link= new \app\common\model\Link;
				if ($link->where("link_id=$id")->delete()) {
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
		parent::userauth(95);
		if (request()->isAjax()) {
			if (!$delid=explode(',',input('post.delid',''))) {
				return array('s'=>'请选中后再删除');
			}
			$id=join(',',$delid);
			$link= new \app\common\model\Link;
			if ($link->where('link_id','IN',$id)->delete()) {
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
	    $file = request()->file('link_pic');
	    // 移动到框架应用根目录/public/uploads/ 目录下
	    $info = $file->move(ROOT_PATH . 'public' . DS . 'uploads'. DS . 'link');
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
	    parent::userauth2(94);
	    if (request()->isPost()) {
	        $data = array();
	        //echo "<pre>";print_r($_REQUEST);exit;
	        $link_id                     = input('post.link_id');
	        $data['link_title']          = input('post.link_title');
	        $link = new \app\common\model\Link;
	        //自动创建并验证数据
	        if ($link->save($data,"link_id=".$link_id)) {
	            parent::operating(request()->path(),0,'更新成功');
	            $this->success('修改成功',url('Link/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'更新失败：'.$link->getError());
	            $this->error($link->getError());
	        }
	    }else {
	        parent::operating(request()->path(),1,'非法请求');
	        $this->error('非法请求');
	    }
	}
	//修改处理
	public function deleteimage() {
	    parent::userauth2(94);
	    if (request()->isPost()) {
	        $data = array();
	        //echo "<pre>";print_r($_REQUEST);exit;
	        $link_id                     = input('post.key');
	        $data['link_pic']            = "";
	        $link = new \app\common\model\Link;
	        //自动创建并验证数据
	        if ($link->save($data,"link_id=".$link_id)) {
	            parent::operating(request()->path(),0,'图片删除成功');
	            $this->success('修改成功',url('Link/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'图片删除失败：'.$link->getError());
	            $this->error($link->getError());
	        }
	    }else {
	        parent::operating(request()->path(),1,'非法请求');
	        $this->error('非法请求');
	    }
	}
}
