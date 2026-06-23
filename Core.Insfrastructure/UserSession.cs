using Core.Enums.URM;
using Core.Enums;
using Core.Utils;
using System.Reflection;
using System.Text;
using Core.Models;

namespace Core.Insfrastructure
{
#nullable disable
    public class Session
    {
        public static UserSessionModel UserSession { get; set; }
        public static Language UserLanguge { get; set; }

        public static void SetUserSession(UserSessionModel userSessionData, Language? userLanguage = null)
        {
            UserSession = userSessionData;
            //UserLanguge = UserLanguge;
            UserLanguge = userLanguage.Value;
            //FillAccessValidator(userSessionData.RoleId, userSessionData.FormUrl, -1, UPMDbContext context);
        }

        public static bool HasAccess(Int32 priviledgeId)
        {
            if (!String.IsNullOrEmpty(UserSession.Previleges))
            {
                string sessionPrevileges = UserSession.Previleges;
                if (sessionPrevileges.Contains(Convert.ToString(priviledgeId)))//any
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static string SeriaizeUserSessionData()
        {
            //Int32 userTypeId = (Int32)UserSession.UserType;
            //Int32 userLanguageId = (Int32)UserSession.UserLanguage;
            return Newtonsoft.Json.JsonConvert.SerializeObject(
                    new UserSessionModel()
                    {
                        Id = 0,
                        ProfileId = UserSession.ProfileId,
                        LoginId = UserSession.LoginId,
                        LoginLogId = UserSession.LoginLogId,
                        LoginStatusId = UserSession.LoginStatusId,
                        MobileNumber = UserSession.MobileNumber,
                        SSOId = UserSession.SSOId,
                        //OrganizationName = UserSession.OrganizationName,
                        //SchemeName = UserSession.SchemeName,
                        //OrgCode = UserSession.OrgCode,
                        // OrgId = UserSession.OrgId,
                        //PersonalDetails = new PersonalDetails()
                        //{
                        //    DOB = (UserSession.PersonalDetails == null ? null : UserSession.PersonalDetails.DOB),
                        //    EmailAddress = (UserSession.PersonalDetails == null ? "" : UserSession.PersonalDetails.EmailAddress),
                        //    MobileNumber = (UserSession.PersonalDetails == null ? "" : UserSession.PersonalDetails.MobileNumber),
                        //    Name = (UserSession.PersonalDetails == null ? "" : UserSession.PersonalDetails.Name)
                        //},
                        // Priveleges = UserSession.Priveleges,
                        //  RoleId = UserSession.RoleId,
                        RoleName = UserSession.RoleName,
                        UserName = UserSession.UserName,
                        UserReferenceNumber = UserSession.UserReferenceNumber,
                        UserType = UserSession.UserType,
                        // HorizonMappingId = UserSession.HorizonMappingId,
                        // ParentOrgId = UserSession.ParentOrgId,
                        // AssociatedOrgId = UserSession.AssociatedOrgId,
                        // SchemeId = UserSession.SchemeId,
                        // HorizonTypeId = UserSession.HorizonTypeId,
                        // HorizonName = UserSession.HorizonName,
                        // PostId = UserSession.PostId,
                        // OfficeId = UserSession.OfficeId,
                        //OfficeName = UserSession.OfficeName,
                        // OfficeTypeId = UserSession.OfficeTypeId,
                        //  OfficeTypeName = UserSession.OfficeTypeName,
                        Language = UserSession.Language,
                        RoleId = UserSession.RoleId,
                        TypeId = UserSession.TypeId,
                        UserId = UserSession.UserId,
                        Previleges = UserSession.Previleges,
                        FormUrl = UserSession.FormUrl,
                        DesignationId = UserSession.DesignationId,
                        //DistrictId = UserSession.DistrictId,
                        //DepartmentId = UserSession.DepartmentId,
                        //OfficeNo = UserSession.OfficeNo
                        // FinYear = UserSession.FinYear
                    });
        }

        public static string GetUserSessionData()
        {
            //Int32 userTypeId = (Int32)UserSession.UserType;
            //Int32 userLanguageId = (Int32)UserSession.UserLanguage;
            return Newtonsoft.Json.JsonConvert.SerializeObject(
                    new UserSessionModel()
                    {
                        ProfileId = UserSession.ProfileId,
                        LoginId = UserSession.LoginId,
                        LoginLogId = UserSession.LoginLogId,
                        LoginStatusId = UserSession.LoginStatusId,
                        SSOId = UserSession.SSOId,
                        // OrganizationName = UserSession.OrganizationName,
                        // OrgCode = UserSession.OrgCode,
                        // OrgId = UserSession.OrgId,
                        //  RoleId = UserSession.RoleId,
                        UserReferenceNumber = UserSession.UserReferenceNumber,
                        UserType = UserSession.UserType,
                        // HorizonMappingId = UserSession.HorizonMappingId,
                        // ParentOrgId = UserSession.ParentOrgId,
                        // AssociatedOrgId = UserSession.AssociatedOrgId,
                        // SchemeId = UserSession.SchemeId,
                        // HorizonTypeId = UserSession.HorizonTypeId,
                        //  PostId = UserSession.PostId,
                        // OfficeId = UserSession.OfficeId,
                        //  OfficeTypeId = UserSession.OfficeTypeId,
                        Language = UserSession.Language
                    }, Newtonsoft.Json.Formatting.None, new Newtonsoft.Json.JsonSerializerSettings
                    {
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
                    });
        }

        public static string GetErrorLogFiles(List<ErrorFiles> files)
        {
            StringBuilder str = new StringBuilder();
            try
            {
                CommonUtility CommonUtility = new CommonUtility();
                int i = 0;
                str.Append("<table class=\"table table-striped\" width='50%' class='gridview'><tbody><tr><th style='width:5%'>Sr No </th><th>Error File </th><th>File Size </th><th>Last Modified on</th><th style='width:8%'>Download</th></tr>");
                foreach (var filePath in files.OrderByDescending(x=>x.Files).ToList())
                {
                    string fileName = Path.GetFileName(filePath.Files);
                    FileInfo fileInfo = new FileInfo(filePath.Files);
                    DateTime lastModified = DateTime.Now.Date;

                    DateTime CreatedOn = DateTime.Now.Date;
                    double fileSize = 0;

                    try
                    {
                        //if (fileInfo.Length > 0)
                        {
                            fileSize = Math.Round(fileInfo.Length / 1024.0, 2);
                            lastModified = fileInfo.LastWriteTime;
                            CreatedOn = fileInfo.CreationTime;
                        }
                    }
                    catch (Exception)
                    {

                    }

                    TimeSpan dateDiff = DateTime.Now - CreatedOn;
                    string absolutePath = Path.GetFullPath(filePath.Files);
                    //string downloadLink = Url.Action("DownloadFile", "ErrorLogs", new { filePath = absolutePath });
                    StringBuilder strdownloadLink = new StringBuilder();
                    string downloadLink = CommonUtility.DownloadFile(absolutePath);
                    strdownloadLink.Append(downloadLink);
                    //if (dateDiff.TotalDays <= 10)
                    {
                        i++;
                        str.Append("<tr>");
                        str.Append("<td style='text-align: center;'>" + i + "</td>");
                        str.Append("<td>" + fileName + "</td>");
                        str.Append("<td>" + fileSize + "Kb</td>");
                        str.Append("<td>" + lastModified + "</td>");
                        str.Append("<td style='text-align: center;'><a href='" + strdownloadLink.ToString() + "'  download ='" + fileName + "' >Download</a></td>");
                        str.Append("</tr>");
                    }
                }
                //return files;
                return str.ToString();
            }
            catch (Exception ex)
            {
                LogUtility LogUtility = new LogUtility();   LogUtility.WriteEventErrorLog(ex, "", MethodBase.GetCurrentMethod().DeclaringType.ToString() + "." + MethodBase.GetCurrentMethod().Name, "");
                throw;
            }
        }



    }
#nullable disable
    public class PersonalDetails
    {

        public string Name { get; set; }

        public string MobileNumber { get; set; }

        public string EmailAddress { get; set; }

        public DateTime? DOB { get; set; }
    }
#nullable disable
    public class UserSessionModel
    {
        public Int64 Id { get; set; }
        public Int64 ProfileId { get; set; }
        public Int64 UserId { get; set; }
        public Int32 RoleId { get; set; }
        public Int64 DesignationId { get; set; }
        public Int64 DistrictId { get; set; }
        public Int64 DepartmentId { get; set; }
        public Int64 OfficeNo { get; set; }
        public Int32 TypeId { get; set; }
        public string LoginId { get; set; }
        public string UserName { get; set; }
        public string Previleges { get; set; }
        public UserDetails UserDetails { get; set; }
        //public Int32 OrgId { get; set; }
        // public string OrgCode { get; set; }
        // public string OrganizationName { get; set; }
        public Int64 LoginLogId { get; set; }
        public Int64 UserReferenceNumber { get; set; }
        public UserType UserType { get; set; }
        public Int64 UserTypeId { get; set; }
        public Int32 LoginStatusId { get; set; }
        public string RoleName { get; set; }
        // public Int32 HorizonMappingId { get; set; }
        //public Int32 SchemeId { get; set; }
        //public string SchemeName { get; set; }
        // public Int32 ParentOrgId { get; set; }
        // public Int32 AssociatedOrgId { get; set; }
        //  public Int32? HorizonTypeId { get; set; }
        // public string HorizonName { get; set; }
        // public Int32 MappingTypeId { get; set; }
        // public Int32? PostId { get; set; }
        //  public Int32 OfficeId { get; set; }
        //public string OfficeName { get; set; }
        // public Int32 OfficeTypeId { get; set; }
        // public string OfficeTypeName { get; set; }
        // public PersonalDetails PersonalDetails { get; set; }
        public string MobileNumber { get; set; }
        //public List<Int32> Priveleges { get; set; }
        //public bool HasPrivelge(Int32 ActionId)
        //{
        //  return this.Priveleges.Contains(ActionId);
        //}
        public string SSOUrl { get; set; }
        public string SSOId { get; set; }
        public string Language { get; set; }
        // public Int64? FinYear { get; set; }
        public string FormUrl { get; set; }
        public Int32? IsDisplayProfilePage { get; set; }
        public Int32? IsProfileIncomplete { get; set; }
        public List<RoleList> RoleList { get; set; }

        public List<DepartmentModule> DepartmentModule { get; set; }
        public selectedDepAndRole selectedDepAndRole { get; set; }

        public AgentLogin AgentLogin { get; set; }
    }


    public class OpeningBalanceProductExport
    {
        public Int64? ProductGroupId { get; set; }
        public Int64? ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductGroupName { get; set; }
        public string PackingName { get; set; }

    }

    public class ErrorFiles
    {
        public string Files { get; set; }
    }
    public class OpeningBalanceExport
    {

        public Int64? StoreId { get; set; }
        public Int64? ProductGroupId { get; set; }
        public Int64? ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductGroupName { get; set; }
        public string OpeningBalanceDate { get; set; }
        public Int32? OpeningBalanceQty { get; set; }
        public Int32? FinYear { get; set; }
        public decimal Rate { get; set; }
        public decimal? OpeningAmount { get; set; }
        public string StoreName { get; set; }
        public string PackingName { get; set; }
    }

    public class CommonModelExport
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
    }

