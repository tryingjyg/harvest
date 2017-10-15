<?php


	function getAccessToken(){
		$appid = "wx7d6684f9dcb1fc7c";//填写公众号或服务号、测试号的appid
		$secret = "a612de7046562c41a53676a820799f58";//填写对应的secriet
		$tokenurl = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=".$appid."&secret=".$secret;
		
		$ch = curl_init();
		curl_setopt($ch,CURLOPT_URL,$tokenurl);
		curl_setopt($ch,CURLOPT_HEADER,0);
		curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1 );
		curl_setopt($ch, CURLOPT_CONNECTTIMEOUT, 10);
		$res = curl_exec($ch);
		curl_close($ch);
		
		// 输出
		$json_obj = json_decode($res,true);
		
		return $json_obj;
	}


	 function getTicket($json_obj){
		 
		$access_token = $json_obj['access_token'];
		
		$url = "https://api.weixin.qq.com/cgi-bin/qrcode/create?access_token=".$access_token;
		 
		$data ='{"expire_seconds": 604800, "action_name": "QR_STR_SCENE", "action_info": {"scene": {"scene_str": "1000538"}}}';
		$ch = curl_init();
		$timeout = 300;
		curl_setopt($ch, CURLOPT_URL, $url);
		// curl_setopt($ch, CURLOPT_REFERER, "http://www.111cn.net/"); // 伪装来路
		curl_setopt($ch, CURLOPT_POST, true);
		curl_setopt($ch, CURLOPT_POSTFIELDS, $data);
		curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
		curl_setopt($ch, CURLOPT_CONNECTTIMEOUT, $timeout);
		curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, FALSE); // URL为SSL时添加这行可解决页面空白
		$res = curl_exec($ch);
		curl_close($ch);
		// 输出
		$json_obj = json_decode($res,true);
		
		
		return $json_obj;
		
	}

	function getQrcode($ticketJson){
		
		
		$ticket = $ticketJson['ticket'];
		
		$ticket = urlencode($ticket);
		
		
		$ticketUrl ="https://mp.weixin.qq.com/cgi-bin/showqrcode?ticket=".$ticket;
		
		
		header('location:'.$ticketUrl);
	}

$access_token = getAccessToken();
$access_ticket = getTicket($access_token);
getQrcode($access_ticket);


