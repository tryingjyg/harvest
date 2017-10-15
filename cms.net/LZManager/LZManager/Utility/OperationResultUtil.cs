using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LZManager.Utility
{
    public class OperationResultUtil
    {
        public const int StateSuccess = 1;
        public const int StateError = -200;

        /// <summary>
        ///     成功状态 State = 1
        /// </summary>
        /// <returns></returns>
        public static OperationResult CreateSuccessResult()
        {
            return new OperationResult
            {
                State = StateSuccess
            };
        }

        /// <summary>
        ///     成功状态 State = 1
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static OperationResult CreateSuccessResult(string message)
        {
            return new OperationResult
            {
                State = StateSuccess,
                Message = message
            };
        }

        public static OperationResult CreateSuccessResult(int state, string message)
        {
            return new OperationResult
            {
                State = state,
                Message = message
            };
        }

        /// <summary>
        ///     成功状态 State = 1
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static OperationResult<TValue> CreateSuccessResult<TValue>(TValue value)
        {
            return new OperationResult<TValue>
            {
                Value = value,
                State = StateSuccess
            };
        }

        /// <summary>
        ///     错误结果 状态
        ///     State = -200
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <returns></returns>
        public static OperationResult CreateErrorResult(string message = "")
        {
            return new OperationResult
            {
                State = StateError,
                Message = message
            };
        }

        /// <summary>
        ///     错误结果 状态
        ///     State = -200
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <returns></returns>
        public static T CreateErrorResult<T>(string message = "") where T : OperationResult, new()
        {
            var instance = Activator.CreateInstance<T>();
            instance.State = StateError;
            instance.Message = message;
            return instance;
        }

        public static OperationResult CreateOperationResult(int state)
        {
            return new OperationResult
            {
                State = state
            };
        }

        public static OperationResult CreateOperationResult(int state, string message)
        {
            return new OperationResult
            {
                State = state,
                Message = message
            };
        }

        public static OperationResult<TValue> CreateOperationResult<TValue>(int state)
        {
            return new OperationResult<TValue>
            {
                Value = default(TValue),
                State = state
            };
        }

        public static OperationResult<TValue> CreateOperationResult<TValue>(int state, TValue value, string message = "")
        {
            return new OperationResult<TValue>
            {
                Value = value,
                State = state,
                Message = message
            };
        }

        #region 注释掉的方法
        ///// <summary>
        /////     try catch方法块
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="callback"></param>
        ///// <param name="logHelper">无参数则无出错日志</param>
        ///// <param name="strErrorDisplayMsg">错误展示信息</param>
        ///// <param name="strErrorLogMsg">错误日志信息</param>
        ///// <returns></returns>
        //public static T TryCatch<T>(Func<T> callback, ILogHelper logHelper = null, string strErrorDisplayMsg = null, string strErrorLogMsg = null) where T : OperationResult, new()
        //{
        //    try
        //    {
        //        return callback();
        //    }
        //    catch (Exception ex)
        //    {
        //        if (logHelper != null)
        //        {
        //            var strMsg = string.Format("{1};MethodName={2};Ex:{0}", ex, strErrorLogMsg, callback);
        //            logHelper.Write(strMsg);
        //        }

        //        return CreateErrorResult<T>(strErrorDisplayMsg);
        //    }
        //} 
        #endregion

    }
}