    public class PackingModelExport
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public decimal QtyPerPack { get; set; }
    }

    public class RoleList
    {
        public Int64 UserId { get; set; }
        public Int64 ProfileId { get; set; }
        public string InternalId { get; set; }
        public Int64 RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleNameHindi { get; set; }
        public string Active { get; set; }
        public Int64 DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentNameHindi { get; set; }
        public string IsExtendedLocation { get; set; }		//New Added due to extended data
        public string SectionName { get; set; }
        public string SectionHindi { get; set; }
        public Int64 SectionId { get; set; }
        public Int64 LoginLogId { get; set; }
        public string Language { get; set; }
        public Int16? IsDelegated { get; set; }
        public Int16? IsEdit { get; set; }
        public Int64? DelegatedFromUserId { get; set; }
    }
    public class DepartmentModule
    {

        public string DepartmentName { get; set; }
        public string DepartmentNameHindi { get; set; }
        public Int64 DepartmentID { get; set; }
        public string IsExtendedLocation { get; set; }		//New Added due to extended data
        public List<RoleList> RoleList { get; set; }


    }
    public class selectedDepAndRole
    {
        public Int64 LastRoleId { get; set; }
        public Int64 LastUserId { get; set; }
        public Int64 LastUserTypeId { get; set; }
    }

