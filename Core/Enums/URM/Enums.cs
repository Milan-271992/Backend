using System.ComponentModel;

namespace Core.Enums.URM
{
    public enum AuthenticationResponse
    {
        [Description("Login successful.")]
        Successfull = 0,
        [Description("Invalid UserId or Password!")]
        InvalidUserIdOrPassword = 1,
        [Description("Your password has been expired. Please reset your password using forgot password link.")]
        PasswordExpired = 2,
        [Description("You cannot login. You have been disabled. Please contact to System Administrator.")]
        LoginDisabled = 4,
        [Description("Your failed login attempts limit crossed. Please reset your password using Forgot Password link.")]
        FailedLoginAttemptsLimitCrossed = 5,
        [Description("Login successfull. Please Change your password on first login.")]
        SuccessfullWithChangeInPasswordRequiredOnFirstLogin = 6,
        [Description("Your email address is not registered/verified with us. Please try again with registered and verified mobile number or login id provided to you.")]
        InvalidEmailAddress = 7,
        [Description("Your mobile number is not registered/verified with us. Please try again with registered and verified email address or login id provided to you.")]
        InvalidMobileNumber = 8,
        [Description("Your subscription to access this appliaction has been expired. Please contact to administrator.")]
        SubscriptionExpired = 9,
        [Description("You are not authorised to login from this source. Please contact to administrator.")]
        NotAuthorisedToLoginFromThisSource = 10,
        [Description("User Information fetched successfully.")]
        UserInformationfetchedSuccessfully = 11,
        [Description("You cannot login. You have been inactivated. Please contact to System Administrator.")]
        LoginInactive = 12,
        [Description("You cannot login. You have not been activated user. Please contact to System Administrator.")]
        ActivatedUserNotExists = 13,
        [Description("You cannot login. You have not been mapped user. Please contact to System Administrator.")]
        MappedUserNotExists = 14,
        [Description("You cannot login. You have not been activated profile. Please contact to System Administrator.")]
        ProfileNotActivated = 15,
        [Description("You cannot login. You have not been activated profile. Please contact to System Administrator.")]
        ProfileNotExists = 16,
        [Description("You cannot login. You have been disabled. Please contact to Call Center Administrator.")]
        CallCenterLoginDisabled = 17,
    }
    public enum MenuObjectType
    {
        [Description("Project")]
        Project = 1,
        [Description("Module")]
        Module = 2,
        [Description("Form/Menu Group")]
        MenuGroup = 3,
        [Description("Form")]
        Form = 4,
        [Description("Report")]
        Report = 5
    }

    [Serializable]
    public enum UserType
    {
        [Description("Deparmental")]
        Deparmental = 1,
        [Description("Citizen")]
        Citizen = 2,
        [Description("Call Center")]
        CallCenter = 3,
        [Description("Minister")]
        Minister = 4,
        [Description("Admin")]
        Admin = 5,
        [Description("KIOSK")]
        CSC = 6


    }
    public enum LoginType
    {
        [Description("SsoId")]
        SsoId = 1,
        [Description("MobileNo")]
        Citizen = 2,
        [Description("LoginId")]
        CallCenter = 3,
    }

    [Serializable]
    public enum RoleType
    {
        [Description("System Admin")]
        SystemAdmin = 3
    }

    public enum HorizonType
    {
        [Description("Department")]
        Department = 0
    }

