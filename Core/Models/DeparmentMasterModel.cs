using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DeparmentMasterModel : CommonEntityModel
    {
        //public int DeptId { get; set; }
        //public string DeptName { get; set; }
        //public string DeptNameRegional { get; set; }
        //public string IsExtendedLocation { get; set; }
        //public string IsExtendLocType { get; set; }

        public Int64 Id { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameHindi { get; set; }
        public string Abbriviation { get; set; }
        public Int64? DeptTypeId { get; set; }
        public Int64? DistrictId { get; set; }
        public Int16? IsExtendedLocation { get; set; }
        public Int64? StartLocationTypeId { get; set; }
        public Int16? IsExtendLocType { get; set; }
        public Int16? IsActive { get; set; }
        public Int16? IsDeleted { get; set; }
        public Int16? InspectionIsActive { get; set; }
        public string ExtendedLocName { get; set; }
        public string ExtendedLocNameHindi { get; set; }
        public string IsCollectrate { get; set; }
    }
}