    public class CmoUserAllocation
    {
        public string compuser { get; set; }
    }
    public class UserSpecificDetail
    {
        public Int64 DesignationId { get; set; }
        public Int64 DistrictId { get; set; }
        public Int64 DepartmentId { get; set; }
        public Int64 OfficeNo { get; set; }
    }

    public class ExportHeader
    {
        public string ColHeader { get; set; }

    }
    public class ExportHeaderData
    {
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string Col5 { get; set; }
        public string Col6 { get; set; }
        public string Col7 { get; set; }
        public string Col8 { get; set; }
        public string Col9 { get; set; }
        public string Col10 { get; set; }
        public string Col11 { get; set; }
        public string Col12 { get; set; }
        public string Col13 { get; set; }
        public string Col14 { get; set; }
        public string Col15 { get; set; }
        public string Col16 { get; set; }
    }

    public class perentModel
    {
        public List<Int64> UserNumber { get; set; }
        public List<Int64> UserNumberNotIn { get; set; }
    }
    public class AgentLogin
    {
        public Int64 AgentId { get; set; }
        public string AgentCode { get; set; }
        public List<CampaignNameChild> Campaign { get; set; }
        public string AgentActType { get; set; }
        public int EnableOnAll { get; set; }
        public string IpAddress { get; set; }
        public string TimerAfterlog { get; set; }

    }
    public class CampaignNameChild
    {
        public Int64 CampaignId { get; set; }
        public string CampaignName { get; set; }
        public string CampaignNameRegional { get; set; }
        public string ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleNameRegional { get; set; }
        public int PullBackTime { get; set; }
        public string CampaignType { get; set; }
        public string IpAddress { get; set; }
        public Int64 AgentId { get; set; }
        public string AgentCode { get; set; }
        public string EnableOnAll { get; set; }
        public string AgentActType { get; set; }
        public int CallBackAttemptNo { get; set; }
        public int CallBackTime { get; set; }
    }
}
