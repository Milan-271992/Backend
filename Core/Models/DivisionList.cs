using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DivisionList
    {
        public Int64 DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionNameHindi { get; set; }
        public string DivisionCode { get; set; }
        public int MasterDivisionId { get; set; }
    }

    public class DistrictList
    {
        public Int64 DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameHindi { get; set; }
        public int MasterDistrictId { get; set; }
    }

    public class GrampanchayatList
    {
        public Int64 TotalRecordCount { get; set; }
        public Int64 GrampanchayatId { get; set; }
        public string GrampanchayatName { get; set; }
        public string GrampanchayatNameHindi { get; set; }
        public int DistrictId { get; set; }
    }

    public class CityList
    {
        public Int64 TotalRecordCount { get; set; }
        public Int64 CityId { get; set; }
        public string CityName { get; set; }
        public string CityNameHindi { get; set; }
        public string Parent_Loc_Id { get; set; }
        public int DistrictId { get; set; }
    }
}
