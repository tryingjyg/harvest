using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LZManager.Common
{
    public class PubFuncs
    {
        //public static string GameIP = System.Configuration.ConfigurationManager.AppSettings["GameIP"].ToString();
        //public static string GamePort = System.Configuration.ConfigurationManager.AppSettings["GamePort"].ToString();

        public PubFuncs()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        /// <summary>
        /// 创建一个GUID值,参数可以是“N 32位”、“D 36位”、“B 38位”或“P 38位”.
        /// </summary>
        /// <param name="format">参数可以是“N 32位”、“D 36位”、“B 38位”或“P 38位”</param>
        /// <returns></returns>
        /// <example>
        /// <code>
        /// "N"：xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx(32 位)
        /// "D"：xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx(由连字符分隔的 36 位数字)
        /// "B"：{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}(括在大括号中、由连字符分隔的 38 位数字)
        /// "p"：(xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx)(括在圆括号中、由连字符分隔的 38 位数字)
        /// </code>
        /// </example>
        public static string NewGUID(string format)
        {
            Guid myGuid = Guid.NewGuid();
            string strGUID = myGuid.ToString(format);

            return strGUID;
        }

        /// <summary>
        /// 返回一个在10000000到99999999之间的随机数
        /// </summary>
        /// <returns></returns>
        public static int GetRandomNumbers()
        {
            Random myRad = new Random();

            return myRad.Next(10000000, 99999999);
        }

        /// <summary>
        /// 返回一个随机字符串，时间格式
        /// </summary>
        /// <param name="intNum">返回字符串的位数，必须是大于0和小于等于32的数</param>
        /// <returns></returns>
        public static string GetDateTimeStrings()
        {
            string strY = DateTime.Now.Year.ToString();
            string strM = DateTime.Now.Month.ToString().PadLeft(2, '0');
            string strD = DateTime.Now.Day.ToString().PadLeft(2, '0');
            string strH = DateTime.Now.Hour.ToString().PadLeft(2, '0');
            string strm = DateTime.Now.Minute.ToString().PadLeft(2, '0');
            string strS = DateTime.Now.Second.ToString().PadLeft(2, '0');

            string str = strY + strM + strD + strH + strm + strS;

            return str;
        }

        /// <summary>
        /// 返回一个随机字符串，GUID格式
        /// </summary>
        /// <param name="intNum">返回字符串的位数，必须是大于0和小于等于32的数</param>
        /// <returns></returns>
        public static string GetRandomStrings(int intNum)
        {
            string str = NewGUID("N");

            if (intNum < str.Length + 1 && intNum > 0)
                str = str.Remove(intNum, str.Length - intNum);
            else
                str = "";

            return str;
        }

        /// <summary>
        /// 得到字符串的MD5加密
        /// </summary>
        /// <param name="str">需要转换的字符串</param>
        /// <returns></returns>
        public static string GetMD5(string str)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5");
        }

        /// <summary>
        /// 得到字符串的SHA1加密
        /// </summary>
        /// <param name="str">需要转换的字符串</param>
        /// <returns></returns>
        public static string GetSHA1(string str)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "sha1");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pg"></param>
        public static void NoLoginUrl(Page pg)
        {
            if (pg.Session["Sys_UserInfo"] == null)
            {
                pg.Response.Write("<script>top.location.href = '../Default.aspx'</script>");
                pg.Response.End();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pg"></param>
        public static void NoLoginUrlFram(Page pg)
        {
            if (pg.Session["Sys_UserInfo"] == null)
            {
                pg.Response.Write("<script>top.location.href = 'Default.aspx'</script>");
                pg.Response.End();
            }
        }

        /// <summary>
        /// 向客户端发送可重复alert信息
        /// </summary>
        /// <param name="Hint"></param>
        /// <param name="pg"></param>
        public static void ResponseRandomAlert(string Hint, Page pg)
        {
            string sc = "alert(\"{0}\");";
            Random rnd = new Random(System.DateTime.Now.Millisecond);
            string scKey = rnd.Next(Int16.MinValue, Int16.MaxValue).ToString();
            ScriptManager.RegisterStartupScript(pg, pg.GetType(), scKey, string.Format(sc, Hint.Replace("\r\n", "")), true);
        }

        /// <summary>
        /// 向客户端发送Javascript脚本,可重复
        /// </summary>
        /// <param name="Script"></param>
        /// <param name="pg"></param>
        public static void ResponseScript(string Script, Page pg)
        {
            Random rnd = new Random(System.DateTime.Now.Millisecond);
            string scKey = rnd.Next(Int16.MinValue, Int16.MaxValue).ToString();
            ScriptManager.RegisterStartupScript(pg, pg.GetType(), scKey, Script, true);
        }

        /// <summary>
        /// 生成跳转页面的Javascript代码
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="pg"></param>
        public static void ResponseRedirectScript(string Url, Page pg)
        {
            ResponseScript("window.navigate('" + Url + "');", pg);
        }

        /// <summary>
        /// 向客户端发送可重复alert信息，同时跳转页面
        /// </summary>
        /// <param name="Hint"></param>
        /// <param name="Url"></param>
        /// <param name="pg"></param>
        public static void ResponseAlertHref(string Hint, string Url, Page pg)
        {
            ResponseScript("alert(\"" + Hint + "\");window.location.href=\"" + Url + "\";", pg);
        }

        /// <summary>
        /// 初始化选择DropDownList的选项
        /// </summary>
        /// <param name="myDrop">DropDownList对象</param>
        /// <param name="strIni">要初始化的值</param>
        public static void IniDropForValue(DropDownList myDrop, string strIniValue)
        {
            for (int i = 0; i < myDrop.Items.Count; i++)
            {
                if (myDrop.Items[i].Value.Trim() == strIniValue)
                {
                    myDrop.Items[i].Selected = true;
                }
                else
                {
                    myDrop.Items[i].Selected = false;
                }
            }
        }

        /// <summary>
        /// 初始化选择DropDownList的选项
        /// </summary>
        /// <param name="myDrop">DropDownList对象</param>
        /// <param name="strIni">要初始化的值</param>
        public static void IniDropForText(DropDownList myDrop, string strIniText)
        {
            for (int i = 0; i < myDrop.Items.Count; i++)
            {
                if (myDrop.Items[i].Text.Trim() == strIniText)
                {
                    myDrop.Items[i].Selected = true;
                }
                else
                {
                    myDrop.Items[i].Selected = false;
                }
            }
        }

        /// <summary>
        /// 初始化选择DropDownList的选项
        /// </summary>
        /// <param name="myDrop">DropDownList对象</param>
        /// <param name="strIni">要初始化的值</param>
        public static void IniRadioButtonListForValue(RadioButtonList myRad, string strIniValue)
        {
            for (int i = 0; i < myRad.Items.Count; i++)
            {
                if (myRad.Items[i].Value.Trim() == strIniValue)
                {
                    myRad.Items[i].Selected = true;
                }
                else
                {
                    myRad.Items[i].Selected = false;
                }
            }
        }

        /// <summary>
        /// 初始化DropDownList控件的数据绑定
        /// </summary>
        /// <param name="myDrop">控件的ID名称</param>
        /// <param name="strSql">要绑定的myDataReader对象</param>
        /// <param name="strName">显示控件的意思如"请选择省"</param>
        public static void IniDropDownList(DropDownList myDrop, SqlDataReader myDataReader, string strName, string strItemName, string strValueName)
        {
            try
            {
                ListItem Item = new ListItem();

                myDrop.Items.Clear();

                if (strName.Trim() != "")
                {
                    Item = new ListItem(strName, "");
                    myDrop.Items.Add(Item);
                }

                // 把数据绑定到控件上
                while (myDataReader.Read())
                {
                    int rusult = 0;
                    if (IsNumeric(strItemName, out rusult))
                        Item = new ListItem(myDataReader[int.Parse(strItemName)].ToString(), myDataReader[int.Parse(strValueName)].ToString());
                    else
                        Item = new ListItem(myDataReader[strItemName].ToString(), myDataReader[strValueName].ToString());

                    myDrop.Items.Add(Item);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                myDataReader.Close();
            }
        }

        /// <summary>
        /// 初始化DropDownList控件的数据绑定
        /// </summary>
        /// <param name="myDrop">控件的ID名称</param>
        /// <param name="strSql">要绑定的myDataReader对象</param>
        /// <param name="strName">显示控件的意思如"请选择省"</param>
        public static void IniDropDownList(DropDownList myDrop, SqlDataReader myDataReader, string strName)
        {
            IniDropDownList(myDrop, myDataReader, strName, "1", "0");
        }

        /// <summary>
        /// 初始化DropDownList控件的数据绑定
        /// </summary>
        /// <param name="myDrop">控件的ID名称</param>
        /// <param name="strSql">要绑定的myDataReader对象</param>
        public static void IniDropDownList(DropDownList myDrop, SqlDataReader myDataReader)
        {
            IniDropDownList(myDrop, myDataReader, "", "1", "0");
        }

        /// <summary>
        /// 初始化DropDownList控件的数据绑定
        /// </summary>
        /// <param name="myDrop">DropDownList控件名称</param>
        /// <param name="Ds">DataSet 数据集合</param>
        /// <param name="strName">第一行添加的字</param>
        /// <param name="strItemName">显示字段</param>
        /// <param name="strValueName">值字段</param>
        public static void IniDropDownList(DropDownList myDrop, DataSet Ds, string strName, string strItemName, string strValueName)
        {
            try
            {
                ListItem Item = new ListItem();

                myDrop.Items.Clear();

                if (strName.Trim() != "")
                {
                    Item = new ListItem(strName, "");
                    myDrop.Items.Add(Item);
                }

                // 把数据绑定到控件上
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    int rusult = 0;
                    if (IsNumeric(strItemName, out rusult))
                        Item = new ListItem(Ds.Tables[0].Rows[i][int.Parse(strItemName)].ToString(), Ds.Tables[0].Rows[i][int.Parse(strValueName)].ToString());
                    else
                        Item = new ListItem(Ds.Tables[0].Rows[i][strItemName].ToString(), Ds.Tables[0].Rows[i][strValueName].ToString());
                    myDrop.Items.Add(Item);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 初始化DropDownList控件的数据绑定
        /// </summary>
        /// <param name="myDrop">DropDownList控件名称</param>
        /// <param name="Ds">DataSet 数据集合</param>
        /// <param name="strName">第一行添加的字</param>
        public static void IniDropDownList(DropDownList myDrop, DataSet Ds, string strName)
        {
            IniDropDownList(myDrop, Ds, strName, "1", "0");
        }

        /// <summary>
        /// 初始化DropDownList控件的数据绑定
        /// </summary>
        public static void IniDropDownList(DropDownList myDrop, DataSet Ds)
        {
            IniDropDownList(myDrop, Ds, "", "1", "0");
        }

        /// <summary>
        /// 初始化DropDownList控件的数据绑定
        /// </summary>
        /// <param name="myDrop">DropDownList控件名称</param>
        /// <param name="Ds">DataSet 数据集合</param>
        public static void IniCheckBoxList(CheckBoxList myChk, DataSet Ds)
        {
            try
            {
                ListItem Item = new ListItem();

                myChk.Items.Clear();

                // 把数据绑定到控件上
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Item = new ListItem(Ds.Tables[0].Rows[i][1].ToString(), Ds.Tables[0].Rows[i][0].ToString());
                    myChk.Items.Add(Item);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 初始化DropDownList控件的数据绑定
        /// </summary>
        public static void IniRadioButtonList(RadioButtonList myRb, DataSet Ds)
        {
            try
            {
                ListItem Item = new ListItem();

                myRb.Items.Clear();

                // 把数据绑定到控件上
                for (int i = 0; i < Ds.Tables[0].Rows.Count; i++)
                {
                    Item = new ListItem(Ds.Tables[0].Rows[i][1].ToString(), Ds.Tables[0].Rows[i][0].ToString());
                    myRb.Items.Add(Item);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 判断是否为数字类型
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsNumeric(string value, out int rusult)
        {
            return int.TryParse(value, out rusult);
        }

        public static bool IsDateTime(string value, out DateTime rusult)
        {
            return DateTime.TryParse(value, out rusult);
        }

        /// <summary>
        /// 替换SQL中的特殊字符
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string ConvertSql(string sql)
        {
            //sql = sql.Replace("", ""); // ADO.NET已经做了，不要自己做
            sql = sql.Replace("[", "[[]"); // 这句话一定要在下面两个语句之前，否则作为转义符的方括号会被当作数据被再次处理
            sql = sql.Replace("_", "[_]");
            sql = sql.Replace("%", "[%]");
            return sql;
        }

        /// <summary>
        /// 判断表里是否有数据行
        /// </summary>
        /// <param name="rowList"></param>
        /// <returns></returns>
        public static bool CheckDataTableRows(DataRow[] rowList)
        {
            bool bol = false;

            if (rowList.Length > 0)
                bol = true;

            return bol;
        }

        /// <summary>
        /// 传入一个带绝对路径的图片文件，返回图片高度
        /// </summary>
        /// <param name="strPic"></param>
        /// <returns></returns>
        public static int[] GetImageWidthHeight(string strPic)
        {
            System.Drawing.Image MyImage = System.Drawing.Image.FromFile(strPic);
            int[] arrint = { MyImage.Width, MyImage.Height };
            MyImage.Dispose();
            return arrint;
        }

        public static string GetStrRemove(string str, int num)
        {
            string strReturn = str;

            if (strReturn.Length > num)
            {
                strReturn = strReturn.Remove(num, strReturn.Length - num) + "...";
            }
            return strReturn;
        }

        /// <summary>
        /// 返回数字分页
        /// </summary>
        /// <param name="PageSize">每页显示条数</param>
        /// <param name="RowCount">总条数</param>
        /// <param name="strPage">页面URL</param>
        /// <param name="Pageindex">当前页数</param>
        /// <returns></returns>
        public static string GetNumPage(int PageSize, int RowCount, string strPage, int Pageindex)
        {
            string str = "";
            int PageCount = PageSize != 1 ? (RowCount % PageSize == 0 ? RowCount / PageSize : RowCount / PageSize + 1) : RowCount / PageSize;
            int spage = Pageindex % 10 > 0 ? Pageindex / 10 * 10 + 1 : (Pageindex / 10 - 1) * 10 + 1;
            int epage = Pageindex % 10 > 0 ? Pageindex / 10 * 10 + 10 : (Pageindex / 10 - 1) * 10 + 10;

            if (spage > 10)
                str += "<a href=\"" + strPage + "/" + (spage / 10 * 10).ToString() + "\" title=\"上十页\"><<</a>";

            if (epage >= PageCount)
                epage = PageCount;

            for (int i = spage; i <= epage; i++)
            {
                str += "<a href=\"" + strPage + "/" + i.ToString() + "\" title=\"第 " + i.ToString() + " 页\">" + i.ToString() + "</a>";
            }

            if (epage < PageCount)
                str += "<a href=\"" + strPage + "/" + (spage / 10 * 10 + 11).ToString() + "\" title=\"下十页\">>></a>";

            //if (spage > 10)
            //    str += "<a href=\"" + strPage + "&page=" + (spage / 10 * 10).ToString() + "\" title=\"上十页\"><<</a>";

            //if (epage >= PageCount)
            //    epage = PageCount;

            //for (int i = spage; i <= epage; i++)
            //{
            //    str += "<a href=\"" + strPage + "&page=" + i.ToString() + "\" title=\"第 " + i.ToString() + " 页\">" + i.ToString() + "</a>";
            //}

            //if (epage < PageCount)
            //    str += "<a href=\"" + strPage + "&page=" + (spage / 10 * 10 + 11).ToString() + "\" title=\"下十页\">>></a>";

            str += "&nbsp;<span>当前" + Pageindex.ToString() + "/" + epage.ToString() + "页</span>";

            return str;
        }

        public static string GetPage(int PageSize, int RowCount, string strPage, int Pageindex)
        {
            string str = "";
            int PageCount = PageSize != 1 ? (RowCount % PageSize == 0 ? RowCount / PageSize : RowCount / PageSize + 1) : RowCount / PageSize;

            str += "【<a href=\"" + strPage + "&page=1\" title=\"首页\">首页</a>】";

            if (Pageindex <= 1)
            {
                str += "【<a href=\"" + strPage + "&page=1\" title=\"上一页\">上一页</a>】";
            }
            else
            {
                str += "【<a href=\"" + strPage + "&page=" + (Pageindex - 1) + "\" title=\"上一页\">上一页</a>】";
            }

            if (Pageindex >= PageCount)
            {
                str += "【<a href=\"" + strPage + "&page=" + PageCount + "\" title=\"下一页\">下一页</a>】";
            }
            else
            {
                str += "【<a href=\"" + strPage + "&page=" + (Pageindex + 1) + "\" title=\"下一页\">下一页</a>】";
            }

            str += "【<a href=\"" + strPage + "&page=" + PageCount + "\" title=\"尾页\">尾页</a>】";

            return str;
        }

        public static byte[] GetImageToByteArray(HttpPostedFile posteFile)
        {
            Stream stream = posteFile.InputStream;
            byte[] image = new byte[posteFile.ContentLength];
            stream.Read(image, 0, posteFile.ContentLength);
            stream.Close();
            return image;
        }

        public static DataSet ExecuteDataSetQueryExcel(string strPath, string strDataSheet)
        {
            try
            {
                OleDbDataAdapter myCommand = null;
                DataSet Ds = null;
                string strConn = "";
                string strExcel = "";

                strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + strPath + ";" + "Extended Properties=Excel 8.0;";
                OleDbConnection Conn = new OleDbConnection(strConn);
                Conn.Open();

                strExcel = "SELECT * FROM [" + strDataSheet + "$]";

                myCommand = new OleDbDataAdapter(strExcel, strConn);
                Ds = new DataSet();
                myCommand.Fill(Ds, "Table1");

                return Ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static DataSet ExecuteDataSetQueryExcel2007(string strPath, string strDataSheet)
        {
            try
            {
                OleDbDataAdapter myCommand = null;
                DataSet Ds = null;
                string strConn = "";
                string strExcel = "";

                // 支持Excel2003 和 Excel2007 的连接字符串  
                // "HDR=yes;"是说第一行是列名而不是数据，"HDR=No;"正好与前面的相反。   
                // 如果列中的数据类型不一致，使用"IMEX=1"可必免数据类型冲突。  

                strConn = "provider=Microsoft.ACE.OleDb.12.0; Data Source ='" + strPath + "';Extended Properties='Excel 12.0;HDR=yes;IMEX=1';";

                OleDbConnection Conn = new OleDbConnection(strConn);
                Conn.Open();

                strExcel = "SELECT * FROM [" + strDataSheet + "$]";

                myCommand = new OleDbDataAdapter(strExcel, strConn);
                Ds = new DataSet();
                myCommand.Fill(Ds, "Table1");

                return Ds;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string GridViewToExportTable(GridView gv)
        {
            string data = "";

            data += "<table cellspacing=\"0\" cellpadding=\"5\" rules=\"all\" border=\"1\">";
            //写出列名
            data += "<tr style=\"font-weight: bold; white-space: nowrap;\">";
            for (int i = 0; i < gv.Columns.Count; i++)
            {
                if (gv.Columns[i].Visible)
                    data += "<td>" + gv.Columns[i].HeaderText.Trim() + "</td>";
            }
            data += "</tr>";

            //写出数据
            for (int i = 0; i < gv.Rows.Count; i++)
            {
                data += "<tr>";
                for (int j = 0; j < gv.Columns.Count; j++)
                {
                    if (gv.Columns[j].Visible)
                    {
                        string strvlue = gv.Rows[i].Cells[j].Text.Trim().Replace("&nbsp;", "");

                        if (GetIsNumber(strvlue))
                        {
                            data += "<td style=\"vnd.ms-excel.numberformat:@\">" + strvlue + "</td>";
                        }
                        else
                        {
                            data += "<td>" + strvlue + "</td>";
                        }
                    }
                }
                data += "</tr>";
            }
            data += "</table>";

            return data;
        }

        public static string DataTableToExportTable(DataTable dt)
        {
            string data = "";

            data += "<table cellspacing=\"0\" cellpadding=\"5\" rules=\"all\" border=\"1\">";
            //写出列名
            data += "<tr style=\"font-weight: bold; white-space: nowrap;\">";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data += "<td>" + dt.Columns[i].ColumnName.Trim() + "</td>";
            }
            data += "</tr>";

            //写出数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data += "<tr>";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string strvlue = dt.Rows[i][j].ToString().Trim().Replace("&nbsp;", "");

                    if (GetIsNumber(strvlue))
                    {
                        data += "<td style=\"vnd.ms-excel.numberformat:@\">" + strvlue + "</td>";
                    }
                    else
                    {
                        data += "<td>" + strvlue + "</td>";
                    }
                }
                data += "</tr>";
            }
            data += "</table>";

            return data;
        }

        public static bool GetIsNumber(string str)
        {
            try
            {
                long i = long.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 格式化游戏豆
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public static string getFormatLong(long l)
        {
            //string loss = l < 0 ? "负" : "";
            //string str = l < 0 ? l.ToString().Replace("-", "") : l.ToString();

            //if (5 <= str.Length && str.Length <= 8)
            //{
            //    str = str.Insert(str.Length - 4, "万");
            //}
            //else if (8 < str.Length)
            //{
            //    str = str.Insert(str.Length - 4, "万").Insert(str.Length - 8, "亿");
            //}

            //string.Format("{0:0,00}",a)

            //return loss + str;

            return string.Format("{0:0,00}", l);
        }

        public static string getGameIP()
        {
            return System.Configuration.ConfigurationManager.AppSettings["GameIP"].ToString();
        }

        public static string getGamePort()
        {
            return System.Configuration.ConfigurationManager.AppSettings["GamePort"].ToString();
        }

        public static string GetIpAddress()
        {
            string hostName = Dns.GetHostName();   //获取本机名
            IPHostEntry localhost = Dns.GetHostEntry(hostName);    //方法已过期，可以获取IPv4的地址
            //IPHostEntry localhost = Dns.GetHostEntry(hostName);   //获取IPv6地址
            IPAddress localaddr = localhost.AddressList[0];

            return localaddr.ToString();
        }

        private DataTable Json2Dtb(string json)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            ArrayList dic = jss.Deserialize<ArrayList>(json);
            DataTable dtb = new DataTable();
            if (dic.Count > 0)
            {
                foreach (Dictionary<string, object> drow in dic)
                {
                    if (dtb.Columns.Count == 0)
                    {
                        foreach (string key in drow.Keys)
                        {
                            dtb.Columns.Add(key, drow[key].GetType());
                        }
                    } DataRow row = dtb.NewRow();
                    foreach (string key in drow.Keys)
                    { row[key] = drow[key]; }
                    dtb.Rows.Add(row);
                }
            }
            return dtb;
        }

        /// <summary>
        /// 校验ip是不是合法
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static int ValidateIp(string ip)
        {
            string strRegex;
            Regex reg;

            strRegex = @"^((23[0-3]|1\d{2}|[1-9]\d|[1-9])\.)((25[0-5]|2[0-4]\d|1?\d{1,2})\.){2}((25[0-5]|2[0-4]\d|1?\d{1,2}))$";
            reg = new Regex(strRegex);

            if (!reg.IsMatch(ip))
            {
                return 1;//ip值不合法
            }

            return 0;//ip值合法
        }


        #region 获取cookie返回中文还是英文

        /// <summary>
        /// 判断当前的cookie值来确定是不是使用英语
        /// </summary>
        /// <returns></returns>
        public static bool IsLanguageEng()
        {
            bool flag = false;

            HttpCookie cookie1 = HttpContext.Current.Request.Cookies["langCook"];

            if (cookie1 != null && cookie1.Values["lang"] == "en-us")
            {

                flag = true;
            }

            return flag;
        }

        #endregion
    }
}