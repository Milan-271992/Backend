using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class OtpRequestModel : CommonEntityModel
    {
        public string SendOn { get; set; }
        public string SendOnType { get; set; }
        public Int32 ModuleId { get; set; }
        public Int32? SourceId { get; set; }

    }
    public class OtpVerifyModel : CommonEntityModel
    {
        public string TransactionNumber { get; set; }
        public string OTP { get; set; }
        public string SessionId { get; set; }

    }
    public class WithOtpVerifyModel
    {

        public string MobileNumber { get; set; }

    }
    public class WhatsAppModel
    {
        public string name { get; set; }
        public string entityid { get; set; }
        public string entitytypeid { get; set; }
        public string entitytype { get; set; }
        public string servicetype { get; set; }
        public string duration { get; set; }
        public string tempid { get; set; }
        public string mobileno { get; set; }
    }
    public class ScheduleSendNotificationModel
    {
        public int Module { get; set; }
        public string ReferenceId { get; set; }
        public int Event { get; set; }
        public string MobileNos { get; set; }
    }


}