    public enum OfficeLevel
    {
        [Description("State")]
        State = 1
    }
    public enum DeveloperAccessLevel
    {
        [Description("User cannot access Query Page")]
        NoAccess = 0,
        [Description("User can access Query Page without any restriction")]
        FullAccess = 1,
        [Description("User can execute select statement with restriction of 2000 records")]
        SelectWithRestriction = 2,
        [Description("User can execute select statement without any restrictions")]
        SelectWithoutRestriction = 3,
        [Description("User can execute Insert and select statement with restriction of 2000 records")]
        InsertSelectWithRestriction = 4,
        [Description("User can execute Insert and select statement without any restriction")]
        InsertSelectWithoutRestriction = 5,
        [Description("User can execute create, update and select statement with restriction of 2000 records")]
        UpdateSelectWithRestriction = 6,
        [Description("User can execute create, update and select statement without any restriction")]
        UpdateSelectWithoutRestriction = 7,
        [Description("User can execute create, update, delete and select statement with restriction of 2000 records")]
        DeleteSelectWithRestriction = 8,
        [Description("User can execute create, update, delete and select statement without any restriction")]
        DeleteSelectWithoutRestriction = 9,
    }
    public enum ContextScope
    {
        [Description("All")]
        All = 0,
        [Description("Associated")]
        Assosiated = -1,
        [Description("Selected")]
        Selected = -2,
        [Description("No Context")]
        NoContext = -4,
        [Description("Associated & Selected")]
        AssosiatedAndSelected = -3,

    }
    public enum Status
    {
        [Description("Alert")]
        Alert = 1,
        [Description("Success")]
        Success = 2,
        [Description("Error")]
        Error = 3,
        [Description("SessionExpired")]
        SessionExpired = 4
    }
    public enum ReturnMessage
    {
        [Description("New record saved successfully.")]
        NewRecordSavedSuccessfully = 1,
        [Description("Record updated successfully.")]
        RecordUpdatedSuccessfully = 2,
        [Description("Selected record(s) deleted successfully.")]
        SelectedRecordDeletedSuccessfully = 3,
        [Description("Oops! Record you want to delete/Update does not exist or deleted by some other user.")]
        RecordDoesNotExist = 4,
        [Description("Oops! You don't have suffucient privileges to delete this record.")]
        InsuffucientPrivilegesToDeleteRecord = 5,
        [Description("No record found.")]
        NoRecordFound = 6,
        [Description("Invalid parameters/ data does not exist for requested paremeters.")]
        InvalidParametersOrDataDoesNotExistForRequestedParameters = 7,
        [Description("Oops! You don't have sufficient privileges to access this form.")]
        InsuffucientPrivilegesToAccessThisForm = 8,
        [Description("Oops! Record you want to update is already updated by some other user. Please open the record and update again.")]
        RecordAlreadyUpdated = 9,
        [Description("Invalid Input Value")]
        ModelError = 10,
        [Description("You are not Authorized to Perform This Action!")]
        InsuffucientPrivilegesToPerformThisAction = 11,
        [Description("Record Cannot be Deleted.")]
        RecordCantBeDeleted = 12,
        [Description("Password Reset successfully.")]
        SelectedRecordResetPasswordSuccessfully = 13,
        [Description("Status Changed successfully.")]
        SelectedRecordChangeStatusSuccessfully = 14,
        [Description("Selected record(s) Submitted successfully.")]
        SelectedRecordSubmittedSuccessfully = 15,
        [Description("Application Submitted successfully.")]
        ApplicationSubmittedScuccessfully = 16,
        [Description("Application Already Submitted.")]
        ApplicationAlreadySubmitted = 17,
        [Description("Record Already Exist.")]
        RecordAlreadyExists = 18,
        [Description("Record Deleted successfully.")]
        RecordDeleted = 19,
        [Description("Records Found.")]
        RecordsFound = 20,
        [Description("Sorry ! An error occured while processing your request.")]
        ErrorOccured = 21,
        [Description("Sorry ! This Mobile No. is not Registered.   ")]
        MobileNotRegistered = 22,
        [Description("This Mobile No. is Registered.   ")]
        MobileRegistered = 23,
        [Description("User Not Exist.  ")]
        UserNotExist = 24,
        [Description("OTP Verified ")]
        OTPVerified = 25,
        [Description("OTP Not Sent ")]
        OTPNotSent = 26,
        [Description("OTP Sent ")]
        OTPSent = 27,
        [Description("OTP Not Verified.")]
        OTPNotVerified = 28,
        [Description("OTP Generated")]
        OTPGenerated = 29,
        [Description("Invalid Mobile No.")]
        InvalidMobileNo = 30,
        [Description("Mobile No. Shall Contain 10 digit")]
        MobileNoShallContain10digit = 31,
        [Description("OTP Not Generated")]
        OTPNotGenerated = 32,
        [Description("Invalid OTP. Please try again")]
        OTPWrong = 33,
        [Description("OTP Expired.")]
        OTPExpired = 34,
        [Description("OTP Verified Already")]
        OTPVerifiedAlready = 35,
        [Description("Limit Exceeds For Failed.")]
        LimitExceed = 36,
        [Description("The Mobile Number is Banned for Now, Please Try Again Later. ")]
        MobileBanned = 37,
        [Description("Session Is Changed for OTP Validation ")]
        SessionIsChanged = 38,
        [Description("Session Can not be null")]
        SessionIsNull = 39,
        [Description("Module Is Not Valid")]
        ModuleIsNotValid = 40,
        [Description("OTP can not be blank")]
        OtpIsBlank = 41,
        [Description("TransactionNumber can not be blank")]
        TransactionNumberIsBlank = 42,
        [Description("OTP Sent And Data Saved Successfully ")]
        OTPSentAndDataSaved = 43,
        [Description("Api configuration url not found")]
        ApiConfigurationUrlNotFound = 44,
        [Description("Api executed successfully")]
        ApiExecutedSuccessfully = 45,
        [Description("Your Service request has been registered successfully with Service Request No")]
        ServiceRequestRegistrationSuccessfully = 46,
        [Description("TransactionNumber is not available")]
        TransactionNumberIsNotAvailable = 47,
        [Description("Please register your self in sso first.")]
        PleaseRegisterYourSelfInSsoFirst = 48,
        [Description("Sms sent on your Registered mobile number.")]
        SmsSentAndDataSaved = 49,
        [Description("Notification not sent but Data Saved.")]
        SmsnotSent = 50,
        [Description("Mail sent on your Registered mail id.")]
        MailSentAndDataSaved = 51,
        [Description("Mail not sent but Data Saved.")]
        MailnotSent = 52,
        [Description("This role is already mapped with other service request process.")]
        RecordAllreadyInUse = 53,
        [Description("Duplicate record please connect to administration.")]
        DuplicateRecord = 54,
        [Description("Tour Details Already Exist.")]
        TourAlreadyExist = 55,
        [Description("Schedule Tour Details Already Exist.")]
        ScheduleTourAlreadyExist = 56,
        [Description("Project Status Changed successfully.")]
        ProjectChangeStatusSuccessfully = 57,
        [Description("Project Scheme Status Changed successfully.")]
        SchemeChangeStatusSuccessfully = 58,
        [Description("Service Request Role Status Changed successfully.")]
        RoleChangeStatusSuccessfully = 59,
        [Description("Scheme Name Already Exist With Selected Project.")]
        SchemeNameAlreadyExistWithSelectedProject = 60,
        [Description("Record Active Status Updated successfully")]
        RecordActiveStatusUpdated = 61,
        [Description("Service Request Project Team Record Delete Successfully.")]
        SRProjectTeamDeleteSuccessfully = 62,
        [Description("Service Request Category Record Delete Successfully.")]
        SRCategoryDeleteSuccessfully = 63,
        [Description("First Complete The Pendency Of Particular Scheme In Service Request,After That You Are Able To Delete This Scheme Record.")]
        SchemePendencyInSR = 64,
        [Description("This Delegate User Already Have Permission With Same Department, Section And Role. Please Select Another Delegate User!")]
        SameDeptSectionRoleDelegateUserAlreadyExist = 65,
        [Description("Grvnc Request For Callback Record Add Successfully.")]
        GrvncRequestForCallbackAddSuccessfully = 66,
        [Description("Schedule is Saved.")]
        ScheduleSaved = 67,
        [Description("Scheme Name Hindi Already Exist With Selected Project.")]
        SchemeNameHindiAlreadyExistWithSelectedProject = 68,
        [Description("Schedular executed successfully")]
        SchedularExecutedSuccessfully = 69,
        [Description("An OTP has already been sent to this mobile number. Please wait a few minutes before trying again.")]
        WaitForNewOTP = 70,
        [Description("Schedule tour created successfully.")]
        ScheduleTourCreatedSuccessfully = 71,
        [Description("Schedule tour updated successfully.")]
        ScheduleTourUpdatedSuccessfully = 72,
        [Description("Inspection details saved successfully.")]
        Inspectiondetailssavedsuccessfully = 73,
        [Description("Inspection details updated successfully.")]
        Inspectiondetailsupdatedsuccessfully = 74,
        [Description("UnPlanned Tour Created successfully.")]
        UnPlannedTourCreatedsuccessfully = 75,
        [Description("Inspection details deleted successfully.")]
        Inspectiondetailsdeletedsuccessfully = 76,
        [Description("Schedule tours deleted successfully.")]
        Scheduletoursdeletedsuccessfully = 77,
        [Description("Annexure entry already found, you can not delete it.")]
        ScheduletoursAnnexureEntryFoundDelete = 78,
        [Description("Jansunwai details saved successfully.")]
        Jansunwaidetailssavedsuccessfully = 79,
        [Description("Jansunwai details updated successfully.")]
        Jansunwaidetailsupdatedsuccessfully = 80,
        [Description("RatriChaupal details saved successfully.")]
        RatriChaupaldetailssavedsuccessfully = 81,
        [Description("RatriChaupal details updated successfully.")]
        RatriChaupalupdatedsuccessfully = 82,
        [Description("Meeting details saved successfully.")]
        Meetingdetailssavedsuccessfully = 83,
        [Description("Meeting details updated successfully.")]
        Meetingdetailsupdatedsuccessfully = 84,
        [Description("Record already exists. Please enter a different survey name.")]
        recordAlreadyExistsForSurveyName = 85,
        [Description("Record already exists. Please enter a different question set name.")]
        recordAlreadyExistsForquesSetName = 86,
        [Description("Enter the Questions")]
        enterTheQuestions = 87,
        [Description("Record already exists.Please enter a different sample name.")]
        recordAlreadyExistsForSample = 88,
        [Description("You have not been authorized to register a complaint on behalf of CMO, for more information contact Rajasthan Sampark Team.")]
        OrgAuthAlertKey = 89,
        [Description("Defreeze request submitted successfully.")]
        Defreezerequestsubmittedsuccessfully = 90,
        [Description("Defreeze request updated successfully.")]
        Defreezerequestupdatedsuccessfully = 91,
        [Description("Defreeze requests approved successfully.")]
        Defreezerequestsapprovedsuccessfully = 92,
        [Description("Selected users defreezed successfully.")]
        Selectedusersdefreezedsuccessfully = 93,
        [Description("Mapping not exists.")]
        mappingNotExists = 94,
        [Description("User Exists on this Office, Can not deleted.")]
        userexitsonthisofficecannotdeteted = 95,
        [Description("Campaign Name Already Exist.")]
        CampaignNameAlreadyExist = 96,
        [Description("Campaign Name Regional Already Exist.")]
        CampaignNameRegionalAlreadyExist = 97
    }
    public enum PasswordExpiryDays
    {
        [Description("Password Never Expires")]
        Never = 0,
        [Description("10 Days")]
        Days10 = 10,
        [Description("15 Days")]
        Days15 = 15,
        [Description("20 Days")]
        Days20 = 20,
        [Description("30 Days")]
        Days30 = 30,
        [Description("60 Days")]
        Days60 = 60,
        [Description("90 Days")]
        Days90 = 90,
        [Description("120 Days")]
        Days120 = 120,
        [Description("180 Days")]
        Days180 = 180
    }
    public enum WorkFlowAction
    {
        [Description("View")]
        View = 1,
        [Description("Add")]
        Add = 2,
        [Description("Edit")]
        Edit = 3,
        [Description("Delete")]
        Delete = 4
    }
    public enum WorkFlowStatus
    {
        [Description("Draft")]
        Draft = 1,
        [Description("Deleted")]
        Deleted = 2,
        [Description("Submitted")]
        Submitted = 3,
        [Description("Verified")]
        Verified = 4,
        [Description("Approved")]
        Approved = 5,
        [Description("Rejected")]
        Rejected = 6,
        [Description("Forwarded")]
        Forwarded = 7,
        [Description("Forwarded for Approval")]
        ForwardApproved = 8,
        [Description("Open")]
        Open = 9,
        [Description("Close")]
        Close = 10,
        [Description("Updated")]
        Updated = 11,
        [Description("Accepted")]
        Accepted = 13,
        [Description("INITIATE")]
        InitiateAudit = 14,
        [Description("AUDIT IN PROCESS")]
        AuditInProcess = 15,
        [Description("AUDIT COMPLETE")]
        AuditComplete = 16,
        [Description("REPORT SUBMISSION")]
        ReportSubmission = 17
    }
    public enum IntimateStatus
    {
        [Description("Open")]
        Open = 0,
        [Description("Close")]
        Close = 1

    }
    public enum MapStatus
    {
        [Description("All")]
        All = 0,
        [Description("Mapped")]
        Mapped = 1,
        [Description("Unmepped")]
        Unmapped = 2
    }
    public enum FailedLoginAttemptsLimit
    {
        [Description("FailedLoginAttemptsLimit")]
        FailedLoginAttemptsLimit = 5
    }

    public enum ExportFileterType
    {
        [Description("Export All")]
        ExportAll = 1,
        [Description("Export Filter")]
        ExportFilter = 2,
        [Description("Export Visible")]
        ExportVisible = 3
    }
    public enum PGEnums
    {
        [Description("DPG")]
        DPG = 731,
        [Description("PRSEC")]
        PRSEC = 732,
        [Description("DOPPW")]
        DOPPW = 733,
        [Description("DARPG")]
        DARPG = 734,
        [Description("PMOPG")]
        PMOPG = 735
    }

    public enum PG_Complain_Status
    {
        ReopenL4 = 39,
        SpecialDisposed = 21,
        PartialDisposed = 19,
        MoveToCPGRAM = 57,
        PendingAtCPGRAM = 56,
        PendingToMoveonCPGRAM = 55

    }
    [Serializable]
    public enum LDAUserType
    {
        [Description("System Admin")]
        SystemAdmin = 1,
        [Description("Department Administrator")]
        DepartmentAdmin = 2,
        [Description("Employee")]
        Employee = 3,
        [Description("Citizen")]
        Citizen = 4
    }
    public enum UserPasswordFlag
    {
        [Description("Change Password")]
        ChangePassword = 1,
        [Description("Reset Password")]
        ResetPassword = 2
    }

}

