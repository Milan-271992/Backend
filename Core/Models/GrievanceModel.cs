using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{

    #region Grievance Model for save Grievance

    public class GrievanceModel
    {
        public class GrievanceApiParentListModel
        {
            public CitizenInformationModel CitizenInformationModel { get; set; }
            public GrievanceDetailModel GrievanceDetailModel { get; set; }
            public GrievanceAreaModel GrievanceAreaModel { get; set; }
            public GrievanceEventModel GrievanceEventModel { get; set; }
            public GrievanceSubmitFormModel GrievanceSubmitFormModel { get; set; }
            public PreviewComplainantSessionModel PreviewComplainantSessionModel { get; set; }
            public PreviewDropDownMasterMetaData PreviewDropDownMasterMetaData { get; set; }
            public PreviewDataListNameModel PreviewDataListNameModel { get; set; }
            public GrievanceIdInformation GrievanceIdInformation { get; set; }
            public string GrievanceIds { get; set; }


        }

        public class CitizenInformationModel
        {
            public Int64? PgRegId { get; set; }
            public Int64 RefNumber { get; set; }
            public Int64? IdType { get; set; }
            public string IdNo { get; set; }
            public string CNameE { get; set; }
            public Int64? Gender { get; set; }
            public string FatherNameE { get; set; }
            public string EmailId { get; set; }
            public string RuralUrban { get; set; }
            public Int64? CountryId { get; set; }
            public Int64? StateId { get; set; }
            public Int64? DistrictId { get; set; }
            public Int64? PanchayatId { get; set; }
            public Int64? GramPanchayatId { get; set; }
            public Int64? WardId { get; set; }
            public Int64? VillageId { get; set; }
            public string VillageName { get; set; }
            public string ComplaintArea { get; set; }
            public string IsPubGrev { get; set; }
            public Int64? PincodeNo { get; set; }
            public string AddressE { get; set; }
            public Int64? CitizenNo { get; set; }
            public Int64? CreatedBy { get; set; }
            public Int64 ComplainantId { get; set; }
            public DateTime CreatedOn { get; set; }
            public Int64? MobileNo { get; set; }
            public Int64? PhoneNo { get; set; }
            public string Landmark { get; set; }
            public string Landmark1 { get; set; }
            public string Landmark2 { get; set; }
            public string PhCtCode { get; set; }
            public string PhStCode { get; set; }
            public Int64 CompSourceId { get; set; }
            public string Freeze { get; set; }
            public string TokenNo { get; set; }
            public string Usercode { get; set; }
            public string IsMobileVerified { get; set; }
            public Int64? ExtLocId { get; set; }
            public string TransactionId { get; set; }
            public Int64? DraftStatus { get; set; }
            public string WebSessionId { get; set; }
            public string CountryName { get; set; }
            public string StateName { get; set; }
            public string DistrictName { get; set; }
            public string PanchayatName { get; set; }
            public string GramPanchayatName { get; set; }
            public string CountryNameRegional { get; set; }
            public string StateNameRegional { get; set; }
            public string DistrictNameRegional { get; set; }
            public string PanchayatNameRegional { get; set; }
            public string GramPanchayatNameRegional { get; set; }
            public string IdProof { get; set; }
            public string IdProofRegional { get; set; }
            public string GenderName { get; set; }
            public string GenderNameRegional { get; set; }
            public Int64? ComplainRequestId { get; set; }
            public Int64? OrgAuthId { get; set; }
            public string WardName { get; set; }
            public string WardNameRegional { get; set; }
            public Int64? CityId { get; set; }
            public string CityName { get; set; }
            public string CityNameRegional { get; set; }
            public string VillageNameRegional { get; set; }
            public string EmailTransactionId { get; set; }
            public Int64 Event { get; set; }

        }
        public class GrievanceDetailModel
        {
            public Int64? DeptTypeId { get; set; }
            public Int64? GrvType { get; set; }
            public Int64? DeptId { get; set; }
            public Int64 ZoneId { get; set; }
            public Int64? ComplaintType { get; set; }
            public Int64? ProjectId { get; set; }
            public string CompSubjectId { get; set; }
            public Int64? CompCat { get; set; }
            public Int64? CompSubCat { get; set; }
            public string ComplainDesc { get; set; }
            public string ReliefReq { get; set; }
            public Int64? GrievanceAge { get; set; }
            public string GrievanceAgeText { get; set; }
            public Int64 ComplainId { get; set; }
            public Int64?[] UploadDocumentId { get; set; }
            public Int64? ModifiedBy { get; set; }
            public DateTime ModifiedOn { get; set; }
            public Int64? DraftStatus { get; set; }
            public Int64 RefNumber { get; set; }
            public string PrevGrevId { get; set; }
            public Int32? IsGrievanceEarlier { get; set; }
            public string PanchayatName { get; set; }
            public string GramPanchayatName { get; set; }
            public string DepartmentTypeName { get; set; }
            public string DepartmentName { get; set; }
            public string ZoneName { get; set; }
            public string PanchayatNameRegional { get; set; }
            public string GramPanchayatNameRegional { get; set; }
            public string DepartmentTypeNameRegional { get; set; }
            public string DepartmentNameRegional { get; set; }
            public string ZoneNameRegional { get; set; }
            public Int64? OrgAuthId { get; set; }
            public Int64? GroupId { get; set; }
            public string SendOnType { get; set; }
            public dynamic ExtendedInfoMetaData { get; set; }
            public List<GrievanceDynamicAddModel> GrievanceDynamicAddModel { get; set; }
            public List<ComplainMasterSubExInfoModel> ComplainMasterSubExInfoModel { get; set; }
            public string GrvAgstType { get; set; }
            public Int64? GrvAgstId { get; set; }
            public string GrvAgstMetaData { get; set; }

        }
        public class GrievanceAreaModel
        {
            public string RuralUrbanC { get; set; }
            public Int64 ZoneId { get; set; }
            public Int64? PanchayatIdC { get; set; }
            public Int64? GramPanchayatIdC { get; set; }
            public Int64? VillageIdC { get; set; }
            public string VillageNameC { get; set; }
            public Int64? PrevGrevId { get; set; }
            public string CLandmark { get; set; }
            public string CLandmark1 { get; set; }
            public string CLandmark2 { get; set; }
            public Int64? PincodeNoC { get; set; }
            public string ComplaintArea { get; set; }
            public string VisRU { get; set; }
            public Int64? VisBlkPanctId { get; set; }
            public Int64? VisGramId { get; set; }
            public Int64? DisposalLevel { get; set; }
            public Int64? PoliceStationId { get; set; }
            public Int64? ConstAreaId { get; set; }
            public Int64 ComplainId { get; set; }
            public Int64? ModifiedBy { get; set; }
            public DateTime ModifiedOn { get; set; }
            public Int64? DraftStatus { get; set; }
            public Int64 RefNumber { get; set; }
            public string PanchayatName { get; set; }
            public string GramPanchayatName { get; set; }
            public string DistrictName { get; set; }
            public string PanchayatNameRegional { get; set; }
            public string GramPanchayatNameRegional { get; set; }
            public string ZoneNameRegional { get; set; }
            public Int64? DivisionId { get; set; }
            public Int64? DistrictId { get; set; }
            public Int64? WardIdC { get; set; }
            public Int64? CityIdC { get; set; }
            public string CityName { get; set; }
            public string WardName { get; set; }
            public string VillageName { get; set; }
            public string CityNameRegional { get; set; }
            public string WardNameRegional { get; set; }
            public string VillageNameRegional { get; set; }
            public string DistrictNameRegional { get; set; }
            public string DivisionName { get; set; }
            public string DivisionNameRegional { get; set; }
            public Int64? ExtLocId { get; set; }
            public Int64? ExtDistrictId { get; set; }
            public Int64? ExtDivisionId { get; set; }
            public Int64? ExtStateId { get; set; }
            public string ExtendedLocationName { get; set; }
            public string ExtendedDistrictName { get; set; }
            public string ExtendedDivisionName { get; set; }
            public string ExtendedStateName { get; set; }
            public string ExtendedLocationNameRegional { get; set; }
            public string ExtendedDistrictNameRegional { get; set; }
            public string ExtendedDivisionNameRegional { get; set; }
            public string ExtendedStateNameRegional { get; set; }
            public string IsApplyExtendedLoc { get; set; }
        }
        public class GrievanceEventModel
        {
            public Int64? EventId { get; set; }
            public Int64? EventSubId { get; set; }
            public Int64? EventTeamId { get; set; }
            public Int64 ComplainId { get; set; }
            public Int64? GrvRecId { get; set; }
            public DateTime LetterDate { get; set; }
            public Int64? OrgAuthId { get; set; }
            public Int64? OrgAuthSubId { get; set; }
            public Int64? RecUnderId { get; set; }
            public Int64? ModifiedBy { get; set; }
            public DateTime ModifiedOn { get; set; }
            public Int64? DraftStatus { get; set; }
            public Int64 RefNumber { get; set; }
            public Int64? MobileNo { get; set; }
            public string IsCmo { get; set; }
            public Int64? OfficerId { get; set; }
            public string officerName { get; set; }
            public string officerNameRegional { get; set; }
            public string VisEvtTodate { get; set; }
            public string VisEvtDate { get; set; }

        }
        public class GrievanceSubmitFormModel
        {
            public Int64 RefNumber { get; set; }
            public Int64 DistrictId { get; set; }
            public Int64? DeptId { get; set; }
            public Int64? DraftStatus { get; set; }
            public Int64? OrgAuthId { get; set; }
            public Int64? ModifiedBy { get; set; }
            public DateTime ModifiedOn { get; set; }
            public string SendOnType { get; set; }
            public string TransactionId { get; set; }

        }
        public class PreviewComplainantSessionModel
        {
            public string FatherNameE { get; set; }
            public string AddressE { get; set; }
            public string ComplaintArea { get; set; }
            public string IdNo { get; set; }
            public string VillageName { get; set; }
            public string IsPubGrev { get; set; }
            public string Landmark { get; set; }
            public string Landmark2 { get; set; }
            public string Landmark1 { get; set; }
            public string CName { get; set; }
            public string MobileNo { get; set; }
            public string EmailId { get; set; }
            public string RuralUrban { get; set; }
            public string CountryName { get; set; }
            public string StateName { get; set; }
            public string DistrictName { get; set; }
            public string CountryNameRegional { get; set; }
            public string StateNameRegional { get; set; }
            public string DistrictNameRegional { get; set; }
            public string IdProof { get; set; }
            public string IdProofRegional { get; set; }
            public string GenderName { get; set; }
            public string GenderNameRegional { get; set; }
            public string CityName { get; set; }
            public string CityNameRegional { get; set; }
            public string WardName { get; set; }
            public string WardNameRegional { get; set; }

        }
        public class PreviewDropDownMasterMetaData
        {
            public string DistrictName { get; set; }
            public string PanchayatName { get; set; }
            public string GramPanchayatName { get; set; }
            public string CityName { get; set; }
            public string WardName { get; set; }
            public string VillageName { get; set; }
            public string DepartmentName { get; set; }
            public string DepartmentTypeName { get; set; }
            public string officerName { get; set; }
            public string DivisionName { get; set; }
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
            public string ExtendedLocationName { get; set; }
            public string ExtendedLocationNameRegional { get; set; }

        }
        public class PreviewDataListNameModel
        {
            public string GrievanceName { get; set; }
            public string GrievanceNameRegional { get; set; }
            public string ProjectName { get; set; }
            public string ProjectNameRegional { get; set; }
            public string SubjectName { get; set; }
            public string SubjectNameRegional { get; set; }
            public string CategoryName { get; set; }
            public string CategoryNameRegional { get; set; }
            public string SubCategoryName { get; set; }
            public string SubCategoryNameRegional { get; set; }
            public string DisposalLevelName { get; set; }
            public string DisposalLevelRegional { get; set; }
            public string StationName { get; set; }
            public string StationNameRegional { get; set; }
            public string ConstituencyName { get; set; }
            public string ConstituencyNameRegional { get; set; }
            public string EventTypeName { get; set; }
            public string EventTypeNameRegional { get; set; }
            public string SourceName { get; set; }
            public string SourceNameRegional { get; set; }
            public string OriginatingOfficeName { get; set; }
            public string OriginatingOfficeNameRegional { get; set; }
            public string AuthorityName { get; set; }
            public string AuthorityNameRegional { get; set; }
            public string RecieveUnderName { get; set; }
            public string RecieveUnderNameRegional { get; set; }
        }
        public class GrievanceIdInformation
        {
            public Int64 MaplvlId { get; set; }
            public string GrvId { get; set; }
        }
        public class GrievanceDynamicAddModel
        {
            public Int64 RefNumber { get; set; }
            public Int64 DepartmentTypeId { get; set; }
            public Int64 DepartmentId { get; set; }
            public Int64? ProjectId { get; set; }
            public Int64? SubjectId { get; set; }
            public string DepartmentName { get; set; }
            public string DepartmentTypeName { get; set; }
            public string DepartmentNameRegional { get; set; }
            public string DepartmentTypeNameRegional { get; set; }
            public List<ComplainMasterSubExInfoForDynamicSubjectModel> ComplainMasterSubExInfoForDynamicSubjectModel { get; set; }
        }
        public class ComplainMasterSubExInfoForDynamicSubjectModel
        {
            public Int64 ComplainSubExId { get; set; }
            public Int64 RefNumber { get; set; }
            public Int64 ExtendedInfoId { get; set; }
            public string InformationValue { get; set; }
            public string InformationNameRegional { get; set; }
            public string InformationName { get; set; }
        }
        public class ComplainMasterSubExInfoModel
        {
            public Int64 ComplainSubExId { get; set; }
            public Int64 RefNumber { get; set; }
            public Int64 ExtendedInfoId { get; set; }
            public string InformationValue { get; set; }
            public string InformationNameRegional { get; set; }
            public string InformationName { get; set; }
        }
    }
    #endregion  

    public class SchemeApplicationTatPassedSpListModel
    {
        public Int32 TotalRecordCount { get; set; }
        public Int32 FilteredRecordCount { get; set; }
        public Int64 ApplicationId { get; set; }
        public Int64 CitizenId { get; set; }
        public String ApplicationNo { get; set; }
        public String ApplicantName { get; set; }
        public String ApplicantNameRegional { get; set; }
        public String ApplicantMobileNo { get; set; }
        public String ApplicantEmail { get; set; }
        public String ApplicantSSOID { get; set; }
        public Int64 SchemeId { get; set; }
        public String SchemeName { get; set; }
        public String SchemeNameRegional { get; set; }

        public Int32 DepartmentId { get; set; }
        public String DepartmentName { get; set; }
        public String DepartmentNameRegional { get; set; }

        public Int64 SubjectId { get; set; }
        public String SubjectName { get; set; }
        public String SubjectNameRegional { get; set; }

        public String ApplicationStatus { get; set; }
        public Int64? TokenNo { get; set; }
        public Int32? Tat { get; set; }
        public String TentativeDelivery { get; set; }
        public String AppliedOn { get; set; }
        public String TentativeDeliveryDate { get; set; }


        public string PRuralUrbanType { get; set; }
        public String PAddress { get; set; }
        public String PAddressRegional { get; set; }

        public Int64 PCountryId { get; set; }
        public String PCountryCode { get; set; }
        public String PCountryName { get; set; }

        public Int64 PStateId { get; set; }
        public String PStateCode { get; set; }
        public String PStateName { get; set; }

        public Int64 PDivisionId { get; set; }
        public String PDivisionCode { get; set; }
        public String PDivisionName { get; set; }

        public Int64 PDistrictId { get; set; }
        public String PDistrictCode { get; set; }
        public String PDistrictName { get; set; }

        public Int64 PTehsilId { get; set; }
        public String PTehsilCode { get; set; }
        public String PTehsilName { get; set; }

        public Int64? PMunicipalityId { get; set; }
        public String PMunicipalityCode { get; set; }
        public String PMunicipalityName { get; set; }

        public Int64? PWardId { get; set; }
        public String PWardCode { get; set; }
        public String PWardName { get; set; }

        public Int64? PPanchayatSamitiId { get; set; }
        public String PPanchayatSamitiCode { get; set; }
        public String PPanchayatSamitiName { get; set; }

        public Int64? PGramPanchayatId { get; set; }
        public String PGramPanchayatCode { get; set; }
        public String PGramPanchayatName { get; set; }

        public Int64? PVillageId { get; set; }
        public String PVillageCode { get; set; }
        public String PVillageName { get; set; }

        public String PPinCode { get; set; }
        public String MetaData { get; set; }
    }
    public class SchemeApplicationTatListModel
    {
        public Int32 TotalRecordCount { get; set; }
        public Int32 FilteredRecordCount { get; set; }
        public Int64 ApplicationId { get; set; }
        public Int64 CitizenId { get; set; }
        public String ApplicationNo { get; set; }
        public String ApplicantName { get; set; }
        public String ApplicantNameRegional { get; set; }
        public String ApplicantMobileNo { get; set; }
        public String ApplicantEmail { get; set; }
        public String ApplicantSSOID { get; set; }
        public Int64 SchemeId { get; set; }
        public String SchemeName { get; set; }
        public String SchemeNameRegional { get; set; }
       
        public Int32 DepartmentId { get; set; }
        public String DepartmentName { get; set; }
        public String DepartmentNameRegional { get; set; }

        public Int32 DepartmentTypeId { get; set; }
        public String DepartmentTypeName { get; set; }
        public String DepartmentTypeNameRegional { get; set; }
        public Int64 SubjectId { get; set; }
        public String SubjectName { get; set; }
        public String SubjectNameRegional { get; set; }

        public Int64 ProjectId { get; set; }
        public String ProjectName { get; set; }
        public String ProjectNameRegional { get; set; }

        public Int64 GrievanceTypeId { get; set; }
        public String GrievanceTypeName { get; set; }
        public String GrievanceTypeNameRegional { get; set; }


        public String ApplicationStatus { get; set; }
        public Int64? TokenNo { get; set; }
        public Int32? Tat { get; set; }
        public String TentativeDelivery { get; set; }
        public String AppliedOn { get; set; }
        public String TentativeDeliveryDate { get; set; }

        public string PRuralUrbanType { get; set; }
        public String PAddress { get; set; }
        public String PAddressRegional { get; set; }

        public Int64 PCountryId { get; set; }
        public String PCountryCode { get; set; }
        public String PCountryName { get; set; }

        public Int64 PStateId { get; set; }
        public String PStateCode { get; set; }
        public String PStateName { get; set; }

        public Int64 PDivisionId { get; set; }
        public String PDivisionCode { get; set; }
        public String PDivisionName { get; set; }

        public Int64 PDistrictId { get; set; }
        public String PDistrictCode { get; set; }
        public String PDistrictName { get; set; }

        public Int64 PTehsilId { get; set; }
        public String PTehsilCode { get; set; }
        public String PTehsilName { get; set; }

        public Int64? PMunicipalityId { get; set; }
        public String PMunicipalityCode { get; set; }
        public String PMunicipalityName { get; set; }

        public Int64? PWardId { get; set; }
        public String PWardCode { get; set; }
        public String PWardName { get; set; }

        public Int64? PPanchayatSamitiId { get; set; }
        public String PPanchayatSamitiCode { get; set; }
        public String PPanchayatSamitiName { get; set; }

        public Int64? PGramPanchayatId { get; set; }
        public String PGramPanchayatCode { get; set; }
        public String PGramPanchayatName { get; set; }

        public Int64? PVillageId { get; set; }
        public String PVillageCode { get; set; }
        public String PVillageName { get; set; }

        public String PPinCode { get; set; }
        public String MetaData { get; set; }

        public Int64 CountryId { get; set; }
        public String CountryCode { get; set; }
        public String CountryName { get; set; }
        public String CountryNameRegional { get; set; }

        public Int64 StateId { get; set; }
        public String StateCode { get; set; }
        public String StateName { get; set; }
        public String StateNameRegional { get; set; }

        public Int64 DivisionId { get; set; }
        public String DivisionCode { get; set; }
        public String DivisionName { get; set; }
        public String DivisionNameRegional { get; set; }

        public Int64 DistrictId { get; set; }
        public String DistrictCode { get; set; }
        public String DistrictName { get; set; }
        public String DistrictNameRegional { get; set; }

        public Int64 TehsilId { get; set; }
        public String TehsilCode { get; set; }
        public String TehsilName { get; set; }
        public String TehsilNameRegional { get; set; }

        public Int64? CityId { get; set; }
        public String CityCode { get; set; }
        public String CityName { get; set; }
        public String CityNameRegional { get; set; }

        public Int64? WardId { get; set; }
        public String WardCode { get; set; }
        public String WardName { get; set; }
        public String WardNameRegional { get; set; }

        public Int64? PanchayatSamitiId { get; set; }
        public String PanchayatSamitiCode { get; set; }
        public String PanchayatSamitiName { get; set; }
        public String PanchayatSamitiNameRegional { get; set; }

        public Int64? GramPanchayatId { get; set; }
        public String GramPanchayatCode { get; set; }
        public String GramPanchayatName { get; set; }
        public String GramPanchayatNameRegional { get; set; }

        public Int64? VillageId { get; set; }
        public String VillageCode { get; set; }
        public String VillageName { get; set; }
        public String VillageNameRegional { get; set; }

    }
    public class DemoGraphicSpModel
    {
        public Int64 CountryId { get; set; }
        public String CountryCode { get; set; }
        public String CountryName { get; set; }

        public Int64 StateId { get; set; }
        public String StateCode { get; set; }
        public String StateName { get; set; }

        public Int64 DivisionId { get; set; }
        public String DivisionCode { get; set; }
        public String DivisionName { get; set; }

        public Int64 DistrictId { get; set; }
        public String DistrictCode { get; set; }
        public String DistrictName { get; set; }

        public Int64 TehsilId { get; set; }
        public String TehsilCode { get; set; }
        public String TehsilName { get; set; }

        public Int64? CityId { get; set; }
        public String CityCode { get; set; }
        public String CityName { get; set; }

        public Int64? WardId { get; set; }
        public String WardCode { get; set; }
        public String WardName { get; set; }

        public Int64? PanchayatSamitiId { get; set; }
        public String PanchayatSamitiCode { get; set; }
        public String PanchayatSamitiName { get; set; }

        public Int64? GramPanchayatId { get; set; }
        public String GramPanchayatCode { get; set; }
        public String GramPanchayatName { get; set; }

        public Int64? VillageId { get; set; }
        public String VillageCode { get; set; }
        public String VillageName { get; set; }

    }

    public class SubmitGrievanceDataModel
    {
        public long ApplicationId { get; set; }
        public string ApplicationNo { get; set; }
        public GrievanceModel.GrievanceApiParentListModel GrvModel { get; set; }

    }

    public class GrievanceAreaForCheckModel
    {
        public string RuralUrbanC { get; set; }
        public Int64? PanchayatIdC { get; set; }
        public Int64? GramPanchayatIdC { get; set; }
        public Int64? VillageIdC { get; set; }
        public Int64? DivisionId { get; set; }
        public Int64? DistrictId { get; set; }
        public Int64? WardIdC { get; set; }
        public Int64? CityIdC { get; set; }
        public Int64? ExtLocId { get; set; }
        public Int64? CompSubjectId { get; set; }
        
    }

    public class GrvAgstMetaDataModel
    {
        public string ApplicationNo { get; set; }
        public GrvAgstMetaDataEng Eng { get; set; }
        public GrvAgstMetaDataHin Hin { get; set; }
    }
    public class GrvAgstMetaDataEng
    {
        public string ApplicationName { get; set; }
        public string District { get; set; }
    }
    public class GrvAgstMetaDataHin
    {
        public string ApplicationNameRegional { get; set; }
        public string DistrictRegional { get; set; }
    }
    public class DounloadMedia
    {
      
       public string docByte { get; set; }
        public string docName { get; set; }
        public Int64 ModuleId { get; set; }
        public Int64 EntityTypeId { get; set; }
        public Int64 EntityId { get; set; }
        public Int64 UserId { get; set; }
 
	}
	public class SubjectTempModel
	{
		public Int64 SubjectId { get; set; }
		public Int64 GrievanceTypeId { get; set; }
	}

    public class CompaignRequestsStatusUpdateModel
    {
        public string MobileNo { get; set; }
        public string Remark { get; set; }
        public Int64 CampaignId { get; set; }
        public Int64 RequestId { get; set; }
        public Int64 CampaignAllotmentId { get; set; }
        public Int64 AgentId { get; set; }
        public string CallType { get; set; }
        public int ModuleId { get; set; }
        public Int64 ComplainId { get; set; }
        public Int64 UserId { get; set; }

    }

    //@Note:-Using this model call center and Disposal grivance
    public class GrievanceDisopsalDetailsByCallcenter
	{
        public int IsGrievancePullBack { get; set; }
        public int StatusId { get; set; }
        public int CallBackTime { get; set; }
        public string MobileNo { get; set; }
		public string Remark { get; set; }
        public Int64 CampaignId { get; set; }
        public Int64 RequestId { get; set; }
        public Int64 CampaignAllotmentId { get; set; }
        public Int64 AgentId { get; set; }
        public string CallType { get; set; }
        public int ModuleId { get; set; }
		public Int64 ComplainId { get; set; }
		public Int64 UserId { get; set; }
		
		public Int64 Subject { get; set; }
		public Int64 DeptId { get; set; }
		public Int64 callCenterAdmin { get; set; }
		public Int64 DesgnId { get; set; }
		public Int64 Slno { get; set; }
		public Int64 DefaultSlno { get; set; }
		public Int64 OrgAuth { get; set; }
		public string AgentMetaData { get; set; }
		public DateTime ExpiryDate { get; set; }
		public int compstatusid { get; set; }
		public string FromMetaData { get; set; }
		public string ToMetaData { get; set; }
		public Int64 usermoderateId { get; set; }
		public Int64 compSourceId { get; set; }
        public string CampaignType { get; set; }
        public Int64 TeleSvrIid { get; set; }
        public string TeleSvrSessId { get; set; }
        public string SubjectNameRegional { get; set; }
        public string DepartmentNameRegional { get; set; }
        public string DepartmentName { get; set; }
        public string SubjectName { get; set; }
        public string LastOfficerRemark  { get; set; }
        public Int64 PullBackTime { get; set; }
        public int AjentCode { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// /callcenter vise data
        /// </summary>
        public string COMPLAIN_COMPLAINT_NO { get; set; }
		public int ZONE_ID { get; set; }
		public string RURAL_URBAN_C { get; set; }
		public int PANCHAYAT_ID_C { get; set; }
		public int GRAM_PANCHAYAT_ID_C { get; set; }
		public int VILLAGE_ID_C { get; set; }
		public int CURRENT_LEVEL { get; set; }
		public int EXTENDED_LOCATION_ID { get; set; }//
		public dynamic transferDetailMetaData { get; set; }

		public dynamic EXPTENDEDMetaData { get; set; }

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
        public string DepartmentTypeID { get; set; }
        public string CityID { get; set; }
        public string WardID { get; set; }
        public string officerID { get; set; }
        public string DivisionID { get; set; }
        public string ExtendedDistrictID { get; set; }
        public string ExtendedDivisionID { get; set; }
        public string ExtendedStateID { get; set; }
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

        public int GrvpType { get;set; }
        public string CLandmark { get; set; }
        public string CLandmark1 { get; set; }
        public string CLandmark2 { get; set; }
        public string PincodeNoC { get; set; }
        public string ComplaintArea { get; set; }
        public string ComplainName { get; set; }

        public DateTime PullBackTimeUseForExpiryDate { get; set; }
        public Int64 AgentConfigId { get; set; }
        public Int64[] DocId { get; set; } 
        public string GrievanceNo { get; set; }
        public string LastActionStatusMetaData { get; set; }

		public Int64 OfficerUserNo { get; set; }
		public Int32 NewCPID { get; set; }
		public Int32 NewWGPID { get; set; }
		public Int32 NewDeptTypeId { get; set; }
		public Int32 NewDivisionID { get; set; }
		public Int64 User_no { get; set; }
		public string lang { get; set; }
        public string IsExtendedInformation { get; set; }
    }
	public class ReturnFile
	{		
	
		public string DocumentDetailId { get; set; }
		public string FileName { get; set; }
		public Int64? Size { get; set; }
	}

    //@Note:-Using this model call center 
    public class ApplicationDetailsByCallcenter
    {
        public int StatusId { get; set; }
        public int CallBackTime { get; set; }
        public string MobileNo { get; set; }
        public string Remark { get; set; }
        public Int64 CampaignId { get; set; }
        public Int64 RequestId { get; set; }
        public Int64 CampaignAllotmentId { get; set; }
        public Int64 AgentId { get; set; }
        public string CallType { get; set; }
        public int ModuleId { get; set; }
        //public Int64 ComplainId { get; set; }
        public string ApplicationNo { get; set; }
        public Int64 UserId { get; set; }

        public Int64 callCenterAdmin { get; set; }
        public Int64 Slno { get; set; }
        public Int64 DefaultSlno { get; set; }
        public Int64 OrgAuth { get; set; }
        public string AgentMetaData { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int compstatusid { get; set; }
        public string FromMetaData { get; set; }
        public string ToMetaData { get; set; }
        public Int64 usermoderateId { get; set; }
        public Int64 compSourceId { get; set; }
        public string CampaignType { get; set; }
        public Int64 TeleSvrIid { get; set; }
        public string TeleSvrSessId { get; set; }
        public string LastOfficerRemark { get; set; }
        public Int64 PullBackTime { get; set; }
        public int AjentCode { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// /callcenter vise data
        /// </summary>
        public string COMPLAIN_COMPLAINT_NO { get; set; }
        public DateTime PullBackTimeUseForExpiryDate { get; set; }
        public Int64 AgentConfigId { get; set; }
        public Int64[] DocId { get; set; }
        public string GrievanceNo { get; set; }
        public string LastActionStatusMetaData { get; set; }

        public Int64 OfficerUserNo { get; set; }
        public Int64 User_no { get; set; }
        public string lang { get; set; }
    }

    public class JanSunwaiActionPayloadModel
    {
        public List<Int32> ComplainIds { get; set; }
        public string Remarks { get; set; }
        public Int64? UserId { get; set; }
        public string ResponseEntryIds { get; set; }
        public string fromMetadata { get; set; }
        public Int32? DesgId { get; set; }
        public string SLNOID { get; set; }
        public Int32? ISDEFAULTSLNO { get; set; }
        public Int32? SourceId { get; set; }
        public Int64? ActionId { get; set; }

    }
    public class GrievanceForRSHAModel
    {
        public string GrievanceId { get; set; }
        public string District { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }
        public string Category { get; set; }
        public string HospitalCode { get; set; }
        public string RagistrationDate { get; set; }
        public string LastModifiactionDate { get; set; }
        public string CurrentStatus { get; set; }
        public string Description { get; set; }

        public string DESIGNATION { get; set; }

        public string OFFICERNAME { get; set; }

        public string NOOFDAYSPENDING { get; set; }

        public string LEVEL { get; set; }
    }
    public class JansoochnaServiceCompwithofficerModel
    {
        public string Name { get; set; }
        public string Designation { get; set; }
        public string TotalRegCase { get; set; }
        public string TotalSatisfiedCases { get; set; }
        public string TotalNotSatisfiedCases { get; set; }
        public string TotalNotContacted { get; set; }
        public string TotalMobileNotVerified { get; set; }
        public string TotalCasesPending { get; set; }
        public string Disposed { get; set; }
        public string CLevel { get; set; }
    }
    public class GrivbyGrievanceIdModel
    {
        public string GrievanceId { get; set; }
        public string GDate { get; set; }
        public string ComplainantName { get; set; }
        public string Subject { get; set; }
        public string ComplainStatus { get; set; }
        public string ComplainStatusHindi { get; set; }
        public string Description { get; set; }
        public string MobileNo { get; set; }
        public string OwnerDepartment { get; set; }
        public string GrievanceArea { get; set; }
    }

    public class ConersationsModel
    {
        public bool success { get; set; }
        public string message { get; set; }
        public List<ConersationsByMobileNoModel> conversations { get; set; }
    }

    public class ConersationsByMobileNoModel
    {
        public string call_time { get; set; }
        public string conversation { get; set; }
      
    }

    public class CampaignRejectModel
    {
        public string MobileNo { get; set; }
        public string Remark { get; set; }
        public Int64 CampaignId { get; set; }
        public Int64 RequestId { get; set; }
        public Int64 CampaignAllotmentId { get; set; }
        public Int64 AgentId { get; set; }
        public string CallType { get; set; }
        public int ModuleId { get; set; }
        public Int64 ComplainId { get; set; }
        public Int64 UserId { get; set; }

        public Int64 Subject { get; set; }
        public Int64 DeptId { get; set; }
        public Int64 callCenterAdmin { get; set; }
        public Int64 DesgnId { get; set; }
        public Int64 Slno { get; set; }
        public Int64 DefaultSlno { get; set; }
        public Int64 OrgAuth { get; set; }
        public string AgentMetaData { get; set; }
        public int compstatusid { get; set; }
        public string FromMetaData { get; set; }
        public Int64 usermoderateId { get; set; }
        public Int64 compSourceId { get; set; }
        public string CampaignType { get; set; }
        public Int64 TeleSvrIid { get; set; }
        public string TeleSvrSessId { get; set; }
        public string SubjectNameRegional { get; set; }
        public string DepartmentNameRegional { get; set; }
        public string DepartmentName { get; set; }
        public string SubjectName { get; set; }
        public string LastOfficerRemark { get; set; }
        public int PullBackTime { get; set; }
        public string Name { get; set; }

        
    }

    public class GrievanceApiParentModel
    {        
        public GrievanceDisopsalDetailsByCallcenter AgentActivity { get; set; }
    }

    public class GrievanceConversationHistoryModel
    {

        public string MobileNo { get; set; }
        public string Person { get; set; }
        public string AjentName { get; set; }
        public string DateOn { get; set; }
        public string Remark { get; set; }
        public string AudioLink { get; set; }
        public string AgentId { get; set; }
        public string TeleSvrSessId { get; set; }
        public string serverIp { get; set; }

    }

    public class LastActionStatusMetaData
    {

        public Int64 CompStatusId { get; set; }
        public string CompStatusName { get; set; }
        public string CompStatusNameRegional { get; set; }
    }

    public class AgentActivityModal
    {
		public string MobileNo { get; set; }
		public string Remark { get; set; }
		public Int64 CampaignId { get; set; }
		public Int64 RequestId { get; set; }
		public Int64 CampaignAllotmentId { get; set; }
		public Int64 AgentId { get; set; }
		public string CallType { get; set; }
		public int ModuleId { get; set; }
		public Int64 ComplainId { get; set; }

        public Int64 TeleSvrIid { get; set; }
        public string TeleSvrSessId { get; set; }
        public string CampaignType { get; set; }
	}


    public class GrievanceSubStatusModel
    {
        public Int64 RefNumber { get; set; }
        public string ComplaintNo { get; set; }
        public Int32 IsAvailableForVerification { get; set; }
        public Int32? CompStatusSubId { get; set; }
        public Int32? CompStatusId { get; set; }

    }


}


