using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace LZManager.Utility
{
    public class Common
    {
        /// <summary>
        /// 验证邮箱是否合法
        /// </summary>
        /// <param name="mailAddress"></param>
        /// <returns></returns>
        public static OperationResult ValidateEmail(string mailAddress)
        {
            string strRegex;
            Regex reg;

            strRegex = @"^[a-zA-Z0-9][a-zA-Z0-9_\-\.]*@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            // Regex reg = new Regex("^[a-zA-Z0-9_-]+@([a-zA-Z0-9-]+\\.){1,}(com|net|edu|miz|biz|cn|cc)$");

            reg = new Regex(strRegex);

            if (!reg.IsMatch(mailAddress))
            {

                return OperationResultUtil.CreateErrorResult("");
            }

            strRegex = @"^.{6,}$";

            reg = new Regex(strRegex);

            if (!reg.IsMatch(mailAddress))
            {
                return OperationResultUtil.CreateErrorResult("邮箱不合法");
            }

            OperationResult operationResult = CheckDirtyWords(mailAddress);
            if (operationResult.State != OperationResultUtil.StateSuccess)
            {
                return operationResult;
            }

            return OperationResultUtil.CreateSuccessResult("邮箱合法");

        }

        /// <summary>
        /// 验证密码是否合法
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static OperationResult ValidatePassword(string pwd)
        {
            string strRegex;
            Regex reg;

            strRegex = @"^[^,;']+$";
            reg = new Regex(strRegex);

            if (!reg.IsMatch(pwd))
            {
                return OperationResultUtil.CreateErrorResult("密码合法");
            }

            strRegex = @"^[^,;']{6,16}$";
            reg = new Regex(strRegex);

            if (!reg.IsMatch(pwd))
            {
                return OperationResultUtil.CreateErrorResult("太短");
            }

            return OperationResultUtil.CreateSuccessResult("成功");
        }

        /// <summary>
        /// 验证用户名
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static OperationResult ValidateUserName(string userName)
        {
            string strRegex;
            Regex reg;

            strRegex = @"^[^\s]*$";
            reg = new Regex(strRegex);

            if (!reg.IsMatch(userName))
            {
                return OperationResultUtil.CreateErrorResult("用户名");
            }

            strRegex = @"^[a-zA-Z0-9_\u4e00-\u9fa5]+$";
            reg = new Regex(strRegex);

            if (!reg.IsMatch(userName))
            {
                return OperationResultUtil.CreateErrorResult("用户名");
            }

            OperationResult operationResult = CheckDirtyWords(userName);
            if (operationResult.State != OperationResultUtil.StateSuccess)
            {
                return operationResult;
            }

            //键入的字符个数是否＜4
            //若是，则提交创建申请后提示：您的Username长度过短，请输入4-20个字符的Username。
            strRegex = @"^[^\s]{4,}$";
            reg = new Regex(strRegex);

            if (!reg.IsMatch(userName))
            {
                return OperationResultUtil.CreateErrorResult("提示的信息");
            }

            //键入的字符个数是否＞20
            //若是，则提交创建申请后提示：您的Username长度过长，请输入4-20个字符的Username。
            strRegex = @"^[^\s]{4,20}$";
            reg = new Regex(strRegex);

            if (!reg.IsMatch(userName))
            {
                return OperationResultUtil.CreateErrorResult("提示的信息");
            }

            return OperationResultUtil.CreateSuccessResult("提示的信息");
        }

        /// <summary>
        /// 检查是否含有屏蔽词
        /// </summary>
        /// <param name="inputWords"></param>
        /// <returns></returns>
        private static OperationResult CheckDirtyWords(string inputWords)
        {
            //键入字符是否含有非法字符（WPT屏蔽词+联众屏蔽词）
            //WPT屏蔽词库需要Hong提供
            //联众屏蔽词库由平台技术部廖腾负责维护
            IEnumerable<string> wptWordBlockList = ReadWPTWordBlockList();
            IEnumerable<string> ourgameBlockList = ReadOurgameWordBlockList();

            //wpt屏蔽词
            if (wptWordBlockList.Any(wpt => inputWords.IndexOf(" " + wpt, System.StringComparison.Ordinal) >= 0) || wptWordBlockList.Any(wpt => inputWords.IndexOf(wpt + " ", System.StringComparison.Ordinal) >= 0))
            {
                return OperationResultUtil.CreateErrorResult("提示的信息");
            }

            //联众屏蔽词
            if (ourgameBlockList.Any(ourgame => inputWords.IndexOf(ourgame, System.StringComparison.Ordinal) >= 0))
            {
                return OperationResultUtil.CreateErrorResult("提示的信息");
            }

            return OperationResultUtil.CreateSuccessResult("");
        }


        public static IEnumerable<string> ReadOurgameWordBlockList()
        {
            try
            {
                //文件缓存依赖
                if (HttpRuntime.Cache.Get("WPTAccount::OurgameWordBlockList") == null)//如果依赖项中的数据发生变化，此会被通知缓存清空（系统完成清空）
                {
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;//获取基目录，它由程序集冲突解决程序用来探测程序集。
                    string filename = baseDirectory + "DirtyWords\\DirtyString.js";

                    CacheDependency dp = new CacheDependency(filename);//建立缓存依赖项dp

                    FileStream fs = File.OpenRead(filename);
                    byte[] buffer = new byte[32768];
                    int BufferLen = buffer.Length;
                    byte[] byteArray = Read2Buffer(fs, BufferLen);
                    string str = System.Text.Encoding.UTF8.GetString(byteArray);
                    IEnumerable<string> strList = str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    HttpRuntime.Cache.Insert("WPTAccount::OurgameWordBlockList", strList, dp);
                    return strList;
                }
                else
                {
                    return HttpRuntime.Cache.Get("WPTAccount::OurgameWordBlockList") == null ? new List<string>() : (IEnumerable<string>)HttpRuntime.Cache.Get("WPTAccount::OurgameWordBlockList");
                }
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }

        public static IEnumerable<string> ReadWPTWordBlockList()
        {
            try
            {
                //文件缓存依赖
                if (HttpRuntime.Cache.Get("WPTAccount::WPTWordBlockList") == null)//如果依赖项中的数据发生变化，此会被通知缓存清空（系统完成清空）
                {
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;//获取基目录，它由程序集冲突解决程序用来探测程序集。
                    string filename = baseDirectory + "DirtyWords\\WPTDirtyWords.txt";

                    CacheDependency dp = new CacheDependency(filename);//建立缓存依赖项dp

                    FileStream fs = File.OpenRead(filename);
                    byte[] buffer = new byte[32768];
                    int BufferLen = buffer.Length;
                    byte[] byteArray = Read2Buffer(fs, BufferLen);
                    string str = System.Text.Encoding.Default.GetString(byteArray);
                    IEnumerable<string> strList = str.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    strList = strList.Select(r => r.IndexOf(" - ", System.StringComparison.Ordinal) >= 0 ? r.Substring(0, r.IndexOf(" - ", System.StringComparison.Ordinal)) : r);

                    HttpRuntime.Cache.Insert("WPTAccount::WPTWordBlockList", strList, dp);
                    return strList;
                }
                else
                {
                    return HttpRuntime.Cache.Get("WPTAccount::WPTWordBlockList") == null ? new List<string>() : (IEnumerable<string>)HttpRuntime.Cache.Get("WPTAccount::WPTWordBlockList");
                }
            }
            catch (Exception)
            {
                return new List<string>();
            }
        }

        public static byte[] Read2Buffer(Stream stream, int BufferLen)
        {
            // 如果指定的无效长度的缓冲区，则指定一个默认的长度作为缓存大小
            if (BufferLen < 1)
            {
                BufferLen = 0x8000;
            }

            // 初始化一个缓存区
            byte[] buffer = new byte[BufferLen];
            int read = 0;
            int block;

            // 每次从流中读取缓存大小的数据，知道读取完所有的流为止
            while ((block = stream.Read(buffer, read, buffer.Length - read)) > 0)
            {
                // 重新设定读取位置
                read += block;

                // 检查是否到达了缓存的边界，检查是否还有可以读取的信息
                if (read == buffer.Length)
                {
                    // 尝试读取一个字节
                    int nextByte = stream.ReadByte();

                    // 读取失败则说明读取完成可以返回结果
                    if (nextByte == -1)
                    {
                        return buffer;
                    }

                    // 调整数组大小准备继续读取
                    byte[] newBuf = new byte[buffer.Length * 2];
                    Array.Copy(buffer, newBuf, buffer.Length);
                    newBuf[read] = (byte)nextByte;
                    buffer = newBuf;// buffer是一个引用（指针），这里意在重新设定buffer指针指向一个更大的内存
                    read++;
                }
            }

            // 如果缓存太大则使用ret来收缩前面while读取的buffer，然后直接返回
            byte[] ret = new byte[read];
            Array.Copy(buffer, ret, read);
            return ret;
        }

    }
}