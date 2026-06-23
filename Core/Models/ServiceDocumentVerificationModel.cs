using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ServiceDocumentVerificationModel : CommonEntityModel
    {
        public Int64 VerificationId { get; set; }
        public Int64? RequestId { get; set; }
        public string VerificationNo { get; set; }
        public Int64? MobileNo { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantNameRegional { get; set; }
        public string Description { get; set; }
        public Int64? StatusId { get; set; }
        public Int64 UserId { get; set; }
    }

    public class MobileNoRequest
    {
        public Int64 MobileNo { get; set; }
    }




}


