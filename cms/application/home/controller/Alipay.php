<?php
namespace app\index\controller;

class Alipay
{
    public function alipay_return()
    {
        // 引入支付宝
        import('Alipay.AlipayNotify'.EXTEND_PATH.'.class.php');
        $config = $config = config('ALIPAY_CONFIG');
        $notify = new \AlipayNotify($config);
        // 验证支付数据
        $status = $notify->verifyReturn();
        if($status){
            // 下面写验证通过的逻辑 比如说更改订单状态等等 $_GET['out_trade_no'] 为订单号；
            $this->success('支付成功');
        }else{
            $this->success('支付失败');
        }
    }
    public function alipay_notify()
    {
        // 引入支付宝
        import('Alipay.AlipayNotify'.EXTEND_PATH.'.class.php');
        $config = $config = config('ALIPAY_CONFIG');
        $alipayNotify = new \AlipayNotify($config);
        // 验证支付数据
        $verify_result = $alipayNotify->verifyNotify();
        if($verify_result) {
            echo "success";
            // 下面写验证通过的逻辑 比如说更改订单状态等等 $_POST['out_trade_no'] 为订单号；
        }else {
            echo "success";
        }
    }
    public function alipay()
    {
		$data=array(
		'out_trade_no'=>time(),
		'price'=>1,
		'subject'=>'测试',
		'show_url'=>'测试',
		'subject'=>'测试',
		);
        alipay($data);
    }
}
