<?php

$dailiUnionID = '101';

function getBaseInfo(){
	 
	 $appid = "wx7d6684f9dcb1fc7c";
	 $toUrls="http://source1.aizhidiaosu.com/wxToShow/wxToBaby".$dailiUnionID.".php";
	 $redirect_uri = urlencode($toUrls);
	 //静默授权只能获得opendID 无法获得详细信息
	 //$url = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=".$appid."&redirect_uri=".$redirect_uri."&response_type=code&scope=snsapi_base&state=123#wechat_redirect";
	 //用户手动授权  可以获得详细信息
	 $url = "https://open.weixin.qq.com/connect/oauth2/authorize?appid=".$appid."&redirect_uri=".$redirect_uri."&response_type=code&scope=snsapi_userinfo&state=STATE#wechat_redirect";
	
	 $_SESSION['unionID'] = $dailiUnionID;
	 header('location:'.$url);
}
getBaseInfo();