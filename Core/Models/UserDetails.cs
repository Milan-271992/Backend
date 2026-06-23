using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UserDetails
    {
        public string UserName { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameRegional { get; set; }
        public string SectionName { get; set; }
        public string SectionNameRegional { get; set; }
        public string DesignationName { get; set; }
        public string DesignationNameRegional { get; set; }
        public string RoleName { get; set; }
        public string RoleNameRegional { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string SsoId { get; set; }
        public Int32 RoleID { get; set; }

        public Int32 DesignationID { get; set; }
        public Int64 DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameRegional { get; set; }
    }

    public class UserDataModel
    {
        public long UserId { get; set; }
        public string MobileNo { get; set; }
    }
    public class Privilege
    {
        public string Previleges { get; set; }
        
    }
}
