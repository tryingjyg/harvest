using LZManager.BLL;
using LZManager.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace LZManager.WptMall
{
    /// <summary>
    /// getGoodsList 的摘要说明
    /// </summary>
    public class getGoodsList : IHttpHandler
    {
        MallGoodManage goodManage = new MallGoodManage();
        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            context.Response.ContentType = "application/json"; // "text/plain";
            context.Response.AddHeader("Access-Control-Allow-Origin", "*");
            context.Response.AddHeader("Access-Control-Allow-Methods", "GET, POST, OPTIONS");

            IEnumerable<MalltgoodsEO> list = goodManage.Get("", null);
            List<string> jsonData = new List<string>();
            foreach (MalltgoodsEO eo in list)
            {
                jsonData.Add(eo.MgJsondata);
            }
            StringBuilder outStr = new StringBuilder();
            outStr.Append("[");
            for (var i = 0; i < jsonData.Count; i++)
            {
                if (i == jsonData.Count - 1)
                {
                    outStr.Append(jsonData[i]);
                }
                else
                {
                    outStr.Append(jsonData[i] + ",");
                }
            }
            outStr.Append("]");


            //JavaScriptSerializer json = new JavaScriptSerializer();

            //string str = json.Serialize(list);
            string str = "[{ MgNo:'1001',MgName:'good1'}]";
            //"[{ MgNo:'1001',MgName :'商品1',MgPrice :'8',MgDiamondsnum :'80',MgPresentnum :'10',MgRate :'50'},{ MgNo: '1002',MgName :'商品3',MgPrice :'10',MgDiamondsnum :'100',MgPresentnum :'10',MgRate :'50'}]"
            context.Response.Write(outStr.ToString());
            context.Response.End();
            //string Json;
            //DataContractJsonSerializer json = new DataContractJsonSerializer(list.GetType());
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    json.WriteObject(stream, list);
            //    Json = Encoding.UTF8.GetString(stream.ToArray());

            //}

            //context.Response.Write(outStr.ToString());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}