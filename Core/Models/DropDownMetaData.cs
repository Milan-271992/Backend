using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DropDownMetaData
    {
        public DropdownsEnglishName EnglishName { get; set; }
        public DropdownsRegionalName RegionalName { get; set; }
    }
    public class DropdownsEnglishName
    {
        public string DepartmentName { get; set; }
        public string DepartmentTypeName { get; set; }
        public string DistrictName { get; set; }
        public string PanchayatName { get; set; }
        public string GramPanchayatName { get; set; }
        public string CityName { get; set; }
        public string WardName { get; set; }
        public string VillageName { get; set; }
        public string officerName { get; set; }
        public string DivisionName { get; set; }
        public string ExtendedLocationName { get; set; }
        public string ExtendedDistrictName { get; set; }
        public string ExtendedDivisionName { get; set; }
        public string ExtendedStateName { get; set; }
        public string SubjectName { get; set; }
    }
    public class DropdownsRegionalName
    {
        public string DepartmentNameRegional { get; set; }
        public string DepartmentTypeNameRegional { get; set; }
        public string DistrictNameRegional { get; set; }
        public string PanchayatNameRegional { get; set; }
        public string GramPanchayatNameRegional { get; set; }
        public string CityNameRegional { get; set; }
        public string WardNameRegional { get; set; }
        public string VillageNameRegional { get; set; }
        public string officerNameRegional { get; set; }
        public string DivisionNameRegional { get; set; }
        public string ExtendedLocationNameRegional { get; set; }
        public string ExtendedDistrictNameRegional { get; set; }
        public string ExtendedDivisionNameRegional { get; set; }
        public string ExtendedStateNameRegional { get; set; }
        public string SubjectNameRegional { get; set; }

    }
}
