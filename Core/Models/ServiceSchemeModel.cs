using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ServiceSchemeDetailsByCallcenter: SchemeAppModel
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
        //public Int64 UserId { get; set; }

        public Int64 SubjectId { get; set; }
        public Int64 DeptId { get; set; }
        //public Int64 callCenterAdmin { get; set; }
        //public Int64 DesgnId { get; set; }
        //public Int64 Slno { get; set; }
        //public Int64 DefaultSlno { get; set; }
        //public Int64 OrgAuth { get; set; }
        public string AgentMetaData { get; set; }
        //public int compstatusid { get; set; }
        //public string FromMetaData { get; set; }
        //public Int64 usermoderateId { get; set; }
        //public Int64 compSourceId { get; set; }
        public string CampaignType { get; set; }
        public Int64 TeleSvrIid { get; set; }
        public string TeleSvrSessId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectNameRegional { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameRegional { get; set; }
        
        
        public string LastOfficerRemark { get; set; }
        public int PullBackTime { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// /callcenter vise data
        /// </summary>
        public string COMPLAIN_COMPLAINT_NO { get; set; }
        //public int ZONE_ID { get; set; }
        //public string RURAL_URBAN_C { get; set; }
        //public int PANCHAYAT_ID_C { get; set; }
        //public int GRAM_PANCHAYAT_ID_C { get; set; }
        //public int VILLAGE_ID_C { get; set; }
        //public int CURRENT_LEVEL { get; set; }
        //public int EXTENDED_LOCATION_ID { get; set; }
        //public dynamic transferDetailMetaData { get; set; }
        public Int64 ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameRegional { get; set; }

    }

    public class SchemeAppModel : CommonEntityModel
    {
        public Int64 ApplicationId { get; set; }
        public string ApplicationDate { get; set; }
        public string ApplicationNo { get; set; }
        public ApplicationDataModel ApplicationData { get; set; }
        public CitizenProfileModel CitizenProfile { get; set; }
        public string ApplicationStatus { get; set; }
        public object EFormData { get; set; }
        public List<DocumentDataModel> DocumentData { get; set; }
        //public Int64 CreatedBy { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public Int64? ModifiedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        //public int? IsActive { get; set; }
        //public int? IsDeleted { get; set; }
        public Int32 SourceId { get; set; }
        public string SourceName { get; set; }
        public string SourceNameHindi { get; set; }

    }
    public class ApplicationDataModel
    {
        public Int64 CitizenId { get; set; }
        public Int64 DeptId { get; set; }
        public Int64 SchemeId { get; set; }
        public string DeptName { get; set; }
        public string DeptNameRegional { get; set; }
        public Int64? DestDeptId { get; set; }
        public Int64? DestSchemeId { get; set; }
        public Int64? DestDistrictId { get; set; }
        public Int64? DestTehsilId { get; set; }
        public Int64? DestOfficeId { get; set; }
        public Int64? MobileNo { get; set; }
        public Int32? EditModeId { get; set; }
        public string OfficeName { get; set; }
        public string OfficeNameHindi { get; set; }
        public string OfficeCode { get; set; }

    }
    public class CitizenProfileModel : CommonEntityModel
    {
        public JanaadhaarMappingDataModel janAadhaarMapValues { get; set; }
        public Int64 CitizenId { get; set; }
        public DropDownCodeListModel Title { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public string MobileNo { get; set; }
        public string JanAadhaarNo { get; set; }
        public string JanAadhaarMemberId { get; set; }
        public DropDownCodeListModel JanAadhaarMember { get; set; }
        public string AadhaarNo { get; set; }
        public string EMitraRegNo { get; set; }
        public string SsoId { get; set; }
        public string Dob { get; set; }
        public DropDownCodeListModel Gender { get; set; }
        public DropDownCodeListModel Category { get; set; }
        public DropDownCodeListModel MaritalStatus { get; set; }
        public string Email { get; set; }
        public DropDownCodeListModel RelationshipType { get; set; }
        public string FatherName { get; set; }
        public string FatherNameRegional { get; set; }
        public string HusbandName { get; set; }
        public string HusbandNameRegional { get; set; }
        public string MotherName { get; set; }
        public string MotherNameRegional { get; set; }
        public string FatherResident { get; set; }
        public string FatherOccupation { get; set; }
        public string FatherOccupationAddress { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string BankAcNo { get; set; }
        public string IfscCode { get; set; }
        public string Pan { get; set; }
        public string DlNumber { get; set; }
        public string PassportNumber { get; set; }
        public string VotterIdNumber { get; set; }
        public string ElectricityKNumber { get; set; }
        public string WaterBillNumber { get; set; }
        public string RationCardNumber { get; set; }
        public string BhamashaNumber { get; set; }
        public string CollegeName { get; set; }
        public string CRuralUrban { get; set; }
        public string CAddress { get; set; }
        public string CAddressRegional { get; set; }
        public DropDownCodeListModel CCountry { get; set; }
        public DropDownCodeListModel CState { get; set; }
        public DropDownCodeListModel CDivision { get; set; }
        public DropDownCodeListModel CDistrict { get; set; }
        public DropDownCodeListModel CTehsil { get; set; }
        public DropDownCodeListModel CMunicipality { get; set; }
        public DropDownCodeListModel CWard { get; set; }
        public DropDownCodeListModel CPanchayatSamiti { get; set; }
        public DropDownCodeListModel CGramPanchayat { get; set; }
        public DropDownCodeListModel CVillage { get; set; }
        public string CPincode { get; set; }
        public Int32? IsSameCurrentAddress { get; set; }
        public string PRuralUrban { get; set; }
        public string PAddress { get; set; }
        public string PAddressRegional { get; set; }
        public DropDownCodeListModel PCountry { get; set; }
        public DropDownCodeListModel PState { get; set; }
        public DropDownCodeListModel PDivision { get; set; }
        public DropDownCodeListModel PDistrict { get; set; }
        public DropDownCodeListModel PTehsil { get; set; }
        public DropDownCodeListModel PMunicipality { get; set; }
        public DropDownCodeListModel PWard { get; set; }
        public DropDownCodeListModel PPanchayatSamiti { get; set; }
        public DropDownCodeListModel PGramPanchayat { get; set; }
        public DropDownCodeListModel PVillage { get; set; }
        public string PPincode { get; set; }
        public Int64[] PhotoUploadId { get; set; }
        public string ProfilePhoto { get; set; }
        public string EFormHeaderId { get; set; }
        public CurrentAddressDetailDTO currentAddressDetailDTO { get; set; }
        public CurrentAddressDetailDTO permanentAddressDetailDTO { get; set; }
        public string Age { get; set; }
        public string OccupationName { get; set; }
        public string OccupationNameRegional { get; set; }

    }
    public class CurrentAddressDetailDTO
    {
        public Int64[] PhotoUploadId { get; set; }
        public string userImage { get; set; }
        public string janaadharId { get; set; }
        public string janaadharMemberId { get; set; }
        public string displayName { get; set; }
        public string displayNameinHindi { get; set; }
        public string dob { get; set; }
        public string age { get; set; }
        public string email { get; set; }
        public string fatherName { get; set; }
        public string fatherNameinHindi { get; set; }
        public string motherName { get; set; }
        public string motherNameinHindi { get; set; }
        public string mobile { get; set; }
        public string uidNo { get; set; }
        public string occupation { get; set; }  //Not Using any where
        public string occupationinHindi { get; set; }  //Not Using any where
        public string addrEng { get; set; }
        public string addrHin { get; set; }
        public string categoryMastrIdText { get; set; }
        public string categoryMastrIdTextEng { get; set; }
        public DropDownCodeListModel countryMastrIdText { get; set; }
        public DropDownCodeListModel stateMastrIdText { get; set; }
        public DropDownCodeListModel divisionMstrIdText { get; set; }
        public DropDownCodeListModel districtMastrIdText { get; set; }
        public DropDownCodeListModel tehsilMastrIdText { get; set; }
        public DropDownCodeListModel municipalityMastrIdText { get; set; }
        public DropDownCodeListModel wardMastrIdText { get; set; }
        public DropDownCodeListModel gramPanSamitiMastrIdText { get; set; }
        public DropDownCodeListModel gramPanchayatMastrIdText { get; set; }
        public DropDownCodeListModel villageMastrIdText { get; set; }
        public string pincode { get; set; }
    }
    public class DocumentDataModel
    {
        public Int64 AppDocId { get; set; }
        public Int64 DocumentGroupId { get; set; }
        public string DocumentGroupName { get; set; }
        public string DocumentGroupNameHindi { get; set; }
        public Int64 DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentTypeNameHindi { get; set; }
        public object ReqMetaData { get; set; }
        public string FileName { get; set; }
        public Int64[] UploadDocumentId { get; set; }
        public string UploadDocumentImage { get; set; }
        public Int32 IsDeleted { get; set; }
    }




}


