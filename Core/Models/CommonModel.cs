using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
   
    public class CampRequestModel_SW
    {
        public int CampId { get; set; }
        public List<dynamic> RequestModel { get; set; }
        public dynamic GrievanceDetail { get; set; }
    }

    public class CallbackRequestModel_SW
    {
        public Int64 Id { get; set; }
        public string NeedAssistance { get; set; }
        public string IsMobileVerified { get; set; }
        public Int64? CreatedBy { get; set; }
        public Int64? ModifiedBy { get; set; }
        public Int64? CompSourceId { get; set; }
        public string ComplainantName { get; set; }
        public Int64? MobileNo { get; set; }
        public string Description { get; set; }
        public Int64?[] AttachmentId { get; set; }
        public string TransactionId { get; set; }
        public string WebSesssionId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string SendOnType { get; set; }
        public string RequestNo { get; set; }
        public Int16? IsCallBackFor { get; set; }
        public string IsRequired { get; set; }
        public Int64 ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameRegional { get; set; }
        public Int64 EmDeptId { get; set; }
        public string EmDeptName { get; set; }
        public string EmDeptNameRegional { get; set; }
        public Int64 ProfileId { get; set; }
        public Int64 UserId { get; set; }
        public Int64?[] MediaId { get; set; }
    }

    public class CallCenterBroadCastings
    {

		public Int64 RequestId { get; set; }
		public Int64 ModuleId { get; set; }
		public Int64 EventId { get; set; }
		public Int64 MobileNumber { get; set; }
		public string CitizenName { get; set; }
		public string Description { get; set; }
		public Int64 CampaignId { get; set; }
		public Int64 OrgId { get; set; }
	}


}
