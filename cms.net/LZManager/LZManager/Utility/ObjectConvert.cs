using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
//using WebApplication1.ViewModels;

namespace LZManager.Utility
{
    public class ObjectConvert
    {
        public static string getModelSortString(Object o)
        {
            return ObjectConvert.getModelSortString(o, true, false);
        }

        public static string getModelSortValueEncodeString(Object o)
        {
            return ObjectConvert.getModelSortString(o, true, true);
        }

        public static string getModelSortString(Object o, Boolean exclude, Boolean encode)
        {
            StringBuilder sb = new StringBuilder();
            IOrderedEnumerable<PropertyInfo> om = o.GetType().GetProperties().OrderBy(a => a.Name);
            foreach (PropertyInfo pi in om)
            {
                if (true == exclude && !string.IsNullOrEmpty(Convert.ToString(pi.GetValue(o,null))))
                {
                    if (true == encode)
                    {
                        sb.AppendFormat("{0}={1}&", Convert.ToString(pi.Name), HttpUtility.UrlEncode(Convert.ToString(pi.GetValue(o, null))));
                    }
                    else
                    {
                        sb.AppendFormat("{0}={1}&", Convert.ToString(pi.Name), Convert.ToString(pi.GetValue(o, null)));
                    }
                }
                else if (false == exclude)
                {
                    if (true == encode)
                    {
                        sb.AppendFormat("{0}={1}&", Convert.ToString(pi.Name), HttpUtility.UrlEncode(Convert.ToString(pi.GetValue(o, null))));
                    }
                    else
                    {
                        sb.AppendFormat("{0}={1}&", Convert.ToString(pi.Name), Convert.ToString(pi.GetValue(o, null)));
                    }
                }
            }
            return sb.ToString();
        }

        public static Dictionary<string, string> getNameValueDictionary(Object o)
        {
            return ObjectConvert.getNameValueDictionary(o, true);
        }

        public static Dictionary<string, string> getNameValueDictionary(Object o, Boolean Encode)
        {

            Dictionary<string, string> dicKeyValue = new Dictionary<string, string>();
            Type t = o.GetType();
            System.Reflection.PropertyInfo[] ps = t.GetProperties();
            foreach (PropertyInfo p in ps)
            {
                if (!string.IsNullOrEmpty(Convert.ToString(p.GetValue(o, null))))
                {
                    if (true == Encode)
                    {
                        dicKeyValue.Add(Convert.ToString(p.Name), HttpUtility.UrlEncode(Convert.ToString(p.GetValue(o, null))));
                    }
                    else
                    {
                        dicKeyValue.Add(Convert.ToString(p.Name), Convert.ToString(p.GetValue(o, null)));
                    }
                }
            }
            return dicKeyValue.OrderBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
        }

        public static void ModelTransfer(Object vm, Object o)
        {
            Type Ordertype = o.GetType();
            System.Reflection.PropertyInfo[] Orderps = Ordertype.GetProperties();
            foreach (PropertyInfo Orderp in Orderps)
            {
                string Orderobj = "";
                if (Orderp.PropertyType == typeof(string))
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(Orderp.GetValue(o, null))))
                    {
                        Orderobj = Convert.ToString(Orderp.GetValue(o, null));
                        ModelTransfer(vm, Orderp, Orderobj);
                    }
                }
                else if (Orderp.PropertyType == typeof(int))
                {
                    if (Convert.ToInt32(Orderp.GetValue(o, null)) != 0)
                    {
                        Orderobj = Convert.ToString(Orderp.GetValue(o, null));
                        ModelTransfer(vm, Orderp, Orderobj);
                    }
                }
                else if (Orderp.PropertyType == typeof(long))
                {
                    if (Convert.ToInt64(Orderp.GetValue(o, null)) != (long)0)
                    {
                        Orderobj = Convert.ToString(Orderp.GetValue(o, null));
                        ModelTransfer(vm, Orderp, Orderobj);
                    }
                }
            }
        }

        public static void ModelTransfer(Object vm, PropertyInfo Orderp, string Orderobj)
        {
            string Ordername = Orderp.Name;
            Type VMtype = vm.GetType();
            System.Reflection.PropertyInfo[] VMps = VMtype.GetProperties();
            foreach (PropertyInfo VMp in VMps)
            {
                string VMname = VMp.Name;
                if (VMname.Equals(Ordername))
                {
                    VMp.SetValue(vm, Orderobj, null);
                }
            }
        }


        /// <summary>
        /// 字符串转字典
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static Dictionary<string, string> StringDecodeValueToSortedDictionary(string text)
        {
            string[] paras = text.Split('&');
            Dictionary<string, string> dicKeyValue = new Dictionary<string, string>();
            foreach (string parameter in paras)
            {
                if (!string.IsNullOrEmpty(parameter))
                {
                    string[] keyValuePair = parameter.Split('=');
                    if (keyValuePair.Count() == 2)
                    {
                        if (!string.IsNullOrEmpty(keyValuePair[1]))
                        {
                            dicKeyValue.Add(keyValuePair[0], HttpUtility.UrlDecode(keyValuePair[1]));
                        }
                    }
                }
            }
            return dicKeyValue.OrderBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
        }

        /// <summary>
        /// 字典排序，并转换成字符串
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public static string DictionaryToSortedString(Dictionary<string, string> Dic)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, string> SortedDic = Dic.OrderBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (KeyValuePair<string, string> pair in SortedDic)
            {
                sb.AppendFormat("{0}={1}&", pair.Key, pair.Value);
            }
            return sb.ToString();
        }

        public static Object DictionaryToModel(Dictionary<string, string> Dic, Object o)
        {
            Type t = o.GetType();
            System.Reflection.PropertyInfo[] ps = t.GetProperties();
            foreach (PropertyInfo p in ps)
            {
                string value = "";
                Dic.TryGetValue(p.Name, out value);
                p.SetValue(o, value, null);
            }
            return o;
        }
    }
}