<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;
use think\Response;

class Advertisement extends Admin
{
	public function index() {
		parent::userauth2(97);
		if ($this->request->isAjax())
		{
		    $title        = input('get.title');
		    $title_alias  = input('get.title_alias');
    		$advertisement = new \app\common\model\Advertisement;
    		$where = array();
    		if($title!=""){
    		    $where['title'] = array("LIKE","%$title%");
    		}
    		if($title_alias!=""){
    		    $where['title_alias'] = array("LIKE","%$title_alias%");
    		}
    		$lists  = $advertisement->where($where)->paginate();
    		$volist = $lists->toArray();
            return Response::create($volist, 'json');
		}
		return $this->fetch();
	}
	//添加内容
	public function add() {
		parent::win_userauth(97);
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
		parent::userauth2(98);
		$request = Request::instance();
		if (request()->isPost()) {
		    $data = array();
		    if(!empty($_FILES['attach_file']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['attach_file']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
			$data['title']               = input('post.title');
			$data['title_alias']         = input('post.title_alias');
			$data['link_url']            = input('post.link_url');
			$data['image_url']           = input('post.image_url');
			$data['width']               = input('post.width');
			$data['height']              = input('post.height');
			$data['intro']               = input('post.intro');
			$data['start_time']          = strtotime(input('post.start_time'));
			$data['expired_time']        = strtotime(input('post.expired_time'));
			$data['sort_order']          = input('post.sort_order');
			$data['status_is']           = input('post.status_is');
			$data['create_time']         = time();
			$advertisement = new \app\common\model\Advertisement;
			//自动创建并验证数据
			if ($advertisement->data($data)) {
				$advertisement->save();
				parent::operating($request->path(),0,'新增成功');
				$this->success('添加成功',url('Advertisement/index'),3);
			}else {
				parent::operating($request->path(),1,'新增失败'.$advertisement->getError());
				$this->error($advertisement->getError());
			}
		}else {
			parent::operating($request->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//更新文章
	public function edit() {
		parent::win_userauth(99);
		$id = input('get.id');
		if ($id=='' || !is_numeric($id)) {
			parent::operating(request()->path(),1,'参数错误');
			$this->error('参数ID类型错误');
		}
		$id=intval($id);
		$advertisement= new \app\common\model\Advertisement;
		if ($result=$advertisement->where("id=$id")->find()) {
			$this->assign('result',$result);
			return $this->fetch();
		}else {
			parent::operating(request()->path(),1,'数据不存在');
			$this->error('没有找到相关数据');
		}
	}
	//修改处理
	public function edit_do() {
		parent::userauth2(99);
		if (request()->isPost()) {
		    $data = array();
		    if(!empty($_FILES['attach_file']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['attach_file']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
		    $id                          = input('post.id');
			$data['title']               = input('post.title');
			$data['title_alias']         = input('post.title_alias');
			$data['link_url']            = input('post.link_url');
			$data['image_url']           = input('post.image_url');
			$data['width']               = input('post.width');
			$data['height']              = input('post.height');
			$data['intro']               = input('post.intro');
			$data['start_time']          = strtotime(input('post.start_time'));
			$data['expired_time']        = strtotime(input('post.expired_time'));
			$data['sort_order']          = input('post.sort_order');
			$data['status_is']           = input('post.status_is');
			$advertisement = new \app\common\model\Advertisement;
			//自动创建并验证数据
			if ($advertisement->save($data,"id=".$id)) {
				parent::operating(request()->path(),0,'更新成功');
				$this->success('修改成功',url('Advertisement/index'),3);
			}else {
				parent::operating(request()->path(),1,'更新失败：'.$advertisement->getError());
				$this->error($advertisement->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//删除
	public function del() {
		//验证用户权限
		parent::userauth(100);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$id = input('post.id');
			if ($id=='' || !is_numeric($id)) {
				parent::operating(request()->path(),1,'参数错误');
				return array('s'=>'参数ID类型错误');
			}else {
				$id=intval($id);
				$advertisement= new \app\common\model\Advertisement;
				if ($advertisement->where("id=$id")->delete()) {
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
		parent::userauth(100);
		if (request()->isAjax()) {
			if (!$delid=explode(',',input('post.delid',''))) {
				return array('s'=>'请选中后再删除');
			}
			$id=join(',',$delid);
			$advertisement= new \app\common\model\Advertisement;
			if ($advertisement->where('id','IN',$id)->delete()) {
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
	    $file = request()->file('attach_file');
	    // 移动到框架应用根目录/public/uploads/ 目录下
	    $info = $file->move(ROOT_PATH . 'public' . DS . 'uploads'. DS . 'advertisement');
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
	    parent::userauth2(99);
	    if (request()->isPost()) {
	        $data = array();
	        $id        = input('post.id');
	        $data      = input('post.');
	        $advertisement = new \app\common\model\Advertisement;
	        //自动创建并验证数据
	        if ($advertisement->save($data,"id=".$id)) {
	            parent::operating(request()->path(),0,'更新成功');
	            $this->success('修改成功',url('Advertisement/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'更新失败：'.$advertisement->getError());
	            $this->error($advertisement->getError());
	        }
	    }else {
	        parent::operating(request()->path(),1,'非法请求');
	        $this->error('非法请求');
	    }
	}
	//修改处理
	public function deleteimage() {
	    parent::userauth2(99);
	    if (request()->isPost()) {
	        $data = array();
	        //echo "<pre>";print_r($_REQUEST);exit;
	        $id           = input('post.key');
	        $data['attach_file']        = "";
	        $advertisement = new \app\common\model\Advertisement;
	        //自动创建并验证数据
	        if ($advertisement->save($data,"id=".$id)) {
	            parent::operating(request()->path(),0,'图片删除成功');
	            $this->success('修改成功',url('Advertisement/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'图片删除失败：'.$advertisement->getError());
	            $this->error($advertisement->getError());
	        }
	    }else {
	        parent::operating(request()->path(),1,'非法请求');
	        $this->error('非法请求');
	    }
	}
}
