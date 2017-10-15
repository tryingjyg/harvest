using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LZManager.BLL.Common;
using LZManager.DAL;
using LZManager.BLL;
using System.Data;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using System.Data.SqlClient;

namespace LZManager.Frameworks
{
    public partial class HomeIndex : BasePage
    {
        LoPfanage loPfanage = new LoPfanage();
        private static object lockHelp = new object();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    LoadDay();
                    this.lblOnline.Text = Application["online"].ToString();
                }
                catch
                { }

                UsersEO usersEO = GetUser(); // 获取用户基本信息
                if (usersEO.UrId.ToString() != "")
                {
                    lblUser.Text = usersEO.UrName; // 用户名
                    lblNum.Text = loPfanage.GetNumByUserId(usersEO.UrId, 0).ToString(); // 登录次数
                    DataTable dt = loPfanage.GetTableByUserid(usersEO.UrId, 0, 2);

                    if (dt != null)
                    {
                        if (dt.Rows.Count >= 2)
                        {
                            lblNowLoginTime.Text = dt.Rows[0]["Lg_addtime"].ToString(); //  本次登陆时间
                            lblLastLoginTime.Text = dt.Rows[1]["Lg_addtime"].ToString(); //  上次登陆时间
                            lblNowLoginIp.Text = dt.Rows[0]["Lg_userip"].ToString();    //  本次登陆IP
                            lblLastLoginIp.Text = dt.Rows[1]["Lg_userip"].ToString();    //  上次登陆IP

                            if (dt.Rows[0]["Lg_userip"].ToString() != dt.Rows[1]["Lg_userip"].ToString())
                            {
                                lblLastLoginIp.Style["color"] = "red";
                                lblLastLoginTime.Style["color"] = "red";
                            }
                        }
                        else
                        {
                            lblNowLoginTime.Text = dt.Rows[0]["Lg_addtime"].ToString(); //  本次登陆时间
                            lblLastLoginTime.Text = "首次登陆";
                            lblNowLoginIp.Text = dt.Rows[0]["Lg_userip"].ToString();    //  本次登陆IP
                            lblLastLoginIp.Text = "首次登陆";
                        }
                    }
                }
                else
                {
                    Response.Write("<script>top.location.href = '../Login.aspx' </script>");
                }
            }  
        }

        private void LoadDay()
        {

            string str = GetResponseStr();//获得json天气信息
            //对json格式的信息重新整理一下，因为我们要用.net自带的方法获得相关信息
            str = str.Remove(str.LastIndexOf("}"), 1);
            str = str.Remove(0, 15);

            //使用JavaScriptSerializer对象来解析数据
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            Dictionary<string, object> json = (Dictionary<string, object>)serializer.DeserializeObject(str);

            object str_city;        //-- 城市 -- city
            object str_weather;     //-- 天气 -- weather1
            object str_img_id;      //-- 天气图标编号 -- img1
            object str_temp;        //-- 温度 -- temp1
            object str_fl;          //-- 风力 --fl1
            object str_UV;          //-- 紫外线 -- index_uv
            object str_cy;          //-- 穿衣指数 -- index
            object str_xc;          //-- 洗车指数 -- index_xc
            object str_CO;          //-- 舒适指数 -- index_co
            object str_Time;        //-- 时间 -- date_y
            object str_week;        //-- 星期 -- week

            if (json.TryGetValue("city", out str_city))
            {
                //Response.Write(str_city.ToString());//城市
                lab_City.Text = str_city.ToString();
            }
            if (json.TryGetValue("weather1", out str_weather))
            {
                //Response.Write(str_weather.ToString());//天气
                lab_Tianqi.Text = str_weather.ToString();
            }
            if (json.TryGetValue("temp1", out str_temp))
            {
                //Response.Write(str_temp.ToString());//温度
                lab_wendu.Text = str_temp.ToString();
            }
            if (json.TryGetValue("fl1", out str_fl))
            {
                //Response.Write(str_fl.ToString());//风力
                lab_Fengli.Text = str_fl.ToString();
            }
            if (json.TryGetValue("index_uv", out str_UV))
            {
                //Response.Write(str_UV.ToString());//紫外线
                lab_UV.Text = str_UV.ToString();
            }
            //if (json.TryGetValue("index", out str_cy))
            //{
            //    Response.Write(str_cy.ToString());//穿衣
            //}
            if (json.TryGetValue("index_xc", out str_xc))
            {
                //Response.Write(str_xc.ToString());//洗车
                lab_Xc.Text = str_xc.ToString();
            }
            if (json.TryGetValue("index_co", out str_CO))
            {
                //Response.Write(str_CO.ToString());//舒适
                lab_Co.Text = str_CO.ToString();
            }

            if (json.TryGetValue("date_y", out str_Time))
            {
                // Response.Write(str_Time.ToString());//时间
                lab_Time.Text = str_Time.ToString();
            }
            if (json.TryGetValue("week", out str_week))
            {
                //Response.Write(str_week.ToString());//星期
                lab_Week.Text = str_week.ToString();
            }

            if (json.TryGetValue("img1", out str_img_id))
            {
                //Response.Write(str_img_id.ToString());//图片编号
                img.Src = "http://m.weather.com.cn/img/b" + str_img_id + ".gif";
                img.Width = 50;
                img.Height = 50;
            }

        }

        /// <summary>
        /// 获得天气的信息（json格式）
        /// </summary>
        /// <returns></returns>
        private string GetResponseStr()
        {

            string cacheTodayDay= string.Format("TodayDay_{0}", DateTime.Now.ToString("yyyy-MM-dd hh:00:00"));
            if ((WebCache.GetCache(cacheTodayDay) == null))
            {
                lock (lockHelp)
                {
                    if ((WebCache.GetCache(cacheTodayDay) == null))
                    {
                        string str = "http://m.weather.com.cn/data/101010100.html";
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Stream stream = response.GetResponseStream();//获得回应的数据流
                        //将数据流转成 String
                        string result = new StreamReader(stream, System.Text.Encoding.UTF8).ReadToEnd();

                        WebCache.SetCache(cacheTodayDay, result, 3600);
                    }
                }
            }
            return (string)WebCache.GetCache(cacheTodayDay);
        }
    }
}