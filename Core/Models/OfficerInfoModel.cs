using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class OfficerInfoModel
    {
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public string InternalUserID { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string DepartmentNameRegional { get; set; }
        public string Office { get; set; }
        public string OfficeRegional { get; set; }
        public string OfficeNo { get; set; }
        public string Section { get; set; }
        public string Role { get; set; }
        public string Mobile { get; set; }
        public string SSOId { get; set; }
        public string IsDefault { get; set; }
        public byte[] ProfilePic { get; set; }
        public string OfficeType { get; set; }
        public string OfficeTypeRegional { get; set; }
        public string Email { get; set; }
        public string OfficerCompleteDetail { get; set; }
    }

    public class OfficerInfoModel_v1
    {
        public Int64 UserProfileId { get; set; }
        public Int64 UserId { get; set; }
        public string Name { get; set; }
        public string InternalUserID { get; set; }
        public string Designation { get; set; }
        public string Designation_Regional { get; set; }
        public string DesgId { get; set; }
        public string Department { get; set; }
        public string Department_Regional { get; set; }
        public string DepartId { get; set; }
        public string Office { get; set; }
        public string OfficeNo { get; set; }
        public string SectionId { get; set; }
        public string Section { get; set; }
        public string Section_Regional { get; set; }
        public string Role { get; set; }
        public string Role_Relional { get; set; }
        public string RoleId { get; set; }
        public string Mobile { get; set; }
        public string SSOId { get; set; }
        public string IsDefault { get; set; }
        public byte[] ProfilePic { get; set; }
        public string OfficeType { get; set; }
        public string Email { get; set; }
        public string OfficeName { get; set; }
        public string officeNameHindi { get; set; }
        public string Abbr { get; set; }
        

        //public string OrgAuth { get; set; }

    }
    public class RequestData
    {
        public string ssoid { get; set; }
    }
    public class OfficeDetailBySso
    {
        public string OfficeId { get; set; }
        public string Name { get; set; }
        public string Officetype { get; set; }
    }
    public class OfficerInfoModelForGrvnc
    {
        public string userName { get; set; }
        public string departmentName { get; set; }
        public string departmentNameRegional { get; set; }
        public string sectionName { get; set; }
        public string sectionNameRegional { get; set; }
        public string designationName { get; set; }
        public string designationNameRegional { get; set; }
        public string roleName { get; set; }
        public string roleNameRegional { get; set; }
        public string mobileNumber { get; set; }
        public string email { get; set; }
        public string ssoId { get; set; }
        public Int32 roleID { get; set; }
        public Int32 designationID { get; set; }
        public Int32 districtId { get; set; }
        public string districtName { get; set; }
        public string districtNameRegional { get; set; }

    }
    public class OfficerInfoModel_v1NEW
    {
        public Int64 UserProfileId { get; set; }
        public Int64 UserId { get; set; }
        public string Name { get; set; }
        public string InternalUserID { get; set; }
        public string Designation { get; set; }
        public string Designation_Regional { get; set; }
        public object DesgId { get; set; }
        public string Department { get; set; }
        public string Department_Regional { get; set; }
        public object DepartId { get; set; }
        public string Office { get; set; }
        public string OfficeNo { get; set; }
        public object SectionId { get; set; }
        public string Section { get; set; }
        public string Section_Regional { get; set; }
        public string Role { get; set; }
        public string Role_Relional { get; set; }
        public object RoleId { get; set; }
        public object Mobile { get; set; }
        public string SSOId { get; set; }
        public string IsDefault { get; set; }
        public byte[] ProfilePic { get; set; }
        public string OfficeType { get; set; }
        public string Email { get; set; }
        public string OfficeName { get; set; }
        public string officeNameHindi { get; set; }
        public string Abbr { get; set; }

    }

}
