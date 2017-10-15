using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace LZManager.Utility
{
    [DataContract]
    public class OperationResult
    {
        [DataMember]
        public int State { get; set; }

        [DataMember]
        public string Message { get; set; }

        public override string ToString()
        {
            return string.Format("state:{0} message:{1}", State, Message);
        }
    }

    [DataContract]
    public class OperationResult<TValue> : OperationResult
    {
        [DataMember]
        public TValue Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0} value:{1}", base.ToString(), Value);
        }
    }

    [DataContract]
    public class BoolResult : OperationResult
    {
        [DataMember]
        public new bool State { get; set; }
    }
}