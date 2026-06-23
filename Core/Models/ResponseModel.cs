using Core.Enums.URM;
using Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    [Serializable]
    [DataContract]
#nullable disable
    public class ResponseModel
    {
        public ResponseModel()
        {
            Status = Status.Success;
        }
        public ResponseModel(Status defaultStatus = Status.Alert)
        {
            Status = defaultStatus;
        }
        private string _msg = "";
        [DataMember]
        public String Message
        {
            get
            {
                if ((int)ReturnMessage != 0)
                {
                    EnumUtility EnumUtility = new EnumUtility();
                    return EnumUtility.GetDescription(ReturnMessage);
                }
                else
                    return _msg;
            }
            set { _msg = value; }
        }
        public ReturnMessage ReturnMessage { get; set; }
        [DataMember]
        public Status Status { get; set; }
        public string SaveOption { get; set; }
        [DataMember]
        public object EntityId { get; set; }
        [DataMember]
        public dynamic CustomObject { get; set; }
        [DataMember]
        public Int32 TotalRecordCount { get; set; }
        [DataMember]
        public Int32 FilteredRecordCount { get; set; }
    }
    
    [Serializable]
    [DataContract]
    public class APIResponse
    {
        [DataMember]
        public string StatusCode { get; set; }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public object Entity { get; set; }
    }
}
