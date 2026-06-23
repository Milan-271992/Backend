namespace Core.Models
{
    public class JanaadhaarDataModel
    {
        public string CAST { get; set; }
        public string MARITAL_STATUS { get; set; }
        public string AADHAR_ID { get; set; }
        public Int64[] PhotoUploadId { get; set; }
        public string PROFILE_IMAGE { get; set; }
        public string DOB { get; set; }
        public string VILLAGE_CODE { get; set; }
        public string GP_WARD_ID { get; set; }
        public string BLOCK_CITY_CODE { get; set; }
        public string NATIONALITY { get; set; }
        public string RELATIVE_NAME { get; set; }
        public string MARITAL_STATUS_CODE { get; set; }
        public string BLOCK_CITY_ID { get; set; }
        public string COLONY { get; set; }
        public string GP_WARD_CODE { get; set; }
        public string CATEGORY { get; set; }
        public string REALTION_TYPE { get; set; }
        public string LANDLINE_NO { get; set; }
        public string PIN_CODE { get; set; }
        public string GP_WARD { get; set; }
        public string village_name { get; set; }
        public string caste_code { get; set; }
        public string district_code { get; set; }
        public string email { get; set; }
        public string IS_RURAL { get; set; }
        public string CATEGORY_ID { get; set; }
        public string NATIONALITY_ID { get; set; }
        public string DISTRICT { get; set; }
        public string NAME { get; set; }
        public string MARITAL_STATUS_ID { get; set; }
        public string AGE { get; set; }
        public string OCCUPATION { get; set; }
        public string CASTE_ID { get; set; }
        public string ADDRESS { get; set; }
        public string ADDRESS_HINDI { get; set; }
        public string HNO { get; set; }
        public string CATEGORY_CODE { get; set; }
        public string DISTRICT_ID { get; set; }
        public string MOBILE_NO { get; set; }
        public string NATIONALITY_CODE { get; set; }
        public string GENDER { get; set; }
        public string AADHAR_REF_NO { get; set; }
        public string GENDER_CODE { get; set; }
        public string GENDER_ID { get; set; }
        public string NAME_HND { get; set; }
        public string VILLAGE_ID { get; set; }
        public string BLOCK_CITY { get; set; }
    }


    public class JanaadhaarMappingDataModel
    {

        public Int64[] PhotoUploadId { get; set; }
        public string ProfileImage { get; set; }
        public DropDownCodeListModel Gender { get; set; }
        public DropDownCodeListModel Category { get; set; }
        public DropDownCodeListModel MaritalStatus { get; set; }
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
        //public object Cdata { get; set; }
    }


    public class ChildLocationModel
    {
        public Int64 LocationTypeId { get; set; }
        public string LocationCode { get; set; }
    }

    public class ParentLocationModel
    {
        public Int64 PLocTypeId { get; set; }
        public Int64 PLocId { get; set; }
        public string PLocCode { get; set; }
        public string PLocName { get; set; }
        public string PLocNameHindi { get; set; }

    }

 
    public class SchemeApplicationMsg
    {
        public Int64 ApplicationId { get; set; }
        public string ApplicationDate { get; set; }
        public string ApplicationNo { get; set; }
        public string ApplicationStatus { get; set; }
        public Int64? GrievanceId { get; set; }
        public string GrievanceNo { get; set; }
        public string ApplicantName { get; set; }
        public string ApplicantNameRegional { get; set; }
        public string ServiceName { get; set; }
        public string ServiceNameRegional { get; set; }
        public string Link { get; set; }
        public string LinkStatus { get; set; }
        public string GRVLinkStatus { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
    }
    public class ReturnObjectFile_V1
    {
        //public string UserDocumentId { get; set; }
        public string DocumentDetailId { get; set; }

        public string FileName { get; set; }
        public Int64? Size { get; set; }
        // public string File { get; set; }
    }


}
