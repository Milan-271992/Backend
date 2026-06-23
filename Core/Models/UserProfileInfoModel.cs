using System.Runtime.Intrinsics.X86;

namespace Core.Models
{

    public class UserProfileInfoModel
    {
        public string Name { get; set; }
        public string InternalUserID { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Office { get; set; }
        public string OfficeNo { get; set; }
        public string Section { get; set; }
        public string Role { get; set; }
        public string Mobile { get; set; }
        public string SSOId { get; set; }
        //public string IsDefault { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string DesignationNameHindi { get; set; }
        public string SectionNameHindi { get; set; }
    }

    public class UserNameByFromToIDModel
    {
        public string UserName { get; set; }
    }


    public class TOURUPMUserDetailsModel
    {
        public string NAME_ENG { get; set; }

        public string NAME_REGIONAL { get; set; }


        public string FATHER_NAME_ENG { get; set; }


        public string FATHER_NAME_REGIONAL { get; set; }


        public string MOTHER_NAME_ENG { get; set; }

        public string MOTHER_NAME_REGIONAL { get; set; }


        public string MOBILE { get; set; }

        public string OFFICER_FULL_DETAILS { get; set; }

        public string OFFICER_FULL_DETAILS_CUSTOM { get; set; }

        public string OFFICER_FULL_DETAILS_TOUR { get; set; }

        public string EMAIL { get; set; }
        public Int32 IS_TOUR_ACCESS { get; set; }

        public Int64 USER_ID { get; set; }

        public string INTERNALUSERID { get; set; }

        public Int64 PROFILE_ID { get; set; }

        public string SSOID { get; set; }

        public Int64 ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string ROLE_NAME_HINDI { get; set; }

        public Int64 DEPT_ID { get; set; }
        public string DEPT_NAME { get; set; }
        public string DEPT_NAME_HINDI { get; set; }

        public Int64 DESG_ID { get; set; }
        public string DESG_NAME { get; set; }

        public string DESG_NAME_HINDI { get; set; }

        public Int64 SECTION_ID { get; set; }
        public string SECTION_NAME { get; set; }
        public string SECTION_NAME_HINDI { get; set; }
        public string OFFICETYPE { get; set; }
        public string OFFICENO { get; set; }
        public Int64 OFFICE_ID { get; set; }
        public string OFFICE { get; set; }

        public Int64 ZONE_ID { get; set; }

        public Int64 LOC_TYPE_ID { get; set; }

        public Int64 DIVISION_ID { get; set; }

        public string IS_COLLECTORATE_USER { get; set; }

        public string USER_DEPARTMENT_ABBRIVIATION { get; set; }

        public Int64 USER_DEPT_TYPE_ID { get; set; }

        public Int64 DEPARTMENT_DISTRICT_ID { get; set; }

        public string DEPARTMENT_DISTRICT_NAME { get; set; }

        public string IS_SPOFFICE_USER { get; set; }

        public Int64 SPOFFICE_ID { get; set; }

        public string DF_OFFICER_TYPE_NAME { get; set; }

        public Int64 DF_OFFICER_TYPE_ID { get; set; }

        public string TOUR_OFFICER_TYPE_NAME { get; set; }

        public Int64 TOUR_OFFICER_TYPE_ID { get; set; }


        public string OFFICERCOMPLETEDETAIL { get; set; }

        public string OFFICERCOMPLETEDETAILREGIONAL { get; set; }

        public string ISDEFAULT { get; set; }
        public string PROFILEPIC { get; set; }
    }


    public class JANSUNWAI_UPM_UserDetailsModel
    {
        public string NAME_ENG { get; set; }

        public string NAME_REGIONAL { get; set; }


        public string FATHER_NAME_ENG { get; set; }


        public string FATHER_NAME_REGIONAL { get; set; }


        public string MOTHER_NAME_ENG { get; set; }

        public string MOTHER_NAME_REGIONAL { get; set; }


        public string MOBILE { get; set; }

        public string OFFICER_FULL_DETAILS { get; set; }

        public string OFFICER_FULL_DETAILS_CUSTOM { get; set; }

        public string EMAIL { get; set; }
        public Int64 USER_ID { get; set; }

        public string INTERNALUSERID { get; set; }

        public Int64 PROFILE_ID { get; set; }

        public string SSOID { get; set; }

        public Int64 ROLE_ID { get; set; }
        public string ROLE_NAME { get; set; }
        public string ROLE_NAME_HINDI { get; set; }

        public Int64 DEPT_ID { get; set; }
        public string DEPT_NAME { get; set; }
        public string DEPT_NAME_HINDI { get; set; }

