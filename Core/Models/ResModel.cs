using Core.Enums.URM;
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
    public class ResModel
    {
        public ResModel()
        {
            Status = Status.Success;
        }
        public ResModel(Status defaultStatus = Status.Alert)
        {
            Status = defaultStatus;
        }
        private string _msg = "";
        [DataMember]
        public String Message
        {
            get
            {
                return _msg;
            }
            set { _msg = value; }
        }
        [DataMember]
        public Status Status { get; set; }
       
    }
    
}
