using System.ComponentModel;
using System.Runtime.Serialization;

namespace Core.Models
{
    public class ServiceContactListModel    
    {
        public Int32 SrNo { get; set; }
        public Int32 TotalRecordCount { get; set; }
        public Int32 FilteredRecordCount { get; set; }
        public Int32 ProjectId { get; set; }
        public Int32 OfficerId { get; set; }
        public string ProjectName { get; set; }
        public Int32 RoleId { get; set; }
        public string RoleName { get; set; }        
        public string TeamMetaData { get; set; }
    }

    public class ServiceContactDetailListModel
    {
        public Int32 SrNo { get; set; }
        public Int32 TotalRecordCount { get; set; }
        public Int32 FilteredRecordCount { get; set; }
        public Int32 ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Int32 RoleId { get; set; }
        public string RoleName { get; set; }
        public Int32 OfficerId { get; set; }
        public string ContactPerson { get; set; }
        public string Mobile { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string IP { get; set; }
    }

    public class ServiceContactDetailExcelPdf
    {        
        [DataMember]
        [DisplayName("Sr.No")]
        public Int32 SrNo { get; set; }

        [DataMember]
        [DisplayName("Project")]
        public string ProjectName { get; set; }

        [DataMember]
        [DisplayName("Service Request Role Name")]
        public string RoleName { get; set; }

        [DataMember]
        [DisplayName("Mobile No.")]
        public string Mobile { get; set; }

        [DataMember]
        [DisplayName("Contact Person")]
        public string ContactPerson { get; set; }

        [DataMember]
        [DisplayName("Phone No.")]
        public string PhoneNo { get; set; }

        [DataMember]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [DataMember]
        [DisplayName("IP(Office Ext No.)")]
        public string IP { get; set; }
    }
}
