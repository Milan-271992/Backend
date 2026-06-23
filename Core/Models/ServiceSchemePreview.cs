using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ApplicationPreviewModel
    {
        public PreviewHdrData hdrData { get; set; }
        public string eformData { get; set; }
        public List<PreviewDocumentData> documentData { get; set; }
        public PreviewOfficeData officeData { get; set; }
    }
    public class PreviewHdrData
    {
        public Int64 ApplicationId { get; set; }
        public Int64 CitizenId { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicationDate { get; set; }
        public string TentativeDeliveryDate { get; set; }
        public string Status { get; set; }
        public String ApplicantName { get; set; }
        public String ApplicantNameRegional { get; set; }
        public String MobileNo { get; set; }
        public Int64 SchemeId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameRegional { get; set; }
        public Int64 DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameRegional { get; set; }
        public Int16 IsAllowDelete { get; set; }
        public Int16 IsAllowEdit { get; set; }
        public string ShortComingRemarks { get; set; }
        public String AppliedOn { get; set; }
        public Int64? GrievanceId { get; set; }
        public String GrievanceNo { get; set; }
        public string GrievanceMetaData { get; set; }
        public String DelayedStatus { get; set; }
        public string LanguageName { get; set; }
        public string LanguageNameRegional { get; set; }

        public string CurrentStatusRemarks { get; set; }
        public string CurrentStatusSubRemarks { get; set; }
        public string OfficerRemarks { get; set; }
        public string CurrentStatusActionDate { get; set; } // Since TO_CHAR is used in SQL, keeping it as string
        public string SourceId { get; set; }
        public string IsSamparkToken { get; set; }
        public string IsTransferToCallCenter { get; set; }
        public int IsPending { get; set; }
        public int IsShortcoming { get; set; }

    }
    public class PreviewHdrDataSp
    {
        public Int64 ApplicationId { get; set; }
        public Int64 CitizenId { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicationDate { get; set; }
        public string TentativeDeliveryDate { get; set; }
        public string Status { get; set; }
        public String ApplicantName { get; set; }
        public String ApplicantNameRegional { get; set; }
        public String MobileNo { get; set; }
        public Int64 SchemeId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameRegional { get; set; }
        public Int64 DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameRegional { get; set; }
        public Int16 IsAllowDelete { get; set; }
        public Int16 IsAllowEdit { get; set; }
        public string ShortComingRemarks { get; set; }
        public String AppliedOn { get; set; }
        public Int64? GrievanceId { get; set; }
        public String GrievanceNo { get; set; }
        public string GrievanceMetaData { get; set; }
        public String DelayedStatus { get; set; }
        public string LanguageName { get; set; }
        public string LanguageNameRegional { get; set; }
        public string CurrentStatusRemarks { get; set; }
        public string CurrentStatusSubRemarks { get; set; }
        public string OfficerRemarks { get; set; }
        public string CurrentStatusActionDate { get; set; } // Since TO_CHAR is used in SQL, keeping it as string
        public string SourceId { get; set; }
        public string IsSamparkToken { get; set; }
        public string IsTransferToCallCenter { get; set; }
        public int IsPending { get; set; }
        public int IsShortcoming { get; set; }

    }

    public class PreviewDocumentData
    {
        public string DocumentGroupName { get; set; }
        public string DocumentGroupNameHindi { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentTypeNameHindi { get; set; }
        public string FileName { get; set; }
        public Int64[] UploadDocumentId { get; set; }
        public string MetaData { get; set; }
    }
    public class PreviewOfficeData
    {
        public string DepartmentName { get; set; }
        public string DepartmentNameHindi { get; set; }
        public string SchemeName { get; set; }
        public string SchemeNameHindi { get; set; }
        public string DistrictName { get; set; }
        public string DistrictNameHindi { get; set; }
        public string TehsilName { get; set; }
        public string TehsilNameHindi { get; set; }
        public string OfficeName { get; set; }
        public string OfficeNameHindi { get; set; }
    }






}