        public Int64 DESG_ID { get; set; }
        public string DESG_NAME { get; set; }

        public string DESG_NAME_HINDI { get; set; }

        public Int64 SECTION_ID { get; set; }
        public string SECTION_NAME { get; set; }
        public string SECTION_NAME_HINDI { get; set; }
        public string OFFICETYPE { get; set; }
        public string OFFICENO { get; set; }
        public Int64 OFFICE_ID { get; set; }
        public string OFFICE { get; set; }

        public Int64 ZONE_ID { get; set; }

        public Int64 LOC_TYPE_ID { get; set; }

        public Int64 DIVISION_ID { get; set; }

        public string USER_DEPARTMENT_ABBRIVIATION { get; set; }

        public Int64 USER_DEPT_TYPE_ID { get; set; }

        public Int64 DEPARTMENT_DISTRICT_ID { get; set; }

        public string DEPARTMENT_DISTRICT_NAME { get; set; }

        public string OFFICERCOMPLETEDETAIL { get; set; }

        public string OFFICERCOMPLETEDETAILREGIONAL { get; set; }

        public string ISDEFAULT { get; set; }
        public string PROFILEPIC { get; set; }
    }

    public class SSOUserList
    {
        public Int64 ProfileId { get; set; }
        public string MobileNo { get; set; }
        public string SsoId { get; set; }
        public string IsActive { get; set; }
        public string AccountType { get; set; }

    }
    public class ValidateSsoUser
    {
        public string AuthId { get; set; }
        public string AuthKey { get; set; }
        public string SsoToken { get; set; }
        public string ComeFrom { get; set; }
        public string UserType { get; set; }

    }

    public class UserDetailsByIdModel
    {
        public Int64 UserId { get; set; }
        public Int64 DistrictId { get; set; }
        public Int64 DeptId { get; set; }
        public Int64 DesignationId { get; set; }
        public Int64 RoleId { get; set; }
        public Int64 OfficerId { get; set; }
        public string OfficerName { get; set; }
    }

    public class DActiveSsoProfile
    {
        public Int64[] ProfileId { get; set; }
        public string SSoToken { get; set; }
        public string SSOID { get; set; }
        public int ProfileKeepOrDeActive { get; set; }
    }

    public class AddUpdateCitizenProfileModel
    {
        public Int64 ComplainantId { get; set; }
        public string ComplainantName { get; set; }
        public string ComplainantNameHindi { get; set; }
        public string FatherName { get; set; }
        public string AddressE { get; set; }
        public string Email { get; set; }
        public Int64? CountryId { get; set; }
        public Int64? StateId { get; set; }
        public string Gender { get; set; }
        public Int64? DistrictID { get; set; }
        public Int64? PanchayatId { get; set; }
        public Int64? GramPanchayatId { get; set; }
        public string RuralUrban { get; set; }
        public Int64? PincodeNo { get; set; }
        public Int64? VillageId { get; set; }
        public Int64? PhoneNo { get; set; }
        public string Landmark { get; set; }
        public string Landmark2 { get; set; }
        public string Landmark3 { get; set; }

    }
    public class UserCountModel
    {
        public Int32? TotalUser { get; set; }
        public Int32? DepartmentId { get; set; }
        public Int64? TotalMappedUser { get; set; }
    }
    public class TourDashBoardUserDetail
    {
        public Int32 UserId { get; set; }
        public Int32 DepartmentId { get; set; }
        public Int32 DistrictId { get; set; }
        public Int32 DesignationId { get; set; }
        public string OfficerName { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string OfficerNameRegional { get; set; }
        public string DepartmentRegional { get; set; }
        public string DesignationRegional { get; set; }
        public string DistrictName { get; set; }
        public string DistrictRegional { get; set; }
    }
    public class TourDashBoardFilter
    {
        public Int32 DepartmentId { get; set; }
        public Int32 DesignationId { get; set; }
    }
    public class TourDashBoardLevelSummaryDetail
    {
        public Int32 UserId { get; set; }
        public Int32 DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictRegional { get; set; }
        public Int32 DesignationId { get; set; }
        public string Designation { get; set; }
        public string DesignationRegional { get; set; }
        public string OfficerName { get; set; }
        public string OfficerNameRegional { get; set; }
        public Int32 DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionNameRegional { get; set; }


    }
    public class ValidateSsoLDAUser
    {
        public string AuthId { get; set; }
        public string AuthKey { get; set; }
        public string SsoToken { get; set; }
        public string ComeFrom { get; set; }
        public string UserType { get; set; }
        public int ClientId { get; set; }

    }
}
