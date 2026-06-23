using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class CallCenterDisposalDropDown
    {
        public string CompStatusId { get; set; }
        public string CompStatusName { get; set; }
        public string AvailableAtLevel { get; set; }
        public string CompDescription { get; set; }
        public string CompStatusNameRegional { get; set; }
        public string ForCC { get; set; }
    }
    public class PullbackRequest
    {
        public Int64 PullBackTime { get; set; }
        public Int64 Complainid { get; set; }
        public Int64 Departmentid { get; set; }
        public Int64 Zoneid { get; set; }
        public Int64 Compsubid { get; set; }
        public string Ruralurban { get; set; }
        public Int64 PanchayatId { get; set; }
        public Int64 Cityid { get; set; }
        public Int64 GpanchyatId { get; set; }
        public Int64 Wardid { get; set; }
        public Int64 Villageid { get; set; }
        public Int64 Extlocid { get; set; }
        public string Complaindesc { get; set; }
        public string Lmark { get; set; }
        public string Lmark1 { get; set; }
        public string Lmark2 { get; set; }
        public string Grvarea { get; set; }
        public string Grvpincode { get; set; }
        public Int64 GrvpType { get; set; }
        public string Actionremarks { get; set; }
        public Int64 FromuserId { get; set; }
        public Int64 Userdesignation { get; set; }
        public string UserMetaData { get; set; }
        public Int64 SourceId { get; set; }
        public string Calltype { get; set; }
        public string StepId { get; set; }
        public string LocationMetaData { get; set; }
        public string DocId { get; set; }
        public Int64 UserId { get; set; }
        public string GrievanceNo { get; set; }
        public Int64 DivisionID { get; set; }

	}
    public class LocationMetaDataMetaData
    {
        public EnglishNameLocationMetaData EnglishName { get; set; }
        public RegionalNameLocationMetaData RegionalName { get; set; }

    }

    public class EnglishNameLocationMetaData
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
        public string IsExtendLocType { get; set; }
        public string StartLocTypeId { get; set; }
        public string IsExtendedInformation { get; set; }
    }

    public class RegionalNameLocationMetaData
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
    }

}
