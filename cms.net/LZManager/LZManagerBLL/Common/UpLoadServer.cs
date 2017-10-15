using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web.UI;
using System.Web;
using FastDFS.Client;

namespace LZManager.BLL.Common
{
    public class UpLoadServer
    {
        /// <summary>
        /// 上传图片到图片服务器
        /// </summary>
        /// <param name="FileUpload1">控件名称</param>
        /// <param name="filepath">
        /// 虚拟文件路径
        /// 例如：UploadImages/PicProduct
        /// </param>
        /// <returns></returns>
        public string UpLoadToServer(System.Web.UI.WebControls.FileUpload FileUpload, Page page)
        {
            try
            {
                string[] fileNames = FileUpload.FileName.Split('.');
                return UpLoadToServer(FileUpload.FileBytes, fileNames.Last(), page);
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 上传图片到图片服务器
        /// </summary>
        /// <param name="FileUpload1">控件名称</param>
        /// <param name="filepath">
        /// 虚拟文件路径
        /// 例如：UploadImages/PicProduct
        /// </param>
        /// <returns></returns>
        public string UpLoadToServer(System.Web.UI.WebControls.FileUpload FileUpload, string configPath)
        {
            try
            {
                string[] fileNames = FileUpload.FileName.Split('.');
                return UpLoadToServer(FileUpload.FileBytes, fileNames.Last(), configPath);
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 上传图片到图片服务器
        /// </summary>
        /// <param name="FileUpload1">控件名称</param>
        /// <param name="filepath">
        /// 虚拟文件路径
        /// 例如：UploadImages/PicProduct
        /// </param>
        /// <returns></returns>
        public string UpLoadToServer(System.Web.HttpPostedFile postedFile, string configPath)
        {
            try
            {
                string[] fileNames = postedFile.FileName.Split('.');
                return UpLoadToServer(GetImageToByteArray(postedFile), fileNames.Last(), configPath);
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 上传图片到图片服务器
        /// </summary>
        /// <param name="FileUpload1">控件名称</param>
        /// <param name="filepath">
        /// 虚拟文件路径
        /// 例如：UploadImages/PicProduct
        /// </param>
        /// <returns></returns>
        public string UpLoadToServer(System.Web.UI.HtmlControls.HtmlInputFile InputFile, Page page)
        {
            try
            {
                string[] fileNames = InputFile.PostedFile.FileName.Split('.');
                return UpLoadToServer(GetImageToByteArray(InputFile.PostedFile), fileNames.Last(), page);
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 上传图片到图片服务器
        /// </summary>
        /// <param name="FileUpload1">控件名称</param>
        /// <param name="filepath">
        /// 虚拟文件路径
        /// 例如：UploadImages/PicProduct
        /// </param>
        /// <returns></returns>
        public string UpLoadToServer(System.Web.UI.HtmlControls.HtmlInputFile InputFile, string configPath)
        {
            try
            {
                string[] fileNames = InputFile.PostedFile.FileName.Split('.');
                return UpLoadToServer(GetImageToByteArray(InputFile.PostedFile), fileNames.Last(), configPath);
            }
            catch
            {
                return "error";
            }
        }


        /// <summary>
        /// 上传图片到图片服务器
        /// </summary>
        /// <param name="FileUpload1">控件名称</param>
        /// <param name="filepath">
        /// 虚拟文件路径
        /// 例如：UploadImages/PicProduct
        /// </param>
        /// <returns></returns>
        public string UpLoadToServer(byte[] imageData, string extName, System.Web.UI.Page page)
        {
            try
            {
                return UpLoadToServer(imageData, extName, page.Server.MapPath("~/FastDFS.config"));
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// 上传图片到图片服务器
        /// </summary>
        /// <param name="FileUpload1">控件名称</param>
        /// <param name="filepath">
        /// 虚拟文件路径
        /// 例如：UploadImages/PicProduct
        /// </param>
        /// <returns></returns>
        public string UpLoadToServer(byte[] imageData, string extName, string configPath)
        {
            try
            {
                FastDFSClient DFSClient = new FastDFSClient(configPath);
                StorageNode storage = DFSClient.GetStorageNode("g1");
                string dfsFilePath = DFSClient.UploadFile(storage, imageData, extName);

                return dfsFilePath;
            }
            catch
            {
                return "error";
            }
        }

        /// <summary>
        /// posteFile转byte[]
        /// </summary>
        /// <param name="posteFile"></param>
        /// <returns></returns>
        public static byte[] GetImageToByteArray(HttpPostedFile posteFile)
        {
            Stream stream = posteFile.InputStream;
            byte[] image = new byte[posteFile.ContentLength];
            stream.Read(image, 0, posteFile.ContentLength);
            stream.Close();
            return image;
        }
    }
}
