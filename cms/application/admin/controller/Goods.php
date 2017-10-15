<?php
namespace app\admin\controller;
use think\Controller;
use think\Request;
use think\Url;
use think\Response;

class Goods extends Admin
{
	public function index() {
		parent::userauth2(102);
		if ($this->request->isAjax())
		{
		    $goods_sn         = input('get.goods_sn');
		    $goods_name       = input('get.goods_name');
		    $barcode          = input('get.barcode');
    		$goods = new \app\common\model\Goods;
    		$where = array();
    		if($goods_sn!=""){
    		    $where['goods_sn'] = array("LIKE","%$goods_sn%");
    		}
    		if($goods_name!=""){
    		    $where['goods_name'] = array("LIKE","%$goods_name%");
    		}
    		if($barcode!=""){
    		    $where['barcode'] = array("LIKE","%$barcode%");
    		}
    		$lists  = $goods->where($where)->paginate();
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
		    if(!empty($_FILES['goods_image']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['goods_image']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
			$data['goods_sn']            = input('post.goods_sn');
			$data['goods_name']          = input('post.goods_name');
			$data['price']               = input('post.price');
			$data['barcode']             = input('post.barcode');
			$data['create_time']         = time();
			
			$goods = new \app\common\model\Goods;
			//自动创建并验证数据
			if ($goods->data($data)) {
				$goods->save();
				parent::operating($request->path(),0,'新增成功');
				$this->success('添加成功',url('Goods/index'),3);
			}else {
				parent::operating($request->path(),1,'新增失败'.$goods->getError());
				$this->error($goods->getError());
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
		$goods= new \app\common\model\Goods;
		if ($result=$goods->where("goods_id=$id")->find()) {
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
		    if(!empty($_FILES['goods_image']['tmp_name'])){
		        $file = $this->upload();
		        if($file){
		            $data['goods_image']            = $file->getSaveName();
		        }else{
		            $this->error($file->getError());
		        }
		    }
		    $id                          = input('post.id');
			$data['goods_sn']            = input('post.goods_sn');
			$data['goods_name']          = input('post.goods_name');
			$data['price']               = input('post.price');
			$data['barcode']             = input('post.barcode');
			
			$goods = new \app\common\model\Goods;
			//自动创建并验证数据
			if ($goods->save($data,"goods_id=".$id)) {
				parent::operating(request()->path(),0,'更新成功');
				$this->success('修改成功',url('Goods/index'),3);
			}else {
				parent::operating(request()->path(),1,'更新失败：'.$goods->getError());
				$this->error($goods->getError());
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
				$goods= new \app\common\model\Goods;
				if ($goods->where("goods_id=$id")->delete()) {
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
			$goods= new \app\common\model\Goods;
			if ($goods->where('goods_id','IN',$id)->delete()) {
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
	    $file = request()->file('goods_image');
	    // 移动到框架应用根目录/public/uploads/ 目录下
	    $info = $file->move(ROOT_PATH . 'public' . DS . 'uploads'. DS . 'goods');
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
	        $id        = input('post.goods_id');
	        $data      = input('post.');
	        $goods = new \app\common\model\Goods;
	        //自动创建并验证数据
	        if ($goods->save($data,"goods_id=".$id)) {
	            parent::operating(request()->path(),0,'更新成功');
	            $this->success('修改成功',url('Goods/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'更新失败：'.$goods->getError());
	            $this->error($goods->getError());
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
	        $goods = new \app\common\model\Goods;
	        //自动创建并验证数据
	        if ($goods->save($data,"goods_id=".$id)) {
	            parent::operating(request()->path(),0,'图片删除成功');
	            $this->success('修改成功',url('Goods/index'),3);
	        }else {
	            parent::operating(request()->path(),1,'图片删除失败：'.$goods->getError());
	            $this->error($goods->getError());
	        }
	    }else {
	        parent::operating(request()->path(),1,'非法请求');
	        $this->error('非法请求');
	    }
	}
}
