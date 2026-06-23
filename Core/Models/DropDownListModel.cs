using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DropDownListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }

    }

    public class TourUserTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public int DESIGNATION_ID { get; set; }
        public int ROLE_ID { get; set; }
        public Int32?[] ALLOWED_DESIGNATION_IDS { get; set; }
        public Int32?[] ALLOWED_ROLE_IDS { get; set; }

    }

    public class FinancialYearMonthDropDownListModel
    {
        public Int64 CurrentID { get; set; }
        public string CurrentName { get; set; }
        public List<DropDownListModel> List_DropDownListModel { get; set; }

    }

    public class DropDownListModelMainPurpose
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }

        public string From_Date { get; set; }

        public string To_Date { get; set; }
    }
    public class DropDownList2Model
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
    }
    public class DropDownList3Model
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
    }
    public class IdNameModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class DropDownCodeListModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public string Code { get; set; }
        public string DelFlag { get; set; }
    }

    public class CampaignDropDownListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public Int64 ModuleId { get; set; }
        public string CampaignType { get; set; }

    }

    public class AgentNameModel
    {
        public Int64 UserId { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public string SSOId { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
    public class AgentConfig
    {

        public Int64 ConfigId { get; set; }
        public Int64 AgentId { get; set; }
        public string AgentCode { get; set; }
        public Int32 CompaignId { get; set; }
        public string ActiveDate { get; set; }
        public Int32 Status { get; set; }
        public string AgentActType { get; set; }
        public Int32 EnableOnAll { get; set; }
        public string IpAddress { get; set; }

    }


    public class DistrictAndDisposalDropDown
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionNameRegional { get; set; }
        public Int64 EntityId { get; set; }
    }
    public class DistrictAndDisposalDropDown_V1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionNameRegional { get; set; }
        public Int64 EntityId { get; set; }
        public Int64 ChildCount { get; set; }
    }


    public class CountryCodeListModel
    {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
    }
    public class DistrictUserAndDisposalDropDown
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public int DivisionId { get; set; }
        public string DivisionName { get; set; }
        public string DivisionNameRegional { get; set; }
        public Int64 EntityId { get; set; }
        public Int16 IsAllDistrictAccess { get; set; }
    }

    public class CityBlockDropDown
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public Int64 LocTypeId { get; set; }
    }
    public class CountListModel
    {

        public string TotalRegistered { get; set; }
        public string TotalDisposed { get; set; }
        public string TotalPending { get; set; }
        public string TotalDisposedPercentage { get; set; }
        public string TotalRegisteredEng { get; set; }
        public string TotalDisposedEng { get; set; }
        public string TotalPendingEng { get; set; }
        public string DisposedPercentageEng { get; set; }
        public string TotalRegisteredHin { get; set; }
        public string TotalDisposedHin { get; set; }
        public string TotalPendingHin { get; set; }
        public string DisposedPercentageHin { get; set; }



    }
    public class DropDownListForExtendedDepartmentModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public int StartLocTypeId { get; set; }
        public string LocTypeName { get; set; }
        public string LocTypeNameRegional { get; set; }
    }

    public class LanguageListModel
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageNameRegional { get; set; }

    }

    public class DurationListModel
    {
        public int DurationId { get; set; }
        public string DurationName { get; set; }
        public string DurationNameRegional { get; set; }

    }
    public class HelpDataModel
    {
        public HelpChildModel Department { get; set; }
        public HelpChildModel GrvncHeadOfDepartment { get; set; }
        public HelpChildModel GrvncStateLevelNodalOfficer { get; set; }
        public HelpChildModel GrvncDepartmentalAdministrator { get; set; }
        public HelpChildModel GrvncDistrictLevelNodalOfficer { get; set; }
        public HelpChildModel TourNodalOfficer { get; set; }
        public HelpChildModel TourArTimes { get; set; }
        public HelpChildModel TourTechnicalIssues { get; set; }
        public HelpChildModel SamparkCallCenter { get; set; }
        public HelpChildModel SamparkTechnicalIssues { get; set; }
        public HelpChildModel SamparkTrainingCenter { get; set; }

    }
    public class SupportDataModel
    {
        public string RefType { get; set; }
        public string Name { get; set; }
        public string NameHindi { get; set; }
        public Int64 DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameHindi { get; set; }
    }
    public class HelpChildModel
    {
        public string Name { get; set; }
        public string NameHindi { get; set; }
    }

    public class MenuObjectsByRoleIdModel
    {
        public Int64 ObjectId { get; set; }
        public string ObjectName { get; set; }
        public string ObjectNameRegional { get; set; }
        public string FormUrl { get; set; }
        public string SvgIcon { get; set; }
        public Int32 MenuTypeId { get; set; }
    }

    public class UpdateProfileModel
    {
        public Int64 ProfileId { get; set; }
        public string Name { get; set; }
        public string NameRegional { get; set; }
        public string Email { get; set; }
        public Int64 CreatedBy { get; set; }
        public Int64? ModifiedBy { get; set; }

    }

}




