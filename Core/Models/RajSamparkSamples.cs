using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RajSamparkSamples
    {
        public int? DepartmentTypeId { get; set; }
        public int? DepartmenId { get; set; }
        public int? SchemeId { get; set; }
        public List<GeographicalModel> GeographicalModel { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int? GrievanceTypeId { get; set; }
        public string[] GrievanceIds { get; set; }
        public int? ApplicationId { get; set; }
    }

    public class ExistingSampleModel
    {
        public int TotalRecord { get; set; }
        public int SurveyId { get; set; }
        public int SampleSize { get; set; }
        public int RecordNo { get; set; }
        public int RecordPer { get; set; }
        public int RbNumber { get; set; }
        public int RbPercent { get; set; }
        public int DepartmentId { get; set; }
        public string Description { get; set; }
        public string GrievanceIds { get; set; }
        public Int64? RealityCheckForId { get; set; }
        public Int64 SampleLotId { get; set; }
        public Int64? CreatedBy { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string SampleLotName { get; set; }
        public Int64? DepartmentTypeId { get; set; }
        public Int64? RealityCheckTypeId { get; set; }
        public Int64? SchemeId { get; set; }
        public Int64? ApplicationId { get; set; }
        public int? GrievanceTypeId { get; set; }
        public string RuralUrban { get; set; }
        public string StrdivisionId { get; set; }
        public string StrdistrictId { get; set; }
        public string StrgrampanchayatId { get; set; }
        public string StrpanchayatSamitiId { get; set; }
        public string StrvillageId { get; set; }
        public string StrlocalityId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string UniqueId { get; set; }//User For Excel Sheet read all data
        public List<GeographicalModel> GeographicalModel { get; set; }
        public Int64? SearchedDeptID { get; set; }
        public string DepartmentTypeName { get; set; }
        public string DepartmentTypeNameRegional { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameRegional { get; set; }
        public dynamic UserDetails { get; set; }
        public string SubjectName { get; set; }
        public string SubjectRegional { get; set; }
        public string Language {  get; set; }
    }

    public class GeographicalModel
    {
        public int? SearchId { get; set; }
        public int? DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionNameHindi { get; set; }
        public int? DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameHindi { get; set; }
        public int? PanchayatSamitiId { get; set; }
        public string PanchayatSamitiName { get; set; }
        public string PanchayatSamitiNameHindi { get; set; }
        public int? GrampanchayatId { get; set; }
        public string GrampanchayatName { get; set; }
        public string GrampanchayatNameHindi { get; set; }
        public int? VillageId { get; set; }
        public string VillageName { get; set; }
        public string VillageNameHindi { get; set; }
    }

    public class GrievanceCountForSample
    {
        public Int32 SampleCount { get; set; }

    }
    public class GrvncModelForRcCount
    {
        public Int64 CitizenId { get; set; }
        public Int64? MobileNo { get; set; }
        public string ComplaintNo { get; set; }
        public Int64? DeptId { get; set; }
        public string CompSubjectId { get; set; }
        public Int64 ZoneId { get; set; }
        public Int64? PanchayatIdC { get; set; }
        public Int64? GramPanchayatIdC { get; set; }
        public Int64? VillageIdC { get; set; }
        public Nullable<DateTime> ComplainDate { get; set; }
        public Int64 CompStatusId { get; set; }
        public string RuralUrbanC { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EmailId { get; set; }
        public Int64? DeptTypeId { get; set; }
        public Int64? DivisionId { get; set; }
        public string CNameE { get; set; }
        public Int64? CreatedBy { get; set; }

    }

    public class SampleModelForRC
    {
        public int TotalRecord { get; set; }
        public int SurveyId { get; set; }
        public int SampleSize { get; set; }
        public int RecordNo { get; set; }
        public int RecordPer { get; set; }
        public int RbNumber { get; set; }
        public int RbPercent { get; set; }
        public int DepartmentId { get; set; }
        public string Description { get; set; }
        public string GrievanceIds { get; set; }
        public Int64? RealityCheckForId { get; set; }
        public Int64 SampleLotId { get; set; }
        public Int64? CreatedBy { get; set; }
        public Int64? UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string SampleLotName { get; set; }
        public Int64? DepartmentTypeId { get; set; }
        public Int64? RealityCheckTypeId { get; set; }
        public Int64? SchemeId { get; set; }
        public Int64? ApplicationId { get; set; }
        public int? GrievanceTypeId { get; set; }
        public string RuralUrban { get; set; }
        public string StrdivisionId { get; set; }
        public string StrdistrictId { get; set; }
        public string StrgrampanchayatId { get; set; }
        public string StrpanchayatSamitiId { get; set; }
        public string StrvillageId { get; set; }
        public string StrlocalityId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string UniqueId { get; set; }//User For Excel Sheet read all data
        public List<GeographicalModel> GeographicalModel { get; set; }
        public string Language { get; set; }
        public string DepartmentTypeName { get; set; }
        public string DepartmentTypeNameRegional { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameRegional { get; set; }
        public dynamic UserDetails { get; set; }
    }
}
