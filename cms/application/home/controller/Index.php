<?php
namespace app\home\controller;
use think\Controller;
use think\Request;
use think\Url;

class Index extends Controller
{
    public function index()
    {
        $where = array();
		$news  = new \app\common\model\News;
		$lists  = $news->where($where)->paginate(6);
		$volist = $lists->toArray();
		$this->assign('volist',$volist);
		$this->assign('lists',$lists);
		
		
		$where = array();
		$where['Sid']  = 7;
		$lists  = $news->where($where)->paginate(8);
		$volist = $lists->toArray();
		$this->assign('case_volist',$volist);
		$this->assign('case_lists',$lists);
        return $this->fetch();
    }
    public function newslist()
    {        
        $where = array();
		$news  = new \app\common\model\News;
		$lists  = $news->where($where)->paginate(9, true, array());
		$volist = $lists->toArray();
		$this->assign('volist',$volist);
		$this->assign('lists',$lists);
        return $this->fetch();
    }
    public function works()
    {        
        $where = array();
        $where['Sid']  = 7;
		$news  = new \app\common\model\News;
		$lists  = $news->where($where)->paginate(8, true, array());
		$volist = $lists->toArray();
		$this->assign('volist',$volist);
		$this->assign('lists',$lists);
        return $this->fetch();
        return $this->fetch();
    }
    public function news()
    {		
        $id = input('id');
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
		
		$result['up_id'] = $news->where("ID>'{$result['ID']}'")->limit(1)->order('ID', 'ASC')->value("ID");
		$result['down_id'] = $news->where("ID<'{$result['ID']}'")->limit(1)->order('ID', 'DESC')->value("ID");
		$this->assign('result',$result);
		$this->assign('clist',$clist);
        return $this->fetch();
    }
    public function infor()
    {
        $id = input('id');
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
        
        $result['up_id'] = $news->where("ID>'{$result['ID']}' AND Sid=7")->limit(1)->order('ID', 'ASC')->value("ID");
        $result['down_id'] = $news->where("ID<'{$result['ID']}' AND Sid=7")->limit(1)->order('ID', 'DESC')->value("ID");
        $this->assign('result',$result);
        $this->assign('clist',$clist);
        return $this->fetch();
    }
    public function leavemessage()
    {
        $request = Request::instance();
        if (request()->isPost()) {
            $data = array();
            $data['realname']            = input('post.realname');
            $data['telephone']           = input('post.telephone');
            $data['email']               = input('post.email');
            $data['company_name']        = input('post.company_name');
            $data['question']            = input('post.question');
            $data['create_time']         = time();
            	
            if($data['telephone'] ==""){
                $this->error('请输入联系电话！');
            }
            $question = new \app\common\model\Question;
            //自动创建并验证数据
            if ($question->data($data)) {
                $question->save();
                $this->success('留言成功',url('Index/index'),3);
            }else {
                $this->error($question->getError());
            }
        }else {
            parent::operating($request->path(),1,'非法请求');
            $this->error('非法请求');
        }
    }
}
