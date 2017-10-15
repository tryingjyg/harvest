using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TinyFx.Data;
using System.Data;
using LZManager.DAL;
using LZManager.BLL.Common;

namespace LZManager.SQL
{
    public partial class SqlSelect : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAuthorityUrl(this.Page, "SQL/SqlSelect.aspx", 0);
        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDel_Click(object sender, EventArgs e)
        {
            string sql = txtSql.Text;
            DataTable dt = new NxLogMO(txtConn.Text).GetTableBySql(sql);
            gvTable.DataSource = dt;
            gvTable.DataBind();
        }


        /// <summary>
        /// 导出Excel Datatable版本 HTML类型
        /// </summary>
        /// <param name="dt">导出的Datatable</param>
        /// <param name="ExcelName">导出EXCEL的名称 不需要要带有扩展名_xls</param>
        public static void DataTableToExcel(DataTable dt, string Title)
        {
            HttpResponse resp = System.Web.HttpContext.Current.Response;
            string ExcelName = Title + DateTime.Now.ToString("yyyyMMddHHmmss");
            resp.ContentEncoding = System.Text.Encoding.GetEncoding("UTF-8");
            resp.AppendHeader("Content-Disposition", "attachment;filename=" + ExcelName + ".xls");
            string colHeaders = "", ls_item = "";
            DataRow[] myRow = dt.Select();//可以类似dt.Select("id>10")之形式达到数据筛选目的
            int i = 0;
            int cl = dt.Columns.Count;
            //取得数据表各列标题，各标题之间以t分割，最后一个列标题后加回车符 
            //resp.Write("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" /></head><body><table border=1><tr ");
            //添加网格
            resp.Write("<html xmlns:x=\"urn:schemas-microsoft-com:office:excel\"><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />" +
                 "<!--[if gte mso 9]><xml><x:ExcelWorkbook><x:ExcelWorksheets><x:ExcelWorksheet><x:Name>123</x:Name><x:WorksheetOptions><x:Print><x:ValidPrinterInfo /></x:Print></x:WorksheetOptions></x:ExcelWorksheet></x:ExcelWorksheets></x:ExcelWorkbook></xml><![endif]--></head><body><table><tr ");
            for (i = 0; i < cl; i++)
            {
                colHeaders += "<th>" + dt.Columns[i].Caption.ToString() + "</th>";
            }
            resp.Write(colHeaders + "</tr>");
            //向HTTP输出流中写入取得的数据信息
            //逐行处理数据
            foreach (DataRow row in myRow)
            {
                //当前行数据写入HTTP输出流，并且置空ls_item以便下行数据
                ls_item = "<tr>";
                for (i = 0; i < cl; i++)
                {
                    if (i == (cl - 1))//最后一列，加n
                    {
                        ls_item += "<td>'" + row[i].ToString() + "</td></tr>";
                    }
                    else
                    {
                        ls_item += "<td>'" + row[i].ToString() + "</td>";
                    }
                }
                resp.Write(ls_item);
            }
            resp.Write("</table></body></html>");
            resp.End();
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnOut_Click(object sender, EventArgs e)
        {
            string sql = txtSql.Text;
            DataTable dt = new NxLogMO(txtConn.Text).GetTableBySql(sql);
            //DataTableToExcel(dt, "sql导出数据");
            DataTableToExcel(dt, Resources.Resource.SQL_export_data);
        }
    }
}