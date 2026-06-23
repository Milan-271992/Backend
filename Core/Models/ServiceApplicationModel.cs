using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{

    public class ServiceApplicationModel : CommonEntityModel
    {
        public Int64 ApplicationId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string ApplicationNo { get; set; }
        public Int64 DeptId { get; set; }
        public Int64 SchemeId { get; set; }
        public Int64? TitleId { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantNameRegional { get; set; }
        public Int64? MobileNo { get; set; }
        public Int64? JanAadhaarNo { get; set; }
        public Int64? JanAadhaarMemberId { get; set; }
        public Int64? AadhaarNo { get; set; }
        public string EMitraRegNo { get; set; }
        public string SsoId { get; set; }
        public string Email { get; set; }
        public Int64? RelationshipTypeId { get; set; }
        public string FatherName { get; set; }
        public string FatherNameRegional { get; set; }
        public string HusbandName { get; set; }
        public string HusbandNameRegional { get; set; }
        public string MotherName { get; set; }
        public string MotherNameRegional { get; set; }
        public string PRuralUrban { get; set; }
        public string PAddress { get; set; }
        public string PAddressRegional { get; set; }
        public Int64? PCountryId { get; set; }
        public Int64? PStateId { get; set; }
        public Int64? PDivisionId { get; set; }
        public Int64? PDistrictId { get; set; }
        public Int64? PTehsilId { get; set; }
        public Int64? PMunicipalityId { get; set; }
        public Int64? PWardId { get; set; }
        public Int64? PPsId { get; set; }
        public Int64? PGpId { get; set; }
        public Int64? PVillageId { get; set; }
        public string PPincode { get; set; }
        public Int64? IsSelfConfirm { get; set; }
        public string PhotoUploadId { get; set; }
        public string MetaData { get; set; }
        public string ApplicationStatus { get; set; }
        public Int64? StatusId { get; set; }
        public Int64? DestDeptId { get; set; }
        public Int64? DestSchemeId { get; set; }
        public Int64? DestDistrictId { get; set; }
        public Int64? DestTehsilId { get; set; }
        public Int64? DestOfficeId { get; set; }
        public Int64? GrievanceId { get; set; }
        public string GrievanceNo { get; set; }
        public string Remarks { get; set; }
        public Int64? UserId { get; set; }
        public string UserName { get; set; }
        public Int64 CitizenId { get; set; }
        public Int64? EformDataId { get; set; }
        public Int64? CompletedPhase { get; set; }
        public string EmOfficeCode { get; set; }
        public string EmMetaData { get; set; }
        public Int64? TokenNo { get; set; }
        public string RequestId { get; set; }
        public string EformHeaderId { get; set; }
        public Int64? IsResubmitted { get; set; }
        public DateTime? ResubmittedOn { get; set; }
        public Int64? ResubmittedBy { get; set; }
        public string ReceiptNo { get; set; }
        public string IsMigrated { get; set; }
        public string OfficeMetaData { get; set; }
        public string GrvMetaData { get; set; }
        public DateTime? GrvSrvCallDate { get; set; }
        public string GrvRemarks { get; set; }
        public Int64? RequestNo { get; set; }
        public string CurrentStatusRemarks { get; set; }
        public string CurrentStatusSubRemarks { get; set; }
        public string OfficerRemarks { get; set; }
        public DateTime? ResubmittedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public Int64? SourceId { get; set; }
        public string UserMetaData { get; set; }
        public Int16? IsSamparkToken { get; set; }
        public DateTime? CurrentStatusActionDate { get; set; }
        public Int32? IsTransferToCallcenter { get; set; }



    }



    public class ApplicationShortComingModel
    {
        public Int32 TotalRecordCount { get; set; }
        public Int32 FilteredRecordCount { get; set; }
        public String ApplicationNo { get; set; }
        public String ApplicantName { get; set; }
        public String ApplicantNameRegional { get; set; }

        public String MobileNo { get; set; }
        public Int64? EmServiceId { get; set; }
        public String EmServiceName { get; set; }
        public String EmServiceNameRegional { get; set; }
        public Int64? EmDeptId { get; set; }
        public String EmDeptName { get; set; }
        public String EmDeptNameRegional { get; set; }
        public String CurrentStatus { get; set; }
        public String CurrentStatusHindi { get; set; }
    }


    public class GetDocumentPdfModel
    {
        public Int64[] DocumentDetailId { get; set; }
        public string Base64 { get; set; }
        public string FileName { get; set; }
    }
}


