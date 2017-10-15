using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Drawing;
using System.Drawing.Imaging;

namespace LZManager.BLL.Common
{
    public class UpFile
    {
        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="type">类型</param>
        public string UpLoadImage(System.Web.UI.WebControls.FileUpload fileUpLoad, string name, Page page, out string waterImgName, string url)
        {
            waterImgName = "";
            string message = "";
            string serverpath = "";
            string filename = "";
            try
            {
                if (fileUpLoad.PostedFile.FileName == "")
                {
                    message = "";
                }
                else
                {
                    int ipos = fileUpLoad.PostedFile.FileName.LastIndexOf("\\"); //记录最后一个 \ 的位置
                    if (ipos.ToString() != "-1")
                    {
                        filename = fileUpLoad.PostedFile.FileName.Substring(ipos);//获取文件名
                    }
                    else
                    {
                        filename = fileUpLoad.PostedFile.FileName;
                    }
                    int kzname = filename.LastIndexOf(".");
                    filename = name + filename.Substring(kzname); //获取扩展名

                    serverpath = page.Server.MapPath(url) + filename;
                    fileUpLoad.PostedFile.SaveAs(serverpath);
                    message = filename;



                    // 生成水印图片
                    //Bitmap image = null;
                    //image = new Bitmap(serverpath);//实例化图片     
                    //image = AddWaterMark(image);//给图片添加文字        
                    //image.Save(page.Server.MapPath("~/Images/Platform/") + name + "Watcher" + filename.Substring(kzname), ImageFormat.Jpeg);
                    //waterImgName = name + "Watcher" + filename.Substring(kzname);
                    waterImgName = message;
                }
            }
            catch (Exception ex)
            {
                message = "上传发生错误！原因是：" + ex.ToString();
            }

            return message;
        }


        /// <summary>
        /// 给图片添加水印   
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private Bitmap AddWaterMark(Bitmap image)
        {
            //读取config文件中设置的给图片要添加的文字       
            string text = "系统维护中...";
            //读取配置中设置的添加文字的字体大小       
            int fontSize = 30;
            Font font = new Font("宋体", fontSize);
            Brush brush = Brushes.DarkGray;
            Graphics g = Graphics.FromImage(image);//获取用指定字体绘制指定字符串所需要的Size大小        
            SizeF size = g.MeasureString(text, font);//在图片上绘制文字        
            g.DrawString(text, font, brush, image.Width - size.Width, image.Height - size.Height);
            g.Dispose();
            return image;
        }


        public bool IsReusable
        {
            get { return false; }
        }
    }
}
