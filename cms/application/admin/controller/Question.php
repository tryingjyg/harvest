<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;
use think\Response;

class Question extends Admin
{
	public function index() {
		parent::userauth2(102);
		if ($this->request->isAjax())
		{
		    $question_sn         = input('get.question_sn');
		    $question_name       = input('get.question_name');
		    $barcode          = input('get.barcode');
    		$question = new \app\common\model\Question;
    		$where = array();
    		if($question_sn!=""){
    		    $where['question_sn'] = array("LIKE","%$question_sn%");
    		}
    		if($question_name!=""){
    		    $where['question_name'] = array("LIKE","%$question_name%");
    		}
    		if($barcode!=""){
    		    $where['barcode'] = array("LIKE","%$barcode%");
    		}
    		$lists  = $question->where($where)->paginate();
    		$volist = $lists->toArray();
            return Response::create($volist, 'json');
		}
		return $this->fetch();
	}
	//添加内容
	public function add() {
		parent::win_userauth(103);
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
		parent::userauth2(103);
		$request = Request::instance();
		if (request()->isPost()) {
		    $data = array();
		    if(!empty($_FILES['question_image']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['question_image']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
			$data['question_sn']            = input('post.question_sn');
			$data['question_name']          = input('post.question_name');
			$data['price']               = input('post.price');
			$data['barcode']             = input('post.barcode');
			$data['create_time']         = time();
			
			$question = new \app\common\model\Question;
			//自动创建并验证数据
			if ($question->data($data)) {
				$question->save();
				parent::operating($request->path(),0,'新增成功');
				$this->success('添加成功',url('Question/index'),3);
			}else {
				parent::operating($request->path(),1,'新增失败'.$question->getError());
				$this->error($question->getError());
			}
		}else {
			parent::operating($request->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//更新文章
	public function edit() {
		parent::win_userauth(104);
		$id = input('get.id');
		if ($id=='' || !is_numeric($id)) {
			parent::operating(request()->path(),1,'参数错误');
			$this->error('参数ID类型错误');
		}
		$id=intval($id);
		$question= new \app\common\model\Question;
		if ($result=$question->where("id=$id")->find()) {
			$this->assign('result',$result);
			return $this->fetch();
		}else {
			parent::operating(request()->path(),1,'数据不存在');
			$this->error('没有找到相关数据');
		}
	}
	//修改处理
	public function edit_do() {
		parent::userauth2(104);
		if (request()->isPost()) {
		    $data = array();
		    if(!empty($_FILES['question_image']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['question_image']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
		    $id                          = input('post.id');
			$data['question_sn']            = input('post.question_sn');
			$data['question_name']          = input('post.question_name');
			$data['price']               = input('post.price');
			$data['barcode']             = input('post.barcode');
			
			$question = new \app\common\model\Question;
			//自动创建并验证数据
			if ($question->save($data,"id=".$id)) {
				parent::operating(request()->path(),0,'更新成功');
				$this->success('修改成功',url('Question/index'),3);
			}else {
				parent::operating(request()->path(),1,'更新失败：'.$question->getError());
				$this->error($question->getError());
			}
		}else {
			parent::operating(request()->path(),1,'非法请求');
			$this->error('非法请求');
		}
	}
	//删除
	public function del() {
		//验证用户权限
		parent::userauth(105);
		//判断是否是ajax请求
		if (request()->isAjax()) {
			$id = input('post.id');
			if ($id=='' || !is_numeric($id)) {
				parent::operating(request()->path(),1,'参数错误');
				return array('s'=>'参数ID类型错误');
			}else {
				$id=intval($id);
				$question= new \app\common\model\Question;
				if ($question->where("id=$id")->delete()) {
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
		parent::userauth(105);
		if (request()->isAjax()) {
			if (!$delid=explode(',',input('post.delid',''))) {
				return array('s'=>'请选中后再删除');
			}
			$id=join(',',$delid);
			$question= new \app\common\model\Question;
			if ($question->where('id','IN',$id)->delete()) {
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
	    $file = request()->file('question_image');
	    // 移动到框架应用根目录/public/uploads/ 目录下
	    $info = $file->move(ROOT_PATH . 'public' . DS . 'uploads'. DS . 'question');
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
	    parent::userauth2(104);
	    if (request()->isPost()) {
	        $data = array();
	        $id        = input('post.id');
	        $data      = input('post.');
	        $question = new \app\common\model\Question;
	        //自动创建并验证数据
	        if ($question->save($data,"id=".$id)) {
	            parent::operating(request()->path(),0,'更新成功');
	            $this->success('修改成功',url('Question/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'更新失败：'.$question->getError());
	            $this->error($question->getError());
	        }
	    }else {
	        parent::operating(request()->path(),1,'非法请求');
	        $this->error('非法请求');
	    }
	}
	//修改处理
	public function deleteimage() {
	    parent::userauth2(104);
	    if (request()->isPost()) {
	        $data = array();
	        //echo "<pre>";print_r($_REQUEST);exit;
	        $id           = input('post.key');
	        $data['attach_file']        = "";
	        $question = new \app\common\model\Question;
	        //自动创建并验证数据
	        if ($question->save($data,"id=".$id)) {
	            parent::operating(request()->path(),0,'图片删除成功');
	            $this->success('修改成功',url('Question/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'图片删除失败：'.$question->getError());
	            $this->error($question->getError());
	        }
	    }else {
	        parent::operating(request()->path(),1,'非法请求');
	        $this->error('非法请求');
	    }
	}
}