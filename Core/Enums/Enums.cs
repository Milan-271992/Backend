using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Core.Enums
{

    public enum Language
    {
        [Description("Default-English")]
        DefaultEnglish = 0,
        [Description("English")]
        English = 1,
        [Description("Hindi")]
        Hindi = 2,
        [Description("Punjabi")]
        Punjabi = 3
    }
    public enum MenuType
    {

        [Description("Module")]
        Module = 1,
        [Description("Menu Group")]
        MenuGroup = 2,
        [Description("Menu")]
        Menu = 3,
    }
    public enum SentOn
    {
        [Description("Mobile")]
        Mobileno = 1,
        [Description("Email")]
        Email = 2,
        [Description("Mobile And Email")]
        Edit = 3,
        [Description("Voice Message")]
        VoiceMessage = 4
    }
    public enum Page
    {
        [Description("Start No.")]
        StartNo = 1,
        [Description("End No.")]
        EndNo = 2
    }
    public enum enmDuration
    {
        [Description("Hours")]
        Hours = 1,
        [Description("Days")]
        Days = 2
    }
    public enum enmDurationHindi
    {
        [Description("घंटे")]
        घंटे = 1,
        [Description("दिन")]
        दिन = 2
    }
    public enum Module
    {
        [Description("DASHBOARD")]
        DASHBOARD = 21,
        [Description("GRIEVANCE")]
        GRIEVANCE = 22,
        [Description("REPORTS")]
        REPORTS = 23,
        [Description("JANSUNWAI")]
        JANSUNWAI = 24,
        [Description("TOUR AND INSPECTION")]
        TOURANDINSPECTION = 25,
        [Description("SAMPARK HELPLINE")]
        SAMPARKHELPLINE = 26,
        [Description("DOIT SERVICE")]
        DOITSERVICE = 27,
        [Description("SETTING")]
        SETTING = 28,
        [Description("USER PROFILE MANAGEMENT")]
        UPM = 41,
        [Description("IDEAS AND INNOVATION")]
        IDEASANDINNOVATION = 41,
        [Description("NOTIFICATION")]
        NTF = 61,
        [Description("REALITY CHECK")]
        REALITYCHECK = 69,
        [Description("SERVICE REQUEST")]
        SERVICEREQUEST = 115,
        [Description("Schemes/Services")]
        SCHEMESSERVICES = 256,
        [Description("CALLCENTER")]
        CALLCENTER = 263,
        [Description("eJansunwai")]
        eJANSUNWAI = 1002
    }
    public enum ModuleURL
    {

        [Description("GRVNC")]
        GRVNC = 22,
        [Description("REPORTS")]
        REPORTS = 23,
        [Description("UPM")]
        UPM = 41,
        [Description("NTF")]
        NTF = 61,
        [Description("DMS")]
        DMS = 69,
    }
    public enum FileSystemEntityType
    {
        [Description("GrievanceShortForm")]
        GrievanceShortForm = 1,
        [Description("GrievanceLongForm")]
        GrievanceLongForm = 2,
        [Description("BulkSchedule")]
        BulkScheduleForm = 3
    }
    public enum FailedCount
    {
        [Description("One")]
        One = 1,
        [Description("Two")]
        Two = 2,
        [Description("Three")]
        Three = 3,
        [Description("Four")]
        Four = 4,
        [Description("Five")]
        Five = 5,
        [Description("Six")]
        Six = 6,
        [Description("Seven")]
        Seven = 7,
        [Description("Eight")]
        Eight = 8,
        [Description("Nine")]
        Nine = 9,
        [Description("Ten")]
        Ten = 10,
    }
    public enum Event
    {
        [Description("Send OTP ")]
        SentOTP = 61,
        [Description("Send OTP Email")]
        SentOTPEmail = 60,
        [Description("Grivenance Registration")]
        GrivenanceReg = 35,
        [Description("Griev Reg Long Form")]
        GrivenanceRegLong = 6,
        [Description("Griev Reg Long Form")]
        GrivenanceRegLongCmo = 103,
        [Description("Griev Reg Multi Form")]
        GrivenanceRegMulti = 111,
        [Description("Griev Reg NRR Form")]
        GrivenanceRegNRR = 113,
        [Description("VoiceMessage")]
        VoiceMessage = 130,
        [Description("Survey Intimation")]
        SurveyIntimation = 160,
        [Description("Service Request Assigned SMS")]
        ServiceRequestAssignedSMS = 171,
        [Description("Service Request Assigned EMail")]
        ServiceRequestAssignedEmail = 172,
        [Description("Scheme Service Registration SMS")]
        SchemeServiceRegistrationSMS = 175,
        [Description("Scheme Service Registration EMail")]
        SchemeServiceRegistrationEmail = 176,
        [Description("Scheme Service Auto Grievance SMS")]
        SchemeServiceAutoGrievanceSMS = 177,
        [Description("Scheme Service Auto Grievance EMail")]
        SchemeServiceAutoGrievanceEmail = 178,
        [Description("Service Request Clarification Received SMS")]
        ServiceRequestClarificationReceivedSMS = 188,
        [Description("Service Request Clarification Received EMail")]
        ServiceRequestClarificationReceivedEmail = 189,
        [Description("Service Request Forwared SMS")]
        ServiceRequestForwaredSMS = 190,
        [Description("Service Request Forwared EMail")]
        ServiceRequestForwaredEmail = 191,
        [Description("Service Request Sent for Clarification EMail")]
        ServiceRequestSentForClarificationEmail = 192,
        [Description("Service Request Sent for Clarification SMS")]
        ServiceRequestSentForClarificationSMS = 193,
        [Description("Service Request TransferSMS EMail")]
        ServiceRequestTransferEmail = 194,
        [Description("Service Request TransferSMS")]
        ServiceRequestTransferSMS = 195,
        [Description("Grev Suggestion")]
        GrevSuggestion = 200,
        [Description("eJansunwai Create WebEx Meeting SMS")]
        eJanSunwaiCreateMeetingSMS = 202,
        [Description("Whatsapp Message for upload Doucment")]
        WhatsAppForCallCenter = 203,
        [Description("eJansunwai Cancelled SMS")]
        eJanSunwaiCancelSMS = 204,
        [Description("eJansunwai Rescheduled SMS")]
        eJanSunwaiRescheduledSMS = 205,
        [Description("Grev Feedback")]
        GrevFeedback = 206,
        [Description("SCHEDULAR_AUTO_EXCALATED")]
        SCHEDULAR_AUTO_EXCALATED = 209,
        [Description("OFFICERSMS_LEVEL1")]
        OFFICERSMS_LEVEL1 = 215,
        [Description("OFFICERSMS_LEVEL2")]
        OFFICERSMS_LEVEL2 = 216,
        [Description("OFFICERSMS_LEVEL3")]
        OFFICERSMS_LEVEL3 = 217,
        [Description("OFFICERSMSL4")]
        OFFICERSMSL4 = 218,
        [Description("DefaultSupervisorSMS")]
        DefaultSupervisorSMS = 219,
        [Description("MappedOfficerSMS")]
        MappedOfficerSMS = 220,
        [Description("Callback Request Grievance")]
        CallbackRequestGrievance = 222,
        [Description("Callback Request Service Scheme")]
        CallbackRequestSchemeService = 223,
        [Description("Partially close")] PartiallyClose = 224,
        [Description("Partially reject")] PartiallyReject = 225,
        [Description("Grev Reopen")] GrevReopen = 226,
        [Description("Seek For Guidance")] SeekForGuidance = 227,
        [Description("Remarks Other Than Officer")] RemarksOtherThanOfficer = 228,
        [Description("Survey SMS")] SurveySMS = 229,
        [Description("Survey Q1 SMS")] SurveyQ1SMS = 230,
        [Description("Survey Q2 SMS")] SurveyQ2SMS = 231,
        [Description("Survey Q3 SMS")] SurveyQ3SMS = 232,
        [Description("Survey Finish SMS")] SurveyFinishSMS = 233,
        [Description("Survey WhatsApp")] SurveyWhatsApp = 234,

    }
    public enum MonthsName
    {
        [Description("January")]
        January = 1,
        [Description("Febuary")]
        Febuary = 2,
        [Description("March")]
        March = 3,
        [Description("April")]
        April = 4,
        [Description("May")]
        May = 5,
        [Description("June")]
        June = 6,
        [Description("July")]
        July = 7,
        [Description("August")]
        August = 8,
        [Description("September")]
        September = 9,
        [Description("October")]
        October = 10,
        [Description("November")]
        November = 11,
        [Description("December")]
        December = 12
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
        [Description("Invalid Parameters Or Data Does Not Exist For Requested Parameters.")]
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
        [Description("Application submitted successfully.")]
        ApplicationSubmittedScuccessfully = 16,
        [Description("Application Already Submitted.")]
        ApplicationAlreadySubmitted = 17,
        [Description("Record Already Exist.")]
        RecordAlreadyExists = 18,
        [Description("Record Deleted successfully.")]
        RecordDeleted = 19,
        [Description(" Records Found. ")]
        RecordsFound = 20,
        [Description("Sorry ! An error occured while processing your request.")]
        SorryAnErrorOccuredWhileProcessingYourRequest = 21,
        [Description("Email already exists.")]
        EmailAlreadyExists = 22,
        [Description("Internal Id already exists.")]
        InternalIdAlreadyExists = 23,
        [Description("SSO detail not found.")]
        SSODetailNotFound = 24,
        [Description("SSO details fetching successfully.")]
        SSODetailsFetchingSuccessfully = 25,
        [Description("Session data (authKey) do not match.")]
        AuthKeyMismatch = 26,
        [Description("Session data do not match (authId tempered).")]
        AuthIdMismatch = 27,
        [Description("Login id and password is mandatory.")]
        LoginPasswordmandatory = 28,
        [Description("User details not found.")]
        UserDetailNotFound = 29,
        [Description("Session expired or not created yet.")]
        SessionExpired = 30,
        [Description("Internal Id Generate Successfully")]
        InternalIdGenerateSuccessfully = 31,
        [Description("please enter description first.")]
        pleaseEnterDescriptionFirst = 32,
        [Description("Please select departmenttype first!")]
        PleaseSelectDepartmentTypeFirst = 33,
        [Description("Please fill Name of Proposed Plan, if Any..")]
        PleaseFillNameOfProposedPlanIfAny = 34,
        [Description("Please Select Idea..")]
        PleaseSelectIdea = 35,
        [Description("Please Select Idea evolved or implemented..")]
        PleaseSelectIdeaEvolvedOrImplemented = 36,
        [Description("Please fill Description..")]
        PleaseFillDescription = 37,
        [Description("Invalid Description!")]
        InvalidDescription = 38,
        [Description("Word Limit Is Crossed...")]
        PleaseSelectAtLeastOneNatureOfInnovation = 39,
        [Description("Please Select Requirements..")]
        PleaseSelectRequirements = 40,
        [Description("Please Select Status..")]
        PleaseSelectStatus = 41,
        [Description("File is too large, upload upto 10 MB!")]
        FileIsTooLargeUploadUpto10MB = 42,
        [Description("File should be in .doc,.pdf,.jpg format only!")]
        FileShouldBeInDocPdfJpgFormatOnly = 43,
        [Description("Please Select Your Rating, if Any..")]
        PleaseSelectYourRatingIfAny = 44,
        [Description("Please fill Title..")]
        PleaseFillTitle = 45,
        [Description("Word Limit Is Crossed")]
        WordLimitIsCrossed = 46,
        [Description("File not uploaded!")]
        FileNotUploaded = 47,
        [Description("File name not exists!")]
        FileNameNotExists = 48,
        [Description("File should be in .pptx,.pdf,.jpg,.ppt format only!")]
        FileShouldBeInPptxPdfJpgPptFormatOnly = 49,
        [Description("File should be in .jpg format only!")]
        FileShouldBeInJpgFormatOnly = 50,
        [Description("Record Cannot be saved.")]
        RecordCanNotBeSaved = 51,
        [Description("Officer Application Closed Successfully.")]
        OfficerApplicationClosedSuccessfully = 52,
        [Description("Please provide officer name first.")]
        PleaseProvideOfficerNameFirst = 53,
        [Description("Please provide designation first.")]
        PleaseProvideDesignationFirst = 54,
        [Description("Please provide office location first.")]
        PleaseProvideOfficeLocationFirst = 55,
        [Description("Please provide employee number first.")]
        PleaseProvideEmployeeNumberFirst = 56,
        [Description("Please provide gpf number first.")]
        PleaseProvideGPFNumberFirst = 57,
        [Description("Please provide mobile number first.")]
        PleaseProvideMobileNumberFirst = 58,
        [Description("Please provide phone number first.")]
        PleaseProvidePhoneNumberFirst = 59,
        [Description("Please provide email first.")]
        PleaseProvideEmailFirst = 60,
        [Description("Please provide SSO first.")]
        PleaseProvideSSOFirst = 61,
        [Description("Please select photograph jpeg,jpg,png only.")]
        PleaseSelectPhotographJPEGJPGPNGOnly = 62,
        [Description("Please provide office name first.")]
        PleaseProvideOfficeNameFirst = 63,
        [Description("RajMaster data sync successfully.")]
        RajMasterDataSyncSuccessfully = 64,
        [Description("Time expired must be less then 30 mins.")]
        MaxTime = 65,
        [Description("Please enter project name first.")]
        PleaseEnterProjectNameFirst = 66,
        [Description("Please Enter Category Name First.")]
        PleaseEnterCategoryNameFirst = 67,
        [Description("Please Enter Role Name First.")]
        PleaseEnterRoleNameFirst = 68,
        [Description("Please Select Status First.")]
        PleaseSelectStatusFirst = 69,
        [Description("Please Select Role First.")]
        PleaseSelectRoleFirst = 70,
        [Description("Please Select Service Request Project First.")]
        PleaseSelectServiceRequestProjectFirst = 71,
        [Description("Please Select Service Request Scheme First.")]
        PleaseSelectServiceRequestSchemeFirst = 72,
        [Description("Please Enter Description First.")]
        PleaseEnterDescriptionFirst = 73,
        [Description("Please Enter Description 2000 Character Only.")]
        PleaseEnterDescription2000CharacterOnly = 74,
        [Description("Please select department first!")]
        PleaseSelectDepartmentFirst = 75,
        [Description("Please select officer level first!")]
        PleaseSelectOfficerLevelFirst = 76,
        [Description("Please select officer first!")]
        PleaseSelectOfficerFirst = 77,
        [Description("Please select nodal officer first!")]
        PleaseSelectNodalOfficerFirst = 78,
        [Description("Please select office first!")]
        PleaseSelectOfficeFirst = 79,
        [Description("Please select zone first!")]
        PleaseSelectZoneFirst = 80,
        [Description("Please select section first!")]
        PleaseSelectSectionFirst = 81,
        [Description("Email not verified.")]
        EmailNotVerified = 82,
        [Description("Session expired.")]
        SessionTimeout = 83,
        [Description("Please select originating authority")]
        OriginatingAuthority = 84,
        [Description("Due to un-availability of mapping grievance can't be register")]
        AutoAllocationFailed = 85,
        [Description("Please enter Janaadhar number")]
        PleaseEnterJanaadharNumber = 86,
        [Description("Please select Janaadhar member id")]
        PleaseSelectJanaadharMemberId = 87,
        [Description("GrievanceId Is Verified")]
        VerifiedPrevGrievance = 88,
        [Description("GrievanceId is not verified please enter valid grievanceId")]
        NotVerifiedPrevGrievance = 89,
        [Description("Grievance Form Submitted Successfully")]
        GrievanceFormSubmitted = 90,
        [Description("Please Select Available Action")]
        PleaseSelectAvailableAction = 91,
        [Description("First configure the team for selected project.")]
        NodalOfficerNotFound = 92,
        [Description("Login successfully")]
        LoginSuccessfully = 93,
        [Description("User not authenticated")]
        UserNotAuthenticated = 94,
        [Description("Record already deleted")]
        RecordAlreadyDeleted = 95,
        [Description("Service Request is already disposed...!")]
        ServiceRequestIsAlreadyDisposed = 96,
        [Description("Service Request Forwarded Successfully!")]
        ServiceRequestForwardedSuccessfully = 97,
        [Description("Please select Priority.!")]
        PleaseSelectPriority = 98,
        [Description("Service Request Pullback Successfully!")]
        ServiceRequestPullbackSuccessfully = 99,
        [Description("Service Request Transfer Successfully!")]
        ServiceRequestTransferSuccessfully = 100,
        [Description("Service Request Dispose Successfully!")]
        ServiceRequestDisposeSuccessfully = 101,
        [Description("Service Request Reply Successfully!")]
        ServiceRequestReplySuccessfully = 102,
        [Description("Service Request Clarification Successfully!")]
        ServiceRequestClarificationSuccessfully = 103,
        [Description("Service Request Sent For Approval Successfully!")]
        ServiceRequestSentForApprovalSuccessfully = 104,
        [Description("You have already taken action on this...!")]
        Youhavealreadytakenactiononthis = 105,
        [Description("Service Request Approval Successfully!")]
        ServiceRequestApprovalSuccessfully = 106,
        [Description("Service Request is not disposed, so it cannot be reopened...!")]
        ServiceRequestIsNotDisposedSoItCanNotBeReOpened = 107,
        [Description("Service Request Reopened Successfully!")]
        ServiceRequestReopenedSuccessfully = 108,
        [Description("Please Enter Role Name Hindi First.")]
        PleaseEnterRoleNameHindiFirst = 109,
        [Description("Please Enter Project Name Hindi First.")]
        PleaseEnterProjectNameHindiFirst = 110,
        [Description("Please Enter Category Name Hindi First.")]
        PleaseEnterCategoryNameHindiFirst = 111,
        [Description("Citizen data not found. Please check Citizen data")]
        CitizenDataNotFound = 112,
        [Description("Scheme/Service data found. Please check Scheme/Service data.")]
        SchemeServiceDataNotFound = 113,
        [Description("Application data found. Please check Application data.")]
        SchemeServiceApplicationDataNotFound = 114,
        [Description("Please check Scheme/Service destination office data.")]
        SchemeServiceDestinationOfficeDataNotFound = 115,
        [Description("Application record does not exists.")]
        ApplicationRecordDoesNotExists = 116,
        [Description("Application E-Form not submitted.")]
        ApplicationEFormNotSubmitted = 117,
        [Description("Application documents not submitted")]
        ApplicationDocumentNotSubmitted = 118,
        [Description("Citizen details saved successfully.")]
        CitizenProfileSavedSuccessfully = 119,
        [Description("Citizen details updated successfully.")]
        CitizenProfileUpdatedSuccessfully = 120,
        [Description("Form details saved successfully.")]
        ApplicationEFormDataSavedSuccessfully = 121,
        [Description("Form details updated successfully.")]
        ApplicationEFormDataUpdatedSuccessfully = 122,
        [Description("Documents uploaded successfully.")]
        ApplicationDocumentSavedSuccessfully = 123,
        [Description("Documents uploaded successfully.")]
        ApplicationDocumentUpdatedSuccessfully = 124,
        [Description("Thanks for submitting the feedback for your grievance")]
        FeedBackSubmit = 125,
        [Description("Thanks for your Reopen request")]
        ReopenRequest = 126,
        [Description("Grievance Under Process")]
        GrievanceUnderProcess = 127,
        [Description("Please select office type name hindi.")]
        PleaseSelectOfficetypename = 128,
        [Description("Please select office type name.")]
        PleaseSelectOfficetypenamehindi = 129,
        [Description("Please select department.")]
        PleaseSelectDepartment = 130,
        [Description("Please select location .")]
        PleaseSelectLocation = 131,
        [Description("Please select Designation .")]
        PleaseSelectDesignation = 132,
        [Description("Please select panel name .")]
        PleaseSelectPanelname = 133,
        [Description("Please select SSOId name .")]
        PleaseSelectSSOId = 134,
        [Description("Please select User.")]
        PleaseSelectUser = 135,
        [Description("Please select Language .")]
        PleaseSelectLanguage = 136,
        [Description("Please select office  name hindi.")]
        PleaseSelectOfficenamehindi = 137,
        [Description("Please select office  name.")]
        PleaseSelectOfficename = 138,
        [Description("Please select Section  name.")]
        PleaseSelectSectioname = 139,
        [Description("Please select Section  name hindi.")]
        PleaseSelectSectionamehindi = 140,
        [Description("Please Select User.")]
        PleaseSelectuser = 141,
        [Description("Please select delegate user .")]
        PleaseSelectDelegateuser = 142,
        [Description("Please select Category .")]
        PleaseSelectCategory = 143,
        [Description("Please select Authority .")]
        PleaseSelectAuthority = 144,
        [Description("Please select Subject .")]
        PleaseSelectSubject = 145,
        [Description("Please select Level .")]
        PleaseSelectLevel = 146,
        [Description("Please select User Profile .")]
        PleaseSelectUserprofile = 147,
        [Description("Please select  grievance level .")]
        PleaseSelectgrievancelevel = 148,
        [Description("Please select current status .")]
        PleaseSelectcurrentstatus = 149,
        [Description("Please select available acton .")]
        PleaseSelectavailableaction = 150,
        [Description("Please select meeting date .")]
        PleaseSelectMeetingDate = 151,
        [Description("Please select location level .")]
        PleaseSelectLocationLevel = 152,
        [Description("Please select district .")]
        PleaseSelectDistrict = 153,
        [Description("Please select title .")]
        PleaseSelectTitle = 154,
        [Description("Please select start date .")]
        PleaseSelectStartDate = 155,
        [Description("Please select end date .")]
        PleaseSelectEndDate = 156,
        [Description("Please select panel .")]
        PleaseSelectPanel = 157,
        [Description("Please select panel name hindi .")]
        PleaseSelectPanelNameHindi = 158,
        [Description("Please select officer name .")]
        PleaseSelectOfficerName = 159,
        [Description("Please select country name .")]
        PleaseSelectCountryName = 160,
        [Description("Please select country name regional .")]
        PleaseSelectCountryNameRegional = 161,
        [Description("Please select state name.")]
        PleaseSelectStateName = 161,
        [Description("Please select state name regional .")]
        PleaseSelectStateNameRegional = 162,
        [Description("Please select location type name.")]
        PleaseSelectExtendedLocationTypeName = 163,
        [Description("Please select location type name regional .")]
        PleaseSelectExtendedLocationTypeRegionalName = 164,
        [Description("Please select role name .")]
        PleaseSelectRoleName = 165,
        [Description("Please select role name hindi.")]
        PleaseSelectRoleNameHindi = 166,
        [Description("Please select dept type name .")]
        PleaseSelectDeptTypeName = 167,
        [Description("Department and Parent Department can not be same.")]
        PleaseSelectParentDeptId = 168,
        [Description("please enter reference type.")]
        PleaseSelectRefType = 169,
        [Description("please Select description.")]
        PleaseSelectDescription = 170,
        [Description("please enter description in regional.")]
        PleaseSelectDescriptionInRegional = 171,
        [Description("please select version .")]
        PleaseSelectVersion = 172,
        [Description("please select publish date .")]
        PleaseSelectPublishDate = 173,
        [Description("please select validity date .")]
        PleaseSelectValiditydate = 174,
        [Description("Please select location type name.")]
        PleaseSelectExtendedLocationName = 175,
        [Description("Please select location  name regional .")]
        PleaseSelectExtendedLocationRegionalName = 176,
        [Description("Please select department type name.")]
        PleaseSelectDepartmentTypeName = 177,
        [Description("Please Select Valid Schedule Start Date Range.")]
        PleaseSelectValidScheduleStartDateRange = 178,
        [Description("Please Select Valid Schedule End Date Range.")]
        PleaseSelectValidScheduleEndDateRange = 179,
        [Description("Tour Already Planned Between These Date Range.")]
        TourAlreadyPlanned = 180,
        [Description("Start Date should be greater than end date.")]
        StartDateGreaterThenEndDate = 181,
        [Description("Invalid tour dates.")]
        InvalidTourDates = 182,
        [Description("Other Department Office First.")]
        OtherDeptOfcFirst = 183,
        [Description("Please Select Main Purpose of Tour.")]
        PleaseSelectMainPurposeOfTour = 184,
        [Description("Please Select Valid Inspection Start Date.")]
        PleaseSelectValidInspectionStartDate = 185,
        [Description("Please Select Valid Inspection End Date.")]
        PleaseSelectValidInspectionEndDate = 186,
        [Description("Please enter name of service request role, not more than 100 Characters.")]
        NotAccedMoreThen100Above = 187,
        [Description("Please enter the name of the project is less than 250 Characters.")]
        PleaseEnterProjectName250Characters = 188,
        [Description("Please enter the hindi name of the project is less than 350 Characters.")]
        PleaseEnterProjectHindiName350Characters = 189,
        [Description("Please enter the name of the project scheme is less than 250 Characters.")]
        PleaseEnterProjectSchemeName250Characters = 190,
        [Description("Please enter the hindi name of the project scheme is less than 350 Characters.")]
        PleaseEnterProjectSchemeHindiName350Characters = 191,
        [Description("Scheme is not mapped with the selected project.")]
        SchemeIsNotMappedWithSelectedProject = 192,
        [Description("Service request role record updated successfully.")]
        SRRoleRecordUpdatedSuccessfully = 200,
        [Description("Service request role add successfully.")]
        SRRoleRecordAddSuccessfully = 201,
        [Description("Service request project record updated successfully.")]
        SRProjectRecordUpdatedSuccessfully = 202,
        [Description("Service request project add successfully.")]
        SRProjectRecordAddSuccessfully = 203,
        [Description("Service request project team record updated successfully.")]
        SRProjectTeamRecordUpdatedSuccessfully = 204,
        [Description("Service request project team add successfully.")]
        SRProjectTeamRecordAddSuccessfully = 205,
        [Description("Service request scheme record updated successfully.")]
        SRSchemeRecordUpdatedSuccessfully = 206,
        [Description("Service request scheme record add successfully.")]
        SRSchemeRecordAddSuccessfully = 207,
        [Description("This office type already used in office master.")]
        ThisOfficeTypeAlreadyusedInOfficeMaster = 208,
        [Description("Api executed successfully")]
        ApiExecutedSuccessfully = 209,
        [Description("Do Not Enter Dublicate Data, Entry Already Exists. Please Select Another Start Date or District.")]
        DuplicateDataEntryAlreadyExists = 210,
        [Description("New role added successfully")]
        NewRoleaddedSuccessfully = 211,
        [Description("Role details updated successfully")]
        RoledetailsupdatedSuccessfully = 212,
        [Description("New menu added successfully")]
        NewMenuaddedSuccessfully = 213,
        [Description("Menu details updated successfully")]
        MenudetailsupdatedSuccessfully = 214,
        [Description("Country added successfully")]
        Countryaddedsuccessfully = 215,
        [Description("Country updated successfully")]
        Countryupdatedsuccessfully = 216,
        [Description("State added successfully")]
        Stateaddedsuccessfully = 217,
        [Description("State updated successfully")]
        Stateupdatedsuccessfully = 218,
        [Description("Delegate added successfully")]
        Delegateaddedsuccessfully = 221,
        [Description("Delegate updated successfully")]
        Delegateupdatedsuccessfully = 222,
        [Description("Grievance allocation added successfully")]
        GrievanceAllocationaddedsuccessfully = 223,
        [Description("Grievance allocation updated successfully")]
        GrievanceAllocationupdatedsuccessfully = 224,
        [Description("Grievance allocation deleted successfully")]
        GrievanceAllocationdeletedsuccessfully = 225,
        [Description("Grievance action flow  added successfully")]
        GrievanceActionFlowaddedsuccessfully = 226,
        [Description("Grievance action flow  updated successfully")]
        GrievanceActionFlowupdatedsuccessfully = 227,
        [Description("Grievance action flow  deleted successfully")]
        GrievanceActionFlowdeletedsuccessfully = 228,
        [Description("Minister master  added successfully")]
        MinisterMasteraddedsuccessfully = 229,
        [Description("Minister master  updated successfully")]
        MinisterMasterupdatedsuccessfully = 230,
        [Description("Minister master  deleted successfully")]
        MinisterMasterdeletedsuccessfully = 231,
        [Description("Jansunwai added successfully")]
        Jansunwaiaddedsuccessfully = 232,
        [Description("Jansunwai updated successfully")]
        Jansunwaiupdatedsuccessfully = 233,
        [Description("Jansunwai deleted successfully")]
        Jansunwaideletedsuccessfully = 234,
        [Description("Document updated successfully")]
        Documentaddedsuccessfully = 235,
        [Description("Document added successfully")]
        Documentupdatedsuccessfully = 236,
        [Description("Slno mapping deleted successfully")]
        SlnoMappingdeletedsuccessfully = 237,
        [Description("Slno mapping updated successfully")]
        SlnoMappingaddedsuccessfully = 238,
        [Description("Slno mapping added successfully")]
        SlnoMappingupdatedsuccessfully = 239,
        [Description("New Post Assignee added successfully in Panel List.")]
        Paneladdedsuccessfully = 240,
        [Description("Post Assignee details updated successfully in Panel List.")]
        Panelupdatedsuccessfully = 241,
        [Description("Record activated successfully.")]
        RecordActivatedSuccessfully = 242,
        [Description("Record deactivated successfully.")]
        RecordInActivatedSuccessfully = 243,
        [Description("Section added successfully")]
        Sectionaddedsuccessfully = 244,
        [Description("Section updated successfully")]
        Sectionupdatedsuccessfully = 245,
        [Description("Citizen Profile already submitted")]
        CitizenProfileAlreadySubmitted = 246,
        [Description("EForm already submitted")]
        EFormAlreadySubmitted = 247,
        [Description("Document already submitted")]
        DocumentAlreadySubmitted = 248,
        [Description("Status history not found")]
        ApplicationTransactionIdNotGenerated = 249,
        [Description("Application deleted successfully.")]
        ApplicationDeletedSuccessfully = 250,
        [Description("Draft applications can only be deleted.")]
        DraftApplicationCanBeDeleteOnly = 251,
        [Description("This grievance not found registered with your mobile no")]
        NotVerifiedPrevGrievanceWithMobileNumber = 252,
        [Description("OTP is verified")]
        OTPIsVerified = 253,
        [Description("Offices data not found")]
        OfficesDataNotFound = 254,
        [Description("Some technical issue while getting Profile Registration number")]
        SomeTechnicalIssueOnProfileRegistrationNumber = 255,
        [Description("Subject Master Record Saved Successfully.")]
        SubjectMasterSaveSuccessfully = 256,
        [Description("Subject Master Record Update Successfully.")]
        SubjectMasterUpdateSuccessfully = 257,
        [Description("Project and parent Project can not be same.")]
        ProjectAndParentProjectCanNotBeSame = 258,
        [Description("Project Master Record Save Successfully.")]
        ProjectMasterRecordSaveSuccessfully = 259,
        [Description("Project Master Record Update Successfully.")]
        ProjectMasterRecordUpdateSuccessfully = 260,
        [Description("Project Master Record Delete Successfully.")]
        ProjectMasterRecordDeleteSuccessfully = 261,
        [Description("Please Enter Authority Name.")]
        PleaseEnterAuthorityName = 262,
        [Description("Please Enter Authority Name Regional.")]
        PleaseEnterAuthorityNameRegional = 263,
        [Description("Please Select Originating Authority Type.")]
        PleaseSelectOriginatingAuthorityType = 264,
        [Description("Originating Authority record updated successfully.")]
        OriginatingAuthorityUpdateSuccessfully = 265,
        [Description("Originating Authority record add successfully.")]
        OriginatingAuthorityAddSuccessfully = 266,
        [Description("Please Enter Valid Mobile Number.")]
        PleaseEnterValidMobileNumber = 267,
        [Description("Please Select Assistance.")]
        PleaseSelectAssistance = 268,
        [Description("Grievance Complaint Request Record Add Successfully.")]
        GrievanceComplaintRequestAddSuccessfully = 269,
        [Description("Grievance Complaint Request Record Update Successfully.")]
        GrievanceComplaintRequestUpdateSuccessfully = 270,
        [Description("Please Enter Complainant Name.")]
        PleaseEnterComplainantName = 271,
        [Description("Please Select Gender.")]
        PleaseSelectGender = 272,
        [Description("Please Enter Father Name.")]
        PleaseEnterFatherName = 273,
        [Description("Please Select Rural Urban.")]
        PleaseSelectRuralUrban = 274,
        [Description("Please Select City.")]
        PleaseSelectCity = 275,
        [Description("Please Select Ward.")]
        PleaseSelectWard = 276,
        [Description("Please Select Panchayat Samiti.")]
        PleaseSelectPanchayatSamiti = 277,
        [Description("Please Select Gram Panchayat.")]
        PleaseSelectGramPanchayat = 278,
        [Description("Please Select Village.")]
        PleaseSelectVillage = 279,
        [Description("Citizen Information Record Add Successfully.")]
        CitizenInformationRecordAddSuccessfully = 280,
        [Description("Citizen Information Record Update Successfully.")]
        CitizenInformationRecordUpdateSuccessfully = 281,
        [Description("Please Enter Relief Required.")]
        PleaseEnterReliefRequired = 282,
        [Description("Please Enter Grievance Galary.")]
        PleaseEnterGrievanceGalary = 283,
        [Description("Please Enter Grievance Issue.")]
        PleaseEnterGrievanceIssue = 284,
        [Description("Grievance Detail New Record Add Successfully.")]
        GrienvanceDetailNewRecordAddSuccessfully = 285,
        [Description("Grievance Detail New Record Update Successfully.")]
        GrienvanceDetailNewRecordUpdateSuccessfully = 286,
        [Description("Please Select Grivance Area.")]
        PleaseSelectGrivanceArea = 287,
        [Description("Please Select Disposal Level.")]
        PleaseSelectDisposalLevel = 288,
        [Description("Grievance Area New Record Add Successfully.")]
        GrienvanceAreaNewRecordAddSuccessfully = 289,
        [Description("Grievance Area New Record Update Successfully.")]
        GrienvanceAreaNewRecordUpdateSuccessfully = 290,
        [Description("Please Select Event From Date.")]
        PleaseSelectEventFromDate = 291,
        [Description("Please Select Event To Date.")]
        PleaseSelectEventToDate = 292,
        [Description("Grievance Event New Record Add Successfully.")]
        GrienvanceEventNewRecordAddSuccessfully = 293,
        [Description("Grievance Event New Record Update Successfully.")]
        GrienvanceEventNewRecordUpdateSuccessfully = 294,
        [Description("Cannot Add More Then Five Grievance Request.")]
        CannotAddMoreThenFiveGrievanceRequest = 295,
        [Description("Please Fill Satisfaction Rating.")]
        PleaseFillSatisfactionRating = 296,
        [Description("Please Enter Grievance Id.")]
        PleaseEnterGrievanceId = 297,
        [Description("Feedback Description can not be left blank.")]
        FeedbackDescriptionCanNotBeLeftBlank = 298,
        [Description("Reason Description can not be left blank.")]
        ReasonDescriptionCanNotBeLeftBlank = 299,
        [Description("You have already sent reopen request on this grievance.")]
        YouHaveAlreadySentReopenForRequestOnThisGrievance = 300,
        [Description("Your Feedback already has been submitted With Request. So the New feedback can be submitted after grievance disposed.")]
        YourFeedbackAlreadyHasBeenSubmitted = 301,
        [Description("Feedback New Record Add Successfully.")]
        FeedbackNewRecordAddSuccessfully = 302,
        [Description("Feedback New Record Update Successfully.")]
        FeedbackNewRecordUpdateSuccessfully = 303,
        [Description("Suggestion Description can not be left blank.")]
        SuggestionDescriptionCanNotBeLeftBlank = 304,
        [Description("Suggestions New Record Add Successfully.")]
        SuggestionsNewRecordAddSuccessfully = 305,
        [Description("Suggestions New Record Update Successfully.")]
        SuggestionsNewRecordUpdateSuccessfully = 306,
        [Description("You have already sent a reminder for this grievance. You can send a reminder only after.")]
        AlreadySentAReminderForGrievance = 307,
        [Description("Comp Reminder New Record Add Successfully.")]
        CompReminderNewRecordAddSuccessfully = 308,
        [Description("Comp Reminder New Record Update Successfully.")]
        CompReminderNewRecordUpdateSuccessfully = 309,
        [Description("Please Select Event Type.")]
        PleaseSelectEventType = 310,
        [Description("Please Enter Event Name.")]
        PleaseEnterEventName = 311,
        [Description("Please Enter From Date.")]
        PleaseEnterFromDate = 312,
        [Description("Please Enter To Date.")]
        PleaseEnterToDate = 313,
        [Description("Please Enter To Description.")]
        PleaseEnterToDescription = 314,
        [Description("Event Master New Record Add Successfully.")]
        EventMasterNewRecordAddSuccessfully = 315,
        [Description("Event Master New Record Update Successfully.")]
        EventMasterNewRecordUpdateSuccessfully = 316,
        [Description("Grienvance Update Successfully.")]
        GrienvanceUpdateSuccessfully = 317,
        [Description("No Complain Found.")]
        NoComplainFound = 318,
        [Description("No Documemnt Found.")]
        NoDocumentFound = 319,
        [Description("Invalid Parameter.")]
        InvalidParameter = 320,
        [Description("Originating Authority record deleted successfully.")]
        OriginatingAuthorityDeletedSuccessfully = 321,
        [Description("Service Request Processing Rights New record saved successfully.")]
        ServiceRequestProcessingRightsNewRecordSavedSuccessfully = 322,
        [Description("Service Request Processing Rights record Update successfully.")]
        ServiceRequestProcessingRightsRecordUpdateSuccessfully = 323,
        [Description("Service Request Processing Rights record Delete successfully.")]
        ServiceRequestProcessingRightsRecordDeleteSuccessfully = 324,
        [Description("Selected record(s) deleted successfully.")]
        RoleRecordDeletedSuccessfully = 325,
        [Description("ExtendedLocationType Record Update Successfully.")]
        ExtendedLocationTypeUpdateSuccessfully = 326,
        [Description("ExtendedLocationType Record Added Successfully.")]
        ExtendedLocationTypeAddedSuccessfully = 327,
        [Description("CitizenGroup Record Added Successfully.")]
        CitizenGroupAddedSuccessfully = 328,
        [Description("CitizenGroup Record Update Successfully.")]
        CitizenGroupUpdateSuccessfully = 329,
        [Description("Please Enter DeptTypeName.")]
        PleaseEnterDeptTypeName = 330,
        [Description("Department updated Successfully")]
        Departmentupdatedsuccessfully = 331,
        [Description("Department Added Successfully")]
        DepartmentAddedsuccessfully = 332,
        [Description("Please select extended loc name .")]
        PleaseSelectExtendedLocName = 333,
        [Description("Please select extended loc name hindi  name.")]
        PleaseSelectExtendedLocNameHindi = 334,
        [Description("Department type updated Successfully")]
        DepartmentTypeupdatedsuccessfully = 335,
        [Description("Department Type Added Successfully")]
        DepartmentTypeAddedsuccessfully = 336,
        [Description("Subject Master Record Delete Successfully.")]
        SubjectMasterRecordDeleteSuccessfully = 337,
        [Description("Complain Master Sub Ex. Info. New Record Add Successfully.")]
        ComplainMasterSubExInfoNewRecordAddSuccessfully = 338,
        [Description("Complain Master Sub Ex. Info. New Record Update Successfully.")]
        ComplainMasterSubExInfoNewRecordUpdateSuccessfully = 339,
        [Description("Complain Master New Record Add Successfully.")]
        ComplainMasterNewRecordAddSuccessfully = 340,
        [Description("Complain Master New Record Update Successfully.")]
        ComplainMasterNewRecordUpdateSuccessfully = 341,
        [Description("Please enter complainant name.")]
        PleaseEnterComplaintName = 342,
        [Description("Please enter grievance area.")]
        PleaseEnterGrievanceArea = 343,
        [Description("You cannot take action on this complaint.")]
        Youcannottakeactiononthiscomplaint = 344,
        [Description("Mapped User not found")]
        MappedUserNotFound = 345,
        [Description("Subject Designation Configuration New Record Add Successfully.")]
        SubjectDesgConfgNewRecordAddSuccessfully = 346,
        [Description("Subject Designation Configuration Record Update Successfully.")]
        SubjectDesgConfgNewRecordUpdateSuccessfully = 347,
        [Description("Subject Designation Configuration Record Delete Successfully.")]
        SubjectDesgConfgNewRecordDeleteSuccessfully = 348,
        [Description("Department is not Provided.")]
        DepartmentisnotProvided = 349,
        [Description("Please enter Duration.")]
        PleaseenterDuration = 350,
        [Description("Please Select Duration Type.")]
        PleaseSelectDurationType = 351,
        [Description("Selected Duration Type is not valid.")]
        SelectedDurationTypeisnotvalid = 352,
        [Description("Subject Time Limit New Record Add Successfully.")]
        SubjectTimeLimitNewRecordAddSuccessfully = 353,
        [Description("Subject Time Limit Record Update Successfully.")]
        SubjectTimeLimitRecordUpdateSuccessfully = 354,
        [Description("Subject Time Limit Record Delete Successfully.")]
        SubjectTimeLimitRecordDeleteSuccessfully = 355,
        [Description("Role is not selected.")]
        RoleIsNotSelected = 356,
        [Description("Role Level Mapping New Record Add Successfully.")]
        RoleLevelMappingNewRecordAddSuccessfully = 357,
        [Description("Role Level Mapping Record Update Successfully.")]
        RoleLevelMappingRecordUpdateSuccessfully = 358,
        [Description("Role Level Mapping Record Delete Successfully.")]
        RoleLevelMappingRecordDeleteSuccessfully = 359,
        [Description("Grivance Exists with this mapping. So you can not delete it.")]
        GrivanceExistswiththismapping = 360,
        [Description("Notice Board Added Successfully")]
        NoticeBoardAddedsuccessfully = 361,
        [Description("Notice Board updated Successfully")]
        NoticeBoardupdatedsuccessfully = 362,
        [Description("Notice Board  deleted successfully")]
        NoticeBoarddeletedsuccessfully = 363,
        [Description("Parent Project is required")]
        ParentProjectIsRequired = 364,
        [Description("Application E-Form data resubmitted successfully")]
        ApplicationEFormDataResubmittedSuccessfully = 365,
        [Description("Application E-Form not resubmitted")]
        ApplicationEFormNotResubmitted = 366,
        [Description("E-Form Header Id not found")]
        EFormHeaderIdNotFound = 367,
        [Description("Project Scheme Status Is Changed successfully.")]
        ProjectSchemeStatusChangedSuccessfully = 368,
        [Description("Project Status Is Changed successfully.")]
        ProjectStatusIsChangedSuccessfully = 369,
        [Description("Service Request Role Status Changed successfully.")]
        ServiceRequestRoleStatusChangedSuccessfully = 370,
        [Description("Grievance generated successfully against service delivery failure.")]
        GrievanceGeneratedSuccessfully = 371,
        [Description("No Scheme/Service found for Grievance.")]
        NoServiceFoundForGrievance = 372,
        [Description("First change the scheme nodal officer, after that you have to remove this officer.")]
        Firstchangetheschemenodalofficer = 373,
        [Description("Reference Already Exist.")]
        ReferenceExist = 374,
        [Description("Please Configure Grievance Type in Subject.")]
        PleaseConfigureGrvType = 375,
        [Description("User already exists for following Role and Section -")]
        UserExistFor = 376,
        [Description("Email does not exists.")]
        Emaildoesnotexists = 377,
        [Description("Name does not exists.")]
        Namedoesnotexists = 378,
        [Description("MobileNo does not exists.")]
        MobileNodoesnotexists = 379,
        [Description("Enter SSOId.")]
        EnterSsoId = 380,
        [Description("Selected Officer Is Already Configure With Selected Role And Project.")]
        OfficerRecordAlreadyExists = 381,
        [Description("Name cannot be empty.")]
        Namecannotbeempty = 382,
        [Description("Service mapping not exists.")]
        ServiceMappingNotExists = 383,
        [Description("User have area mapping.")]
        Userhaveareamapping = 384,
        [Description("Please enter form JSON")]
        PleaseEnterFormJSON = 385,
        [Description("Project Name Already Exist")]
        ProjectNameAlreadyExist = 386,
        [Description("Project Name Hindi Already Exist")]
        ProjectNameHindiAlreadyExist = 387,
        [Description("Service Reqeust Role Already Exist")]
        ServiceReqeustRoleAlreadyExist = 388,
        [Description("Service Reqeust Role Hindi Already Exist")]
        ServiceReqeustRoleHindiAlreadyExist = 389,
        [Description("Please Enter Subject Name First.")]
        PleaseEnterSubjectName = 390,
        [Description("Please Enter Subject Name In Hindi First.")]
        PleaseEnterSubjectNameHindi = 391,
        [Description("Please select marital status")]
        PleaseSelectMaritalStatus = 392,
        [Description("Please enter current address")]
        PleaseEnterCurrentAddress = 393,
        [Description("Please enter permanent address")]
        PleaseEnterPermanentAddress = 394,
        [Description("E-Mitra Merchant Token not generated")]
        EMitraMerchantTokenNotGenerated = 395,
        [Description("Gender data not found")]
        GenderDataNotFound = 396,
        [Description("Category data not found")]
        CategoryDataNotFound = 397,
        [Description("Marital Status data not found")]
        MaritalStatusDataNotFound = 398,
        [Description("Service Request Assigned Successfully.")]
        SRAssignedSuccessfully = 399,
        [Description("Service Request Not Assigned Yet.")]
        SRNotAssignedYet = 400,
        [Description("E-Form data not saved.")]
        EFormDataNotSaved = 401,
        [Description("Already have an user for this role in same Department.")]
        RecordAlreadyExistForSameRole = 402,
        [Description("Application not submitted due to technical issues... Please try again in some time.")]
        TechnicalIssueApplicationNotSubmitted = 403,
        [Description("Please select atleast one grievance record.")]
        Pleaseselectatleastonegrievancerecord = 404,
        [Description("User exist on same section ")]
        UserExistForSameSection = 405,
        [Description("eJanSunwai cancelled successfully.")]
        CancelEjanSunwai = 406,
        [Description("You can't cancel the eJanSunwai schedule within 24 hours before the meeting starts.")]
        CanNotCancelEjanSunwai = 407,
        [Description(" Name already exist.")]
        NameAlreadyExists = 408,
        [Description(" Name Hindi already exist.")]
        NameHindiAlreadyExists = 409,
        [Description("Another User exist for this role")]
        UserExistforThisRole = 410,
        [Description("Please Select Faq Question")]
        PleaseSelectFaqQuestion = 411,
        [Description("Please Select Faq Questio nHindi")]
        PleaseSelectFaqQuestionHindi = 412,
        [Description("Please select department  name.")]
        PleaseSelectDepartmentName = 413,
        [Description("Please select department  name Hindi.")]
        PleaseSelectDepartmentNameRegional = 414,
        [Description("You cannot create a ejansunwai meeting within 24 hours.")]
        EjansunwaiBefore = 415,
        [Description("You cannot select a time period longer than 4 hours.")]
        EjansunwaiMaxDuration = 416,
        [Description("You cannot select more than 50 grievances.")]
        EjansunwaiMaxGrievance = 417,
        [Description("Unable to create the Webex meeting. Please check the meeting details and try again.")]
        WebexMeetingError = 418,
        [Description("Please Enter Title.")]
        eJansunwaiTitleEnter = 419,
        [Description("Please enter title is less than 128 Characters.")]
        eJansunwaiTitle128Characters = 420,
        [Description("Please select time duration")]
        eJansunwaiDurationSelect = 421,
        [Description("Please select Date and Time.")]
        eJansunwaiDateNTimeSelect = 422,
        [Description("Please enter agenda is less than 1000 Characters.")]
        eJansunwaiAgendaLength = 423,
        [Description("Please select RoleId Or UserId")]
        PleaseSelectRoleOrUserId = 424,
        [Description("WebEx Merchant Token not generated")]
        WebExTokenError = 425,
        [Description("Record not updated")]
        RecordNotUpdated = 426,
        [Description("Record Active Status Updated")]
        RecordActiveStatusUpdated = 427,
        [Description("Invalid URL! Please enter a valid URL.")]
        InvalidWebExUrl = 428,
        [Description("Please Enter conclusion.")]
        eJansunwaiConclusionEnter = 429,
        [Description("Please enter conclusion is less than 2000 Characters.")]
        eJansunwaiConclusionCharacters = 430,
        [Description("eJansunwai created successfully.")]
        eJansunwaiCreate = 431,
        [Description("eJansunwai canceled successfully.")]
        eJansunwaiCancel = 432,
        [Description("eJansunwai rescheduled successfully.")]
        eJansunwaiReschedule = 433,
        [Description("cache key removed.")]
        CacheKeyRemoved = 434,
        [Description("please send cache key.")]
        CacheKeyMissing = 435,
        [Description("Service Request Submit For Clarification Successfully!")]
        ServiceRequestSubmitForClarificationSuccessfully = 436,
        [Description("Already applied for this service")]
        AlreadyAppliedForThisService = 437,
        [Description("Please select from date")]
        PleaseSelectFromDate = 438,
        [Description("Please select to date")]
        PleaseSelectToDate = 439,
        [Description("Please select token data")]
        PleaseSelectTokenData = 440,
        [Description("OverWrite Mapping saved successfully")]
        OverWriteMappingsavedsuccessfully = 441,
        [Description("Group Mapping edited successfully")]
        GroupMappingeditedsuccessfully = 442,
        [Description("Downgrade Mapping saved successfully")]
        DowngradeMappingsavedsuccessfully = 443,
        [Description("Application Number not generated")]
        ApplicationNumberNotGenerated = 444,
        [Description("Please select api identification key")]
        PleaseSelectApiIdentificationKey = 445,
        [Description("Category not found")]
        CategoryNotFound = 445,
        [Description("Please Enter DeptTypeNameHindi.")]
        PleaseEnterDeptTypeNameHindi = 446,
        [Description("Department and Parent Department can not be same.")]
        DepartmentAndParentDepartmentCanNotBeSame = 447,
        [Description("Please Enter Citizen Group Name.")]
        PleaseSelectCitizenGroupName = 448,
        [Description("Please Enter Citizen Group Name Regional.")]
        PleaseSelectCitizenGroupNameRegional = 449,
        [Description("Please select atleast district.")]
        TourPleaseselectatleastdistrict = 450,
        [Description("User event type is mandatory.")]
        TourUsereventtypeismandatory = 451,
        [Description("User type is mandatory.")]
        TourUsertypeismandatory = 452,
        [Description("Tour annexure type is invalid or empty.")]
        Tourannexuretypeisinvalidorempty = 453,
        [Description("The license name and clientId  already exist.")]
        WebexLicenseAndClientIdAlreadyExist = 454,
        [Description("This license name already exists with another client ID.")]
        WebexLicenseNameAlreadyExist = 455,
        [Description("This clientId already exists with another license name.")]
        WebexClientIdAlreadyExist = 456,
        [Description("The Webex license has been successfully mapped to the e-Jansunwai process.")]
        WebexLicenseSuccessfullyMapped = 457,
        [Description("Please select at least one user for license mapping.")]
        WebexLicenseUserSelect = 458,
        [Description("Campaign updated successfully.")]
        CampaignUpdatedSuccessfully = 459,
        [Description("Campaign added successfully.")]
        CampaignAddedSuccessfully = 460,
        [Description("There is some dependancy to delete")]
        ThereIsSomeDependancyToDelete = 461,
        [Description("Please enter survey name")]
        pleaseEnterSurveyName = 462,
        [Description("Survey added successfully")]
        SurveyAddedSuccessfully = 463,
        [Description("Survey updated successfully")]
        SurveyUpdatedSuccessfully = 464,
        [Description("Please select atleast one Survey")]
        pleaseSelectOneSurvey = 465,
        [Description("Something went wrong")]
        someThingWentWrong = 465,
        [Description("No data found for the provided survey.")]
        noDataFoundForTheProvidedSurvey = 465,
        [Description("Already approved.")]
        alreadyApproved = 466,
        [Description("Survey set to not approved")]
        surveySetToNotApproved = 467,
        [Description("Survey approved successfully")]
        surveyApprovedSuccessfully = 468,
        [Description("No records deleted.")]
        noRecordDeleted = 469,
        [Description("Question set updated in survey")]
        questionSetUpdatedInSurvey = 470,
        [Description("Please enter question set name")]
        pleaseEnterQuestionSetName = 471,
        [Description("Please enter welcome text")]
        pleaseEnterWelcometext = 472,
        [Description("Please enter thanks text")]
        pleaseEnterThankstext = 473,
        [Description("Please select survey lanaguge")]
        pleaseSelectsurveyLanguage = 474,
        [Description("Please select department")]
        pleaseSelectsurveyDept = 475,
        [Description("Question set updated successfully")]
        questionSetUpdatedSuccessfully = 476,
        [Description("Question set added successfully")]
        questionSetAddedSuccessfully = 477,
        [Description("Question set not found.")]
        questionsetNotFound = 478,
        [Description("Question set details retrieved successfully.")]
        questionSetdetailsretrieved = 479,
        [Description("Subjective question updated successfully")]
        subjectivequestionupdated = 480,
        [Description("Subjective question added successfully")]
        subjectivequestionadded = 481,
        [Description("Objective question added successfully")]
        objectivequestionadded = 482,
        [Description("MixMode question added successfully")]
        mixModequestionadded = 483,
        [Description("Sample size should be less then")]
        sampleSizeLessThen = 484,
        [Description("Sample size can't exceed Searched records.")]
        sampleSizeCantexeed = 485,
        [Description("Please select Record Number Or Record Percent")]
        pleaseSelectRecordNoOrRecordPer = 486,
        [Description("Sample added successfully")]
        sampleAddedSuccessfully = 487,
        [Description("Sample updated successfully")]
        sampleUpdatedSuccessfully = 488,
        [Description("Sample added to survey successfully")]
        sampleAddedToSurveySuccess = 489,
        [Description("General master updated successfully")]
        generalMasterupdate = 490,
        [Description("General master added successfully")]
        generalMasteradd = 491,
        [Description("Citizen updated successfully.")]
        citizenUpdated = 492,
        [Description("Failed to update citizen.")]
        failedToUpdateCitizen = 493,
        [Description("Citizen not found.")]
        citizenNotFound = 494,
        [Description("Citizen and sample mapping added successfully.")]
        citizenandmappingadded = 495,
        [Description("Failed to add sample mapping.")]
        failedtoAddSampleMapping = 496,
        [Description("Failed to add citizen.")]
        failedToaddcitizen = 497,
        [Description("Citizen and sample mapping updated successfully.")]
        citizenandmappingupdated = 495,
        [Description("Suggestion New Record added Successfully.")]
        SuggestionNewRecordSaved = 496,
        [Description("Validity date should be greater than or equal to Publish Date.")]
        ValidityDateShouldBeGreatertThanOrEqualToPublishDate = 497,
        [Description("HghtStartDate date should be greater than or equal to HghtEndDate.")]
        HghtStartDateShouldBeGreatertThanOrEqualToHghtEndDate = 498,
        [Description("Channels added sucessfully")]
        surveyModesAddedSuccessfully = 499,
        [Description("Survey scheduled sucessfully")]
        surveySchedulesSucessFully = 500,
        [Description("Action has been taken successfully.")] ActionSuccess = 501,
        [Description("There is no officer available in the concerned department/subject/field.")] NoOfficerAvailable = 502,
        [Description("No Duplicate action allowed.")] NoDuplicate = 503,
        [Description("No action allowed")] NoActionAllowed = 504,
        [Description("Error occured while taking action")] ErrorInAction = 505,
        [Description("This grievance is not transferable")] NotTransferable = 506,
        [Description("User active successfully.")]
        UserActiveSuccessfully = 507,
        [Description("User already active.")]
        UserAlReadyActive = 508,
        [Description("User already Inactive")]
        UserAlReadyInActive = 509,
        [Description("Please select year")]
        PleaseSelectFinYear = 510,
        [Description("Target allready added")]
        TourTragetAllReadyAdded = 511,
        [Description("Target updated sucessfully")]
        TourTragetUpdated = 512,
        [Description("Target added sucessfully")]
        TourTragetAdded = 513,
        [Description("Target copied sucessfully")]
        TourTragetCopied = 514,
        [Description("Please select survey modes")]
        pleaseselectsurveymodes = 515,
        [Description("Enter Intimation Before Hours & Minutes..")]
        enterIntimation = 516,
        [Description("Select survey start date time..")]
        selectsurveystartdatetime = 517,
        [Description("Survey end time must be greater than survey start time..")]
        Surveyendtimemustbegreaterthansurveystarttime = 518,
        [Description("Please enter campaign name")]
        pleaseEnterCampaignName = 519,
        [Description("Please select atleast one question")]
        pleaseSelectAtleastOneQuestion = 520,
        [Description("Modes are not present survey")]
        modesarenotpresentinsurvey = 521,
        [Description("Please select atleast one sample")]
        pleaseSelectAtleastOneSample = 522,
        [Description("Minimum Interval b/w 2 Attempts required in ")]
        minimumintervalintwointerval = 523,
        [Description("End date should be greater than current date-time")]
        enddatemustgreaterthancurrentdate = 524,
        [Description("Sewadwaar Token not generated")]
        SewadwaarTokenNotGenerated = 525,
        [Description("Record Copied successfully.")]
        RecordCopiedSuccessfully = 526,
        [Description("Please enter valid Application No.")]
        PleaseEnterValidApplicationNo = 527,
        [Description("Mobile number not found")]
        MobileNumberNotFound = 528,
        [Description("Grievance ID must be at least 10 digits long")]
        GrievanceIDTen = 529,
        [Description("Grievance reopened successfully.")]
        GrievanceReopenedSuccessfully = 669,
        [Description("Grievance reopened failed.")]
        GrievanceReopenedFailed = 670,
        [Description("Please select menu.")]
        PleaseSelectMenu = 671,
        [Description("No records found for the provided criteria.")]
        NoRecordFoundForProvidedCriteria = 672,
        [Description("Role already assigned to user, can not delete.")]
        RoleAlreadyAssignedToUserCanNotDelete = 673,
        [Description("Mapping already exists with this subject.")]
        MappingAlreadyExistsWithThisSubject = 674,
        [Description("The Webex license has been successfully updated to the e-Jansunwai process.")]
        WebexLicenseSuccessfullyupdated = 676,
        [Description("WebEx license not generated.")]
        WebExLicenseNotGenerated = 677,
        [Description("Disposed Sr Feedback Rating Update Successfully.")]
        DisposedSrFeedbackRatingUpdateSuccessfully = 678,
        [Description("User already mapped in this license.")]
        WebExLicenseUserAlreadyMappedInLicense = 708,
        [Description("User(s) added successfully in this license.")]
        WebExLicenseUserAddedSuccessfully = 709,
        [Description("Selected user inactive successfully.")]
        WebExLicenseUserInactiveSuccessfully = 710,
        [Description("Selected license active successfully.")]
        WebExLicenseactiveSuccessfully = 713,
        [Description("Selected license inactive successfully.")]
        WebExLicenseInactiveSuccessfully = 712,
        [Description("User active successfully.")]
        WebExLicenseUseractiveSuccessfully = 711,
        [Description("WebEx license deleted successfully.")]
        WebExLicenseDeletedSucessfully = 729,
        [Description("WebEx license user deleted successfully.")]
        WebExLicenseUserDeletedSuccessfully = 728,
        [Description("Please Enter Feedback 150 Characters Only.")]
        PleaseEnterFeedback150CharactersOnly = 712,
        [Description("Extended Information is not available")]
		ExtendedInformationNotAvailable = 730,
		[Description("Extended Location is not available")]
		ExtendedLocationNotAvailable = 731,
        [Description("Role and Parent Role can not be same.")]
        PleaseSelectParentRoleId = 732,
        [Description("Please enter valid grievance number.")]
        EnterValidGrievanceNo = 733,
        [Description("Old password is incorrect.")]
        OldPasswordIsIncorrect = 734,
        [Description("New password does not meet the policy requirements.")]
        PasswordNotMeetPolicyReq = 735,
        [Description("Password changed successfully.")]
        PasswordChangedSuccess = 736,
        [Description("Password reset successfully.")]
        PasswordResetSuccess = 737,


    }

    public enum WeekDaysName
    {
        [Description("Monday")]
        Monday = 1,
        [Description("Tuesday")]
        Tuesday = 2,
        [Description("Wednesday")]
        Wednesday = 3,
        [Description("Thursday")]
        Thursday = 4,
        [Description("Friday")]
        Friday = 5,
        [Description("Saturday")]
        Saturday = 6,
        [Description("Sunday")]
        Sunday = 7
    }
    public enum Datatype
    {
        [Description("AlphaNumeric")]
        AlphaNumeric = 1,
        [Description("Number")]
        Number = 2,
        [Description("Date")]
        Date = 3,
        [Description("Date(Less Than)")]
        DateLessThan = 4,
        [Description("Date(Greater Than)")]
        DateGreaterThan = 5,
        [Description("Date (Range)")]
        DateRange = 6,
        [Description("Number(Less Than)")]
        NumberLessThan = 7,
        [Description("Number (Greater Than)")]
        NumberGreaterThan = 8,
        [Description("Number (Range)")]
        NumberRange = 9,
        [Description("String")]
        String = 10,

    }
    public enum NumbersInWord
    {
        [Description("All")]
        Zero = 0,
        [Description("First")]
        One = 1,
        [Description("Second")]
        Two = 2,
        [Description("Third")]
        Three = 3,
        [Description("Fourth")]
        Four = 4,
        [Description("Fifth")]
        Five = 5,
        [Description("Sixth")]
        Six = 6,
        [Description("Seventh")]
        Seven = 7,
        [Description("Eighth")]
        Eight = 8,
        [Description("Nineth")]
        Nine = 9,
        [Description("Tenth")]
        Ten = 10,
    }
    public enum DBName
    {
        [Description("DB2")]
        DB2 = 1,
        [Description("Oracle")]
        ORCL = 2,
        [Description("My Sql")]
        MYSQL = 3,
        [Description("Microsoft SQL Server")]
        MSSQL = 4
    }
    public enum CommonDbType
    {
        Boolean,
        DateTime,
        Date,
        Time,
        Decimal,
        Double,
        Int16,
        Int32,
        Int64,
        VarChar,
        Char,
        Object,
    }
    public enum ConversionType
    {
        [Description("None")] None = 0,
        [Description("Indian Rupees")] IndianRupees = 1,
        [Description("Month Name")] MonthName = 2,
        [Description("Percentage")] Percentage = 3
    }
    public enum TransactionType
    {
        [Description("Sale")]
        Sale = 58,
        [Description("Distribution")]
        Distribution = 59,
        [Description("PrivateSale")]
        PrivateSale = 60
    }
    public enum CustomerType
    {
        [Description("Citizen (Mobile Holder)")]
        Citizen = 51,
        [Description("Pension Diary Holder")]
        PensionDiaryHolder = 52,
        [Description("RGHS Card Holder")]
        RGHSCardHolder = 53,
        [Description("Janaadhar Holder")]
        JanaadharHolder = 54,
        [Description("Aadhar Holder")]
        AadharHolder = 55,
        [Description("Distributor Dept")]
        DistributorDept = 56,
        [Description("Beneficiary")]
        Beneficiary = 57,
        [Description("Department Sale")]
        DepartmentSale = 61
    }
    public enum PaymentTerms
    {
        [Description("Payment by Customer")]
        PaymentbyCustomer = 1,
        [Description("Wallet Deduction")]
        WalletDeduction = 2,
        [Description("Exempted/Free")]
        ExemptedFree = 3
    }
    public enum DeliveryConfirmationMethod
    {
        [Description("RequiredthroughOTP")]
        RequiredthroughOTP = 1,
        [Description("NotRequired")]
        NotRequired = 2
    }
    public enum APIType
    {
        [Description("Fetch Customer Details")]
        FetchCustomerDetails = 1,
        [Description("Update Transactison Details")]
        UpdateTransactisonDetails = 2
    }
    public enum APIIdentificationKey
    {
        [Description("RGHS Card Number")]
        RGHSCardNumber = 1,
        [Description("RGHS Transaction Number")]
        RGHSTransactionNumber = 2,
        [Description("RGHS Janadhar Number")]
        RGHSJanadharNumber = 3,
        [Description("Pentioner Diary")]
        PentionerDiary = 4,
        [Description("Janadhar Number")]
        JanadharNumber = 7,
        [Description("Adhaar Number")]
        AdhaarNumber = 8
    }
    public enum APIIdKey
    {
        [Description("E-Mitra Gender List")]
        GetEmGenderDList = 1,
        [Description("E-Mitra Category List")]
        GetEmCategoryDList = 2,
        [Description("E-Mitra MaritalStatus List")]
        GetEmMaritalStatusDList = 3,
        [Description("E-Mitra Country List")]
        GetEmCountryDList = 4,
        [Description("E-Mitra State List")]
        GetEmStateDList = 5,
        [Description("E-Mitra Division List")]
        GetEmDivisionDList = 6,
        [Description("E-Mitra District List")]
        GetEmDistrictDList = 7,
        [Description("E-Mitra Tehsil List")]
        GetEmTehsilDList = 8,
        [Description("E-Mitra Municipality List")]
        GetEmMunicipalityDList = 9,
        [Description("E-Mitra Ward List")]
        GetEmWardDList = 10,
        [Description("E-Mitra Panchayat Samiti List")]
        GetEmPanchayatSamitiDList = 11,
        [Description("E-Mitra Gram Panchayat List")]
        GetEmGramPanchayatDList = 12,
        [Description("E-Mitra Village List")]
        GetEmVillageDList = 13,
        [Description("E-Mitra Enclosure List")]
        GetEnclosureList = 14,
        [Description("E-Mitra Enclosure Metadata List")]
        GetEnclosureMetadataList = 15,
        [Description("E-Mitra Profile Submit")]
        ProfileSubmitToEMitra = 16,
        [Description("E-Mitra E-Form Submit")]
        EFormSubmitToEMitra = 17,
        [Description("E-Mitra Document Submit")]
        UploadDocumentToEMitra = 18,
        [Description("Application Submit")]
        ApplicationSubmitToEMitra = 19,
        [Description("GetOut_Broad_Voice_Call")]
        GetOutBroadVoiceCall = 20,
        [Description("GetOut_Trans_Voice_Call")]
        GetOutTransVoiceCall = 21,
        [Description("E-Mitra Service Workflow History List")]
        GetEmServiceWorkflowHistory = 22,
        [Description("Service Application Preview JSON")]
        GetServiceApplicationPreviewJSON = 23,
        [Description("EForm Mapping for Submit to E-Mitra")]
        EFormMappingForSubmitToEMitra = 24,
        [Description("Get Encrypt Data")]
        GetEmEncryptData = 25,
        [Description("Get Decrypt Data")]
        GetEmDecryptData = 26,
        [Description("Get Checksum Data")]
        GetEmChecksumData = 27,
        [Description("E-Mitra Office List")]
        GetEmOfficeDList = 28,
        [Description("E-Mitra Merchant Token")]
        GetEmMerchantToken = 29,
        [Description("E-Mitra Token Workflow List")]
        GetEmTokenWorkflowList = 30,
        [Description("E-Mitra E-Form Dynamic JSON")]
        SECONDFORM = 31,
        [Description("E-Mitra E-Form Dynamic JSON on Edit Mode")]
        EDITSECONDFORM = 32,
        [Description("EForm Mapping for Re-Submit to E-Mitra")]
        EFormMappingForResubmitToEMitra = 33,
        [Description("E-Mitra E-Form Re-Submit")]
        EFormReSubmitToEMitra = 34,
        [Description("E-Mitra Caste List")]
        GetEmCasteDList = 35,
        [Description("E-Mitra Sub Caste List")]
        GetEmSubCasteDList = 36,
        [Description("E-Mitra Religion List")]
        GetEmReligionDList = 37,
        [Description("E-Mitra Common List")]
        GetEmCommonDList = 38,
        [Description("E-Mitra Income Year")]
        GetEmIncomeYear = 39,
        [Description("E-Mitra Download Application")]
        GetEmDownloadApplication = 40,
        [Description("E-Mitra Gender List New")]
        GetEmGenderDListNew = 41,
        [Description("E-Mitra Category List")]
        GetEmCategoryDListNew = 42,
        [Description("E-Mitra MaritalStatus List")]
        GetEmMaritalStatusDListNew = 43,
        [Description("E-Mitra Resolution No By Caste Id")]
        GetEmResolutionNo = 44,
        [Description("E-Mitra Eligibility Applied Token List")]
        GetEmEligibility = 45,
        [Description("E-Mitra Services Token Wise Detail")]
        GetEmServicesTokenWiseDetail = 46,
        [Description("E-Mitra Get Application All")]
        DashboardApplication = 47,
        [Description("E-Mitra Get Application Workflow All")]
        DashboardApplicationWorkflow = 48,
        [Description("Sewadwaar Token Key")]
        GetSewadwaarToken = 50,
        [Description("Sewadwaar Document Verification")]
        GetSewadwaarOnlineDocVerify = 51,
        [Description("E-Mitra Merchant Token PROD")]
        GetEmMerchantTokenPROD = 52,
        [Description("E-Mitra Service Workflow History List PROD")]
        GetEmServiceWorkflowHistoryPROD = 53,
        [Description("E-Mitra All Rajasthan District")]
        GetEmAllRajasthanDistrictDList = 54,
        [Description("E-Mitra VidhanSabha By District Id")]
        GetEmVidhanSabhaByDistrictIdDList = 55,
        [Description("E-Mitra Bank Detail By IFSC")]
        GetEmBankDetailByIFSC = 56

    }

    public enum EMitraMasterRefType
    {
        [Description("Gender")]
        Gender = 1,
        [Description("Category")]
        Category = 2,
        [Description("MaritalStatus")]
        MaritalStatus = 3
    }

    public enum EmApplicationPhases
    {
        [Description("Citizen Profie Submission")]
        CitizenProfieSubmit = 1,
        [Description("E-Form Submission")]
        EFormSubmit = 2,
        [Description("Application Document Submission")]
        DocumentSubmit = 3,
        [Description("Application Destination Office Submission")]
        DestinationOfficeSubmit = 4,
        [Description("Application Submission")]
        ApplicationSubmission = 5,
        [Description("Application Submission Encrypted Data")]
        ApplicationSubmissionDecryptedData = 6,
        [Description("E-Form Resubmission")]
        EFormResubmit = 7,
    }
    public enum ApplicationAction
    {
        [Description("Edit")]
        Edit = 1,
        [Description("Delete")]
        Delete = 2,
        [Description("Preview")]
        Preview = 3,
        [Description("ReSubmit")]
        ReSubmit = 4,
        [Description("Print")]
        PrintApplication = 5
    }

    public enum EmCitizenAddressType
    {
        [Description("CURRENT")]
        CURRENT = 1,
        [Description("PERMANENT")]
        PERMANENT = 2
    }


    public enum ConstitutionType
    {
        [Description("Government")]
        Government = 1,
        [Description("Private")]
        Private = 2
    }
    public enum GroupType
    {
        [Description("Regular")]
        Regular = 1,
        [Description("Consignment")]
        Consignment = 2,
        [Description("Impresset")]
        Impresset = 3,
        [Description("Other")]
        Other = 4
    }
    public enum DiscussionModuleListType
    {
        [Description("Main Menu")]
        MainMenu = 1,
        [Description("Module Items")]
        ModuleItems = 2
    }
    public enum RateType
    {
        [Description("Sale Rate")]
        SaleRate = 1,
        [Description("Cost Rate")]
        CostRate = 2,
        [Description("Trade Rate")]
        TradeRate = 3,
        [Description("Purchase Rate")]
        PurchaseRate = 4,
        [Description("MSP")]
        MSP = 5
    }
    public enum YesNoAll
    {
        [Description("All")]
        All = -1,
        [Description("Yes")]
        Yes = 1,
        [Description("No")]
        No = 0
    }
    public enum YesNo
    {
        [Description("Yes")]
        Yes = 1,
        [Description("No")]
        No = 0
    }
    public enum YesNoHindi
    {
        [Description("हाँ")]
        हाँ = 1,
        [Description("नहीं")]
        नहीं = 0
    }
    public enum ActiveInactive
    {
        //[Description("All")]
        //All = -1,
        [Description("Active")]
        Active = 1,
        [Description("Inactive")]
        Inactive = 0
    }
    public enum ActiveInactiveHindi
    {
        //[Description("सभी")]
        //सभी = -1,
        [Description("सक्रिय")]
        सक्रिय = 1,
        [Description("निष्क्रिय")]
        निष्क्रिय = 0
    }
    public enum IsVerified
    {
        [Description("All")]
        All = -1,
        [Description("Verified")]
        Verified = 1,
        [Description("Not Verified")]
        NotVerified = 0
    }
    public enum Department
    {
        [Description("DOIT")]
        DOIT = 43,
        [Description("Rajcomp Info Services Limited")]
        RISL = 209,
        [Description("RSHAA")]
        RSHAA = 389,
        [Description("Police")]
        DeptPolice = 67
    }
    public enum DepartmentHindi
    {
        [Description("सूचना प्रौद्योगिकी एवं संचार विभाग")]
        सूचनाप्रौद्योगिकीएवंसंचारविभाग = 43,
        [Description("राजकॉम्प इन्फो सर्विसेज लिमिटेड")]
        राजकॉम्पइन्फोसर्विसेजलिमिटेड = 209
    }

    public enum LocationTypes : int
    {
        [Description("Panchayat")]
        Panchayat = 4,
        [Description("City")]
        City = 1,
        [Description("Division")]
        Division = 9,
        [Description("Extended Level")]
        ExtendedLevel = 10,
        [Description("Gp")]
        Gp = 5,
        [Description("State")]
        State = 7,
        [Description("Village")]
        Village = 6,
        [Description("Ward")]
        Ward = 2,
        [Description("District")]
        Zone = 8
    }
    public enum LocationTypesRegional
    {
        [Description("पंचायत")]
        पंचायत = 4,
        [Description("शहर")]
        शहर = 1,
        [Description("संभाग")]
        संभाग = 9,
        [Description("विस्तारित स्तर")]
        विस्तारितस्तर = 10,
        [Description("ग्राम पंचायत")]
        ग्रामपंचायत = 5,
        [Description("राज्य")]
        राज्य = 7,
        [Description("गाँव")]
        गाँव = 6,
        [Description("वार्ड")]
        वार्ड = 2,
        [Description("जिला")]
        जिला = 8
    }

    public enum GrvncLocationTypes : int
    {
        [Description("Panchayat")]
        Panchayat = 4,
        [Description("City")]
        City = 1,
        [Description("Gp")]
        Gp = 5,
        [Description("Village")]
        Village = 6,
        [Description("Ward")]
        Ward = 2
    }
    public enum LocationTypeStateDivisionDistrict : int
    {
        [Description("State")]
        State = 7,
        [Description("Division")]
        Division = 9,
        [Description("District")]
        Zone = 8

    }
    public enum Events
    {
        [Description("record saved successfully.")]
        NewRecordSavedSuccessfully = 1,
        [Description("record updated successfully.")]
        RecordUpdatedSuccessfully = 2,
        [Description("record(s) deleted successfully.")]
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
        [Description("record cannot be deleted.")]
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
        [Description("record already exist.")]
        RecordAlreadyExist = 18,
        [Description("record found.")]
        RecordFound = 19
    }
    public enum Masters
    {
        [Description("Department")]
        Department = 1,
        [Description("Section")]
        Section = 2,
        [Description("Office")]
        Office = 3,
        [Description("Office Type")]
        OfficeType = 4,
        [Description("Role")]
        Role = 5,
        [Description("UserType")]
        UserType = 6,
        [Description("Designation")]
        Designation = 7,
        [Description("Project")]
        Project = 8,
        [Description("Category")]
        Category = 9,
        [Description("Village")]
        Village = 10,
        [Description("GramPanchayat")]
        GramPanchayat = 11,
        [Description("Block")]
        Block = 12,
        [Description("DepartmentType")]
        DepartmentType = 13,
        [Description("LocationType")]
        LocationType = 14,
        [Description("Service Request Category")]
        ServiceRequestCategory = 15,
        [Description("Service Project Master")]
        ServiceProjectMaster = 16,
        [Description("Service Request Processing Rights")]
        ServiceRequestProcessingRights = 17,
        [Description("Common")]
        Common = 18,
        [Description("MapDemap")]
        MapDemap = 19,
        [Description("Delegate")]
        Delegate = 20,

        [Description("Jansunwai")]
        Jansunwai = 21,
        [Description("Document")]
        Document = 22,
        [Description("Panel")]
        Panel = 23,
        [Description("SNLO")]
        SNLO = 24,
        [Description("Country")]
        Country = 25,
        [Description("State")]
        State = 26,

        [Description("Location")]
        Location = 27,
        [Description("ExtendedLocationType")]
        ExtendedLocationType = 28,
        [Description("MenuObjects")]
        MenuObjects = 29,
        [Description("Menu Rights")]
        MenuRightsObjects = 30,
        [Description("GeneralMaster")]
        GeneralMaster = 31,
        [Description("Release Note")]
        ReleaseNote = 32,
        [Description("Notice Bulletin")]
        NoticeBulletin = 33,
        [Description("ITOfficers")]
        ITOfficers = 34,
        [Description("Subject Master")]
        SubjectMaster = 35,
        [Description("Profile Mapping")]
        ProfileMapping = 36,
        [Description("PG")]
        PG = 37,
        [Description("Originating Authority")]
        OriginatingAuthority = 38,
        [Description("Grievance Instruction")]
        GrievanceInstruction = 39,
        [Description("Grievance Status")]
        GrievanceStatus = 40,
        [Description("Grievance Complaint Master.")]
        GrievanceComplaintMaster = 41,
        [Description("Grievance Search")]
        GrievanceSearch = 42,
        [Description("Grievance Disposal")]
        GrievanceDisposal = 43,
        [Description("Action Mapping With Level")]
        ActionMappingWithLevel = 44,
        [Description("Action Integrated History")]
        ActionIntegratedHistory = 45,
        [Description("Grievance Conversation History")]
        GrievanceConversationHistory = 46,
        [Description("Disposal Type")]
        DisposalType = 47,
        [Description("Grievance Detail")]
        GrievanceDetail = 48,
        [Description("User Profile")]
        UserProfile = 49,
        [Description("Params")]
        Params = 50,
        [Description("Available Action")]
        AvailableAction = 51,
        [Description("Complain Category")]
        ComplainCategory = 52,
        [Description("Complain Category All")]
        ComplainCategoryAll = 53,
        [Description("Complain Sub Category")]
        ComplainSubCategory = 54,
        [Description("Police Station")]
        PoliceStation = 55,
        [Description("Constituency Area")]
        ConstituencyArea = 56,
        [Description("Event Type Master")]
        EventTypeMaster = 57,
        [Description("Event Master")]
        EventMaster = 58,
        [Description("Grievance Recieve Mode")]
        GrievanceRecieveMode = 59,
        [Description("Office / Authority Name")]
        OfficeAuthorityName = 60,
        [Description("OfficeAuthority Type Name")]
        OfficeAuthorityTypeName = 61,
        [Description("User Level")]
        UserLevel = 62,
        [Description("Grienvance Level")]
        GrienvanceLevel = 63,
        [Description("Grienvance Status")]
        GrienvanceStatus = 64,
        [Description("Officer")]
        Officer = 65,
        [Description("SRPriority")]
        SRPriority = 66,
        [Description("SRCategory")]
        SRCategory = 67,
        [Description("Disposal Category")]
        DisposalCategory = 68,
        [Description("SRProject")]
        SRProject = 69,
        [Description("Service Request Inbox Outbox List")]
        ServiceRequestInboxOutboxList = 70,
        [Description("SR Input Output With Filters")]
        SRInputOutputWithFilters = 71,
        [Description("Project Summary")]
        ProjectSummary = 72,
        [Description("Project Summary With Status Filter")]
        ProjectSummaryWithStatusFilter = 73,
        [Description("Project Team Detail")]
        ProjectTeamDetail = 74,
        [Description("Service Project Configuration")]
        ServiceProjectConfiguration = 75,
        [Description("Service Project Registration")]
        ServiceRequestRegistration = 76,
        [Description("Service Request Role Master")]
        ServiceRequestRoleMaster = 77,
        [Description("SR Total Count With Filters")]
        SRTotalCountWithFilters = 78,
        [Description("Grievance Complaint Ids By MobNo")]
        GrievComplaintIdsByMobNo = 79,
        [Description("Project Master")]
        ProjectMaster = 80,
        [Description("Service Contact Details")]
        ServiceContactDetails = 81,
        [Description("Service Request Details By Id And SrNumber")]
        SRDetailsByIdAndSrNumber = 82,

        [Description("Mapping Officer")]
        MappingOfficer = 83,
        [Description("Grievance Disposal Top Panels")]
        GrievanceDisposalTopPanels = 84,
        [Description("Grievance Process")]
        GrievanceProcess = 85,
        [Description("Disposal Detail")]
        DisposalDetail = 86,
        [Description("Subject Master All")]
        SubjectMasterAll = 87,
        [Description("Grievance Action Flow")]
        GrievanceActionFlow = 88,
        [Description("Event")]
        Event = 89,
        [Description("Subject Configuration Designation Report")]
        SubDesgConfgReport = 90,
        [Description("Subject Configuration Designation Report By SubjectId")]
        SubDesgConfgReportBySubId = 91,
        [Description("Subject Time Limit")]
        SubjectTimeLimit = 92,
        [Description("Department Role Level Mapping List")]
        DeptRoleLvlMapList = 93,
        [Description("Mapping Detail")]
        MappingDetail = 94,
        [Description("Mapping Grouping Detail")]
        MappingGroupingDetail = 95,
        [Description("Mapping History")]
        MappingHistory = 96,
        [Description("Over Writing Mapping History")]
        OverWritingMappingHistory = 97,
        [Description("CitizenGroup")]
        CitizenGroup = 98,
        [Description("Accountability")]
        Accountability = 99,
        [Description("Demographic")]
        Demographic = 100,
        [Description("Division")]
        Division = 101,
        [Description("District")]
        District = 102,
        [Description("Designation Hierarchy")]
        DesignationHierarchy = 103,
        [Description("Extended Location")]
        ExtendedLocation = 104,
        [Description("Demographic Hierarchy ward")]
        DemographicHierarchyward = 105,
        [Description("Demographic Hierarchy")]
        DemographicHierarchy = 106,
        [Description("Hierarchy Location")]
        HierarchyLocation = 107,
        [Description("Department Hierachy")]
        DepartmentHierachy = 108,
        [Description("User Directory")]
        UserDirectory = 109,
        [Description("Citizen")]
        Citizen = 110,
        [Description("CoverPage")]
        CoverPage = 111,
        [Description("Discussion Module")]
        DiscussionModule = 112,
        [Description("Gallery Album")]
        GalleryAlbum = 113,
        [Description("Gallery Content")]
        GalleryContent = 114,
        [Description("Grievance Source")]
        GrievanceSource = 115,
        [Description("Map Location")]
        MapLocation = 116,
        [Description("Slno Mapping")]
        SlnoMapping = 117,
        [Description("MP MLA")]
        MPMLA = 118,
        [Description("Zone")]
        Zone = 119,
        [Description("Minister Master")]
        MinisterMaster = 120,
        [Description("Ideas Innovations")]
        IdeasInnovations = 121,
        [Description("Ideas Innovations Rating")]
        InnovationsRating = 122,
        [Description("Average Innovations Rating")]
        AvgInnovationsRating = 123,
        [Description("Already Rated Innovations")]
        RatedInnovations = 124,
        [Description("Menu Objects Type")]
        MenuObjectsType = 125,
        [Description("Request Monitoring")]
        RequestMonitoring = 126,
        [Description("Registered Citizen details")]
        RegisteredCitizendetails = 127,
        [Description("MapDemap Detail")]
        MapDemapDetail = 128,
        [Description("Manage User")]
        ManageUser1 = 129,
        [Description("User Detail")]
        UserDetail = 130,
        [Description("Ideas Innovations Master")]
        InnovationsMaster = 131,
        [Description("Release Note Detail")]
        ReleaseNoteDetail = 132,
        [Description("Reports")]
        Reports = 133,
        [Description("Scheme/Service")]
        SchemeService = 134,
        [Description("ServiceMapping")]
        ServiceMapping = 135,
        [Description("Dashboard")]
        Dashboard = 136,
        [Description("Grievance Complaint Request")]
        GrievanceComplaint = 137,
        [Description("Event API")]
        EventApi = 138,
        [Description("Master Configuration")]
        MasterConfiguration = 139,
        [Description("Notification Event")]
        NotificationEvent = 140,
        [Description("Notification Templates")]
        NotificationMsg = 141,
        [Description("Notification Transaction")]
        NotificationTR = 142,
        [Description("Grievance Allocation")]
        GrievanceAllocation = 143,
        [Description("Mapping")]
        Mapping = 144,
        [Description("Notification Scheduler")]
        NotificationSch = 145,
        [Description("Notification Scheduler History")]
        NotificationHis = 146,
        [Description("Scheme Category")]
        SchemeCategory = 147,
        [Description("User Office")]
        UserOffice = 148,
        [Description("User Department")]
        UserDepartment = 149,
        [Description("Faq Master")]
        FaqMaster = 150,
        [Description("Scheme Service Application")]
        SchemeServiceApplication = 151,
        [Description("Advance Search GRVNC")]
        AdvanceSearchGRVNC = 152,
        [Description("RoleUserWiseMenuPrivilege")]
        Role_UserWiseMenuPrivilege = 153,
        [Description("GrievanceStatusList")]
        GrievanceStatusList = 154,
        [Description("RegistrationGrvncList")]
        RegistrationGrvncList = 155,
        [Description("TokenTransaction")]
        TokenTransaction = 156,
        [Description("Api Confriguration")]
        ApiConfriguration = 157,
        [Description("RealityCheck")]
        RealityCheck = 158,
    }
    public enum SchemeType
    {
        [Description("Service")]
        Service = 1,
        [Description("Scheme")]
        Scheme = 2
    }
    public enum PrivilegesAction
    {
        [Description("ALL")] ALL = -1,
        [Description("Add")] Add = 1,
        [Description("Edit")] Edit = 2,
        [Description("Delete")] Delete = 3,
        [Description("View")] View = 4,
        [Description("Transfer")] Transfer = 5,
        [Description("OverwriteMapping")] OverwriteMapping = 6,
        [Description("OverwriteMappingList")] OverwriteMappingList = 7,
        [Description("DowngradeMapping")] DowngradeMapping = 8,
        [Description("MappingHistory")] MappingHistory = 9,
        [Description("GroupEdit")] GroupEdit = 10
    }

    public enum ParamsRefType
    {
        EVENT_BY_POST,
        COVID_SYMPTOMS,
        UID_TYPE,
        GENDER,
        GRIEVANCETYPE,
        GRV_DISPOSAL_LVL,
        ORG_AUTH_ID,
        RECEIVED_UNDER,
        GRV_AGE,
        CALL_CENTER_WHATAPP_DURATION,
        WHATSAPP_DOWNLOAD_MEDIA,
        WHATSAPP_DOC_HOURS,
        NODAL_OFFICER_HOME_PAGE,
        DOITC_OFFICER_HOME_PAGE,
        GRVNC_REDRESSAL_OFFICER_HOME_PAGE,
        WHATAPP_TEXT_GRIEVANCE,
        WHATAPP_TEXT_SERVICE,
        VOICE_BOT_CONVERSATION
    }
    public enum CFGGeneralMasterRefType
    {
        ServiceCategoryTag,
        SchemeServiceType,
        AvailableActions,
        EMitraServicesDepartment,
        EMitraServices,
        ApplicationStatus,
        ActionLinkCaption,
        LanguageType,
        EMitraScanForm,
        EMitraTehsilValidation

    }

    public enum CFGGeneralConfigRefType
    {
        ApplicationStatusColour,
        ApplicationStatusBorderColour,
        ApplicationStatusDescription,
        PhotoUploadId,
        NewRegistrationNumber,
        JanaadharOTPValidFor,
        CheckServiceAlreadyApplied,
        TokenExpireMinutes,
        TokenExpireSeconds,
        ApplicationStatusColourDashboard,
        ApplicationStatusBorderColourDashboard,
        EMitraGetApplicationFromDate,
        EMitraGetApplicationToDate,
        AutoGrievanceStartDateSampark,
        AutoGrievanceStartDateEMitra,
        EMitraBaseURL,
        EMitraDownloadCertificateBaseURL,
        DashboardDataFromProduction,
        IsPreviousSchedulerRunning,
        EMitraGetApplicationTodayDate,
        IsSendToCallCenterLast2Days,
        IsDocumentMetaDataAlwaysInText
    }

    public enum DefaultTokenExpiredMinutes
    {
        [Description("ExpiredInMinutes")]
        ExpiredInMinutes = 25,
    }

    public enum LanguageType
    {
        [Description("Regional")]
        Regional = 1,
    }

    #region Notification Enums
    public enum ReminderType
    {
        [Description("Do Not Repeat")]
        doNotRepeat = 1,
        [Description("Daily")]
        Daily = 2,
        [Description("Weekly")]
        Weekly = 3,
        [Description("Monthly")]
        Monthly = 4,
        [Description("Yearly")]
        Yearly = 5
    }
    public enum ScheduleStatus
    {
        [Description("Planned")]
        Planned = 1,
        [Description("Executed")]
        Executed = 2,
        [Description("Cancelled")]
        Cancelled = 3
    }
    public enum ReminderTypeInterval
    {

        [Description("Day")]
        Day = 2,
        [Description("Week")]
        Week = 3,
        [Description("Month")]
        Month = 4,
        [Description("Year")]
        Year = 5
    }
    public enum ScheduleType
    {
        [Description("Scheduling")]
        scheduling = 1,
        [Description("Bulk")]
        bulk = 2

    }
    public enum SMSServiceType
    {
        [Description("singlemsg")]
        singlemsg = 1,
        [Description("bulkmsg")]
        bulkmsg = 2,
        [Description("unicodemsg")]
        unicodemsg = 3,
        [Description("otpmsg")]
        otpmsg = 4,
        [Description("unicodeotpmsg")]
        unicodeotpmsg = 5
    }
    public enum TemplatePriority
    {
        [Description("High")]
        High = 1,
        [Description("Medium")]
        Medium = 2,
        [Description("Low")]
        Low = 3
    }
    public enum TemplatePriorityHindi
    {
        [Description("उच्च")]
        उच्च = 1,
        [Description("मध्यम")]
        मध्यम = 2,
        [Description(" निम्न")]
        निम्न = 3
    }
    public enum TemplateType
    {
        [Description("Promotional")]
        Promotional = 1,
        [Description("Transactional")]
        Transactional = 2
    }
    public enum TemplateTypeHindi
    {
        [Description("प्रोमोशनल")]
        प्रोमोशनल = 1,
        [Description("ट्रांज़ेक्शनल")]
        ट्रांज़ेक्शनल = 2
    }

    public enum NotificationStatus
    {
        [Description("Seen")]
        Seen = 1,
        [Description("Unseen")]
        Unseen = 2,
        [Description("Successful")]//Sent
        Successful = 3,
        [Description("Failed")]
        Failed = 4

    }
    public enum ModeType
    {
        [Description("SMS")]
        SMS = 1,
        [Description("Email")]
        Email = 2,
        [Description("WhatsApp")]
        WhatsApp = 3,
        [Description("VoiceCall")]
        VoiceCall = 9,
    }
    public enum WhatsAppMediaType
    {
        [Description("template")]
        template = 1,
        [Description("text")]
        text = 2,
        [Description("image")]
        image = 3,
        [Description("video")]
        video = 4,
        [Description("audio")]
        audio = 5,
        [Description("document")]
        document = 6,
        [Description("contact")]
        contact = 7,
        [Description("location")]
        location = 8,
        [Description("sticker")]
        sticker = 9,
        [Description("interactive")]
        interactive = 10,

    }

    #endregion

    public enum FileType
    {
        [Description("Photographs")]
        Photographs = 1,
        [Description("PPT")]
        PPT = 2,
        [Description("WriteUp")]
        WriteUp = 3
    }

    public enum IdeasInnovationsType
    {
        [Description("Persons To be Benefitted")]
        PersonsToBeBenefitted = 1,
        [Description("Nature Of Innovation")]
        NatureOfInnovation = 2,
        [Description("Requirements")]
        Requirements = 3,
        [Description("Status")]
        Status = 4,
        [Description("Any Award")]
        AnyAward = 5,
        [Description("Idea")]
        Idea = 6,
        [Description("Idea evolved or implemented")]
        IdeaEvolvedOrImplemented = 7,
        [Description("Area Category")]
        AreaCategory = 8
    }

    public enum RequestMonitoringStatus
    {
        [Description("Closed")]
        Closed = 0,
        [Description("Pending")]
        Pending = 1,
        [Description("Approved")]
        Approved = 2,
        [Description("All")]
        All = -1


    }

    public enum RequestMonitoringStatusHindi
    {
        [Description("बंद")]
        बंद = 0,
        [Description("लंबित")]
        लंबित = 1,
        [Description("अनुमत")]
        अनुमत = 2,
        [Description("सभी")]
        सभी = -1
    }

    public enum OfficeDetailsMapUnmap
    {
        [Description("ReMap")]
        ReMap = 1,
        [Description("UnMap")]
        UnMap = 2
    }

    public enum Activity
    {
        [Description("FollowUp")]
        FollowUp = 1,
        [Description("Review")]
        Review = 2,
        [Description("State View")]
        State_View = 3,
        [Description("Verify On Call")]
        Verify_On_Call = 4,
        [Description("Edit Complainants Detail After Moderation")]
        EditComplainantsDetailAfterModeration = 5,
        [Description("Edit Grievance Area Detail After Moderation")]
        EditGrievanceAreaDetailAfterModeration = 6,
        [Description("Edit Grievance Detail After Moderation")]
        EditGrievanceDetailAfterModeration = 7,
        [Description("Edit Receive Mode Detail After Moderation")]
        EditReceiveModeDetailAfterModeration = 8,
        [Description("Edit Registration Detail After Moderation")]
        EditRegistrationDetailAfterModeration = 9,
        [Description("Edit Complainants Detail Before Moderation")]
        EditComplainantsDetailBeforeModeration = 10,
        [Description("Edit Grievance Area Detail Before Moderation")]
        EditGrievanceAreaDetailBeforeModeration = 11,
        [Description("Edit Grievance Detail Before Moderation")]
        EditGrievanceDetailBeforeModeration = 12,
        [Description("Edit Receive Mode Detail Before Moderation")]
        EditReceiveModeDetailBeforeModeration = 13,
        [Description("Edit Registration Detail Before Moderation")]
        EditRegistrationDetailBeforeModeration = 14,
        [Description("Register")]
        Registered = 15,
        [Description("Assign")]
        Assigned = 16,
        [Description("Reject")]
        Rejected = 17,
        [Description("Request On Hold")]
        OnHold = 18,
        [Description("PullBack")]
        PullBack = 19,
        [Description("Send Sms")]
        SendSms = 20,
        [Description("Returned")]
        Returned = 21,
        [Description("UnHold")]
        UnHold = 22,
        [Description("PG Portal Comments")]
        PGComments = 23,
        [Description("Marked For VC")]
        MarkedForVC = 24,
        [Description("DownGrade and Delete")]
        DownGradeandDelete = 45,
        [Description("CallCenterAdmin")]
        CallCenterAdmin = 181,
        [Description("AudioRight")]
        AudioRight = 188,
        [Description("PGPortal")]
        PGPortal = 189,
        [Description("SrUnivSearch")]
        SrUnivSearch = 190,
        [Description("Supervisor")]
        Supervisor = 191,
        [Description("CMORopen")]
        CMORopen = 192,
        [Description("DelegateProfile")]
        DelegateProfile = 193,
        [Description("PGD")]
        PGD = 194,
        [Description("NFSA")]
        NFSA = 195,
        [Description("Police Grievance")]
        PoliceGrievance = 196,
        [Description("Grievance Transfer RPG")]
        GrievanceTransferRPG = 197
    }

    public enum LocationType
    {
        [Description("City/Town")]
        City = 1,
        [Description("Ward")]
        Ward = 2,
        [Description("Tehsil")]
        Tehsil = 3,
        [Description("Block/Panchayat Samiti")]
        Block = 4,
        [Description("Gram Panchayat")]
        GP = 5,
        [Description("Village")]
        Village = 6,
        [Description("State")]
        State = 7,
        [Description("Zone")]
        Zone = 8,
        [Description("Division")]
        Division = 9,
        [Description("Extended Location")]
        ExtendedLevel = 10
    }

    public enum RajMasterLocationType
    {
        [Description("City")]
        City = 3,
        [Description("Ward")]
        Ward = 4,
        [Description("Tehsil")]
        Tehsil = 62,
        [Description("Block")]
        Block = 55,
        [Description("GP")]
        GP = 58,
        [Description("Village")]
        Village = 59,
        [Description("State")]
        State = 17,
        [Description("Zone")]
        Zone = 56,
        [Description("Division")]
        Division = 57
    }
    public enum SurveyStatus
    {
        [Description("InProcess")]
        InProcess = 16,
        [Description("Completed")]
        Completed = 17,
        [Description("Paused")]
        Paused = 18,
        [Description("Stopped")]
        Stopped = 19,
        [Description("Pending")]
        Pending = 20,
        [Description("Generic")]
        Generic = 2,
        [Description("Draft")]
        Draft = 1933,
        [Description("Approved")]
        Approved = 1935,
        [Description("Reject")]
        Reject = 2141
    }
    public enum CacheKey
    {
        [Description("upm:department")]
        UPM_Department = 1,
        [Description("upm:departmenttype")]
        UPM_DepartmentType = 2,
        [Description("upm:designation")]
        UPM_Designation = 3,

    }
    public enum CacheHours
    {
        [Description("24 Hours")]
        Hours24 = 24,
        [Description("60 Minutes")]
        Minute60 = 60
    }

    public enum ServiceRequestRole
    {
        [Description("Project OIC")]
        ProjectOIC = 1,
        [Description("Processing Officer")]
        ProcessingOfficer = 2,
        [Description("HOD")]
        HOD = 3,
        [Description("Super User")]
        SuperUser = 4,
        [Description("Technical Lead")]
        TechnicalLead = 5
    }
    public enum Role
    {
        [Description("Citizen")]
        Citizen = 33,
        [Description("Block Level Nodal Officers")]
        BlockLevelNodalOfficers = 8,
        [Description("Dept State Lvl Nodal Officer")]   //SLNO User
        DeptStateLvlNodalOfficer = 10,
		[Description("Kiosks Executive")]   //KIOSK 
		KiosksExecutive = 14    
    }
    public enum LevelDropDown // level -- स्तर
    {
        [Description("At One's Own Level")]
        AtOneOwnLevel = 1,
        [Description("At Senior Level")]
        AtSeniorLevel = 2,
        [Description("At Junior Level")]
        AtJuniorLevel = 3,
        [Description("All Others (in my area of ​​work)")]
        AllOthersInMyAreaOfWork = 6,
        [Description("All other")]
        AllOthers = 4,
        [Description("Guidance/Direction")]
        Guidance_Direction = 5
    }
    public enum LevelDropDownRegional // level -- स्तर
    {
        [Description("स्वयं के स्तर पर")]
        स्वयंकेस्तरपर = 1,
        [Description("वरिष्ठ स्तर पर")]
        वरिष्ठस्तरपर = 2,
        [Description("कनिष्ठ स्तर पर")]
        कनिष्ठस्तरपर = 3,
        [Description("अन्य सभी ( मेरे कार्यक्षेत्र में)")]
        अन्यसभीमेरेकार्यक्षेत्रमें = 6,
        [Description("अन्य सभी")]
        अन्यसभी = 4,
        [Description("मार्गदर्शन/ निर्देशन")]
        मार्गदर्शन_निर्देशन = 5
    }
    public enum ProceedingDropDown // Proceeding -- कार्यवाही
    {
        [Description("All")]
        All = 1,
        [Description("Allotted")]
        Allotted = 2,
        [Description("To Forward")]
        ToForward = 3,
        [Description("Auto Forward")]
        AutoForward = 4,
        [Description("Auto Forward (Disambiguation)")]
        AutoForwardDisambiguation = 5,
        [Description("Retrial")]
        Retrial = 6,
        [Description("Reconsideration")]
        Reconsideration = 7,
        [Description("Transfer")]
        Transfer = 8,
        [Description("Proposed Relief")]
        ProposedRelief = 9,
        [Description("Proposed Relief (Remaining Confirmed By 181)")]
        ProposedReliefRemainingConfirmedBy181 = 10,
        [Description("Proposed")]
        Proposed = 11,
        [Description("Proposed Disposal (Cancelled)")]
        ProposedDisposalCancelled = 12,
        [Description("Complete Disposal (Satisfied)")]
        CompleteDisposalSatisfied = 13,
        [Description("Full Disposal(Via L4)")]
        FullDisposalViaL4 = 14,
        [Description("Complete Disposal (Unconfirmed)")]
        CompleteDisposalUnconfirmed = 15,
        [Description("Full Settlement (Not Verified Due To Wrong Number)")]
        FullSettlementNotVerifiedDueToWrongNumber = 16,
        [Description("Specific Disposal")]
        SpecificDisposal = 17,
        [Description("For guidance")]
        ForGuidance = 18,
        [Description("Guidance Requested")]
        GuidanceRequested = 19,
        [Description("Directed")]
        Directed = 20,
        [Description("Specified")]
        Specified = 21,
        [Description("Request For Retrial")]
        RequestForRetrial = 22
    }
    public enum ProceedingDropDownHindi // Proceeding -- कार्यवाही
    {
        [Description("सभी")]
        सभी = 1,
        [Description("आवंटित")]
        आवंटित = 2,
        [Description("अग्रेषित करने हेतु")]
        अग्रेषितकरनेहेतु = 3,
        [Description("स्वतः अग्रेषित")]
        स्वतःअग्रेषित = 4,
        [Description(" स्वतः अग्रेषित (असंतुष्ट)")]
        स्वतःअग्रेषितअसंतुष्ट = 5,
        [Description("पुनःकार्यवाही")]
        पुनःकार्यवाही = 6,
        [Description("पुनःविचार ")]
        पुनःविचार = 7,
        [Description("हस्तानांतरण")]
        हस्तानांतरण = 8,
        [Description("प्रस्तावित निस्तारण(राहत)")]
        प्रस्तावितनिस्तारणराहत = 9,
        [Description("प्रस्तावित निस्तारण(राहत)(181 द्वारा पुष्टि शेष)")]
        प्रस्तावितनिस्तारणराहत181द्वारापुष्टिशेष = 10,
        [Description("प्रस्तावित निस्तारण(रद्द अग्रेषित) ")]
        प्रस्तावितनिस्तारणरद्दअग्रेषित = 11,
        [Description("प्रस्तावित निस्तारण(रद्द)")]
        प्रस्तावितनिस्तारणरद्द = 12,
        [Description("पूर्ण निस्तारण (संतुष्ट)")]
        पूर्णनिस्तारणसंतुष्ट = 13,
        [Description("पूर्ण निस्तारण (L4 के द्वारा)")]
        पूर्णनिस्तारणL4केद्वारा = 14,
        [Description("पूर्ण निस्तारण( अपुष्ट)")]
        पूर्णनिस्तारणअपुष्ट = 15,
        [Description("पूर्ण निस्तारण (गलत नंबर की वजह से सत्यापित नहीं)")]
        पूर्णनिस्तारणगलतनंबरकीवजहसेसत्यापितनहीं = 16,
        [Description("विशिष्ट निस्तारण")]
        विशिष्टनिस्तारण = 17,
        [Description("मार्गदर्शन हेतु")]
        मार्गदर्शनहेतु = 18,
        [Description("मार्गदर्शन निवेदित ")]
        मार्गदर्शननिवेदित = 19,
        [Description("निर्देशित")]
        निर्देशित = 20,
        [Description("निर्दिष्ट")]
        निर्दिष्ट = 21,
        [Description("पुनः कार्यवाही हेतु अनुरोध")]
        पुनःकार्यवाहीहेतुअनुरोध = 22
    }

    public enum SessionStorageKey
    {
        [Description("Session Key")]
        SessionKey = 1
    }

    public enum ServiceRequestStatus
    {
        [Description("Registered")]
        Registered = 1,
        [Description("Pending")]
        Pending = 2,
        [Description("Forward")]
        Forward = 3,
        [Description("Disposed")]
        Disposed = 4,
        [Description("Pullback")]
        PullBack = 5,
        [Description("Transfer")]
        Transfer = 6,
        [Description("Reply")]
        Reply = 7,
        [Description("Sent for Clarification")]
        Clarification = 8,
        [Description("Assigned")]
        Assigned = 9,
        [Description("Clarification Received")]
        SendClarification = 10,
        [Description("Reopened")]
        Reopened = 11,
        [Description("Sent For Approval")]
        SentForApproval = 12
    }

    public enum Actions
    {
        [Description("Forward")]
        Forward = 1,
        [Description("Reply")]
        Reply = 2,
        [Description("Pullback")]
        PullBack = 3,
        [Description("Sent for Clarification")]
        SentForClarification = 4,
        [Description("Transfer")]
        Transfer = 5,
        [Description("Dispose")]
        Dispose = 6,
        [Description("ReOpen")]
        ReOpen = 7,
        [Description("Send Approval")]
        SendApproval = 8,
        [Description("Approval")]
        Approval = 9,
        [Description("Submit For Clarification")]
        SubmitForClarification = 10
    }

    public enum CompSourceId
    {
        [Description("Web")] WebPortal = 5,
        [Description("Email")] Email = 2,
        [Description("SMS")] SMS = 3,
        [Description("CM Office")] CMOffice = 7,
        [Description("Medical")] Medical = 11,
        [Description("Mobile Application")] MobileApplication = 57,
        [Description("Call Center Executive")] CallCenterExecutive = 93,
        [Description("Chat-Bot")] ChatBot = 128,
        [Description("WhatsApp")] WhatsApp = 129,
        [Description("Voice-Bot")] VoiceBot = 151
        
    }
    public enum CompSourceRegional
    {
        [Description("वेब")] वेबपोर्टल = 5,
        [Description("ई-मेल")] ईमेल = 2,
        [Description("SMS")] SMS = 3,
        [Description("सीएम कार्यालय")] सीएमकार्यालय = 7,
        [Description("चिकित्सा")] चिकित्सा = 11,
        [Description("मोबाइल एप्लीकेशन")] मोबाइलएप्लीकेशन = 57,
        [Description("कॉल सेंटर एग्जीक्यूटिव")] कॉलसेंटरएग्जीक्यूटिव = 93,
        [Description("चैट-बॉट")] चैटबॉट = 128,
        [Description("व्हाट्सएप्प")] व्हाट्सएप्प = 129,
        [Description("वॉइस-बोट")] वॉइसबोट = 151
        
    }


    public enum GrievanceSource
    {
        [Description("Representative")] // call center
        Representative = 1,
        [Description("Officer")]
        Officer = 2,
        [Description("Complainant")]
        Complainant = 3

    }

    public enum DraftStatus
    {
        [Description("Draft")]
        Draft = 0,
        [Description("Pending")]
        Pending = 1
    }
    public enum SurveyActionIds
    {
        [Description("Abandoned")]
        Abandoned = 19,
        [Description("Paused")]
        Paused = 18,
        [Description("Completed")]
        Completed = 17,
        [Description("Resume")]
        Resume = 20,
        [Description("Reject")]
        Reject = 1203

    }

    public enum OriginatingAuthority
    {
        [Description("Service Guarantee Act")]
        SGA = 210,
        [Description("State Human Rights Commission")]
        SHRC = 211,
        [Description("Chief Minister Office")]
        CMO = 189,
        [Description("Chief Minister Residence")]
        CMR = 190,
        [Description("Chairman of R P G committee")]
        RPG = 191,
        [Description("Chief Secretary")]
        Pending = 192,
        [Description("Divisional Commissioner")]
        DC = 193,
        [Description("General")]
        General = 194,
        [Description("Government of India")]
        GOI = 195,
        [Description("Governor House")]
        GH = 196,
        [Description("Legislative Assembly")]
        LA = 197,
        [Description("Lokayukt")]
        Lokayukt = 198,
        [Description("Member of  Legislative Assembly")]
        MLA = 199,
        [Description("Member of Parliament")]
        MP = 200,
        [Description("Minister")]
        Minister = 201,
        [Description("National Commission for SC / ST")]
        NCS = 202,
        [Description("National Commission for Women")]
        NCW = 203,
        [Description("National Human Rights Commission")]
        NHRC = 204,
        [Description("News paper cutting")]
        NPC = 205,
        [Description("Parliament House")]
        PH = 206,
        [Description("Prime Minister Office")]
        PMO = 207,
        [Description("Non Resident Rajasthanis(NRRs)")]
        NRR = 437,
        [Description("Public Grievances")]
        PG = 103,
        [Description("Departmental User")]
        DEPTUSER = 121,
        [Description("CMO WEBSITE (Grievance)")]
        CMOWebsite = 739,
        [Description("Medical Website")]
        MedicalWebsite = 740
    }
    public enum SurveyType
    {
        [Description("Specific")]
        Specific = 3,
        [Description("Generic")]
        Generic = 2
    }
    public enum CreatedBy
    {
        [Description("Created by me")]
        CreatedByMe = 1,
        [Description("Created by others")]
        CreatedByOthers = 2
    }
    public enum CreatedByHindi
    {
        [Description("मेरे द्वारा बनाया गया")]
        CreatedByMe = 1,
        [Description("अन्य के द्वारा बनाया गया")]
        CreatedByOthers = 2
    }


    public enum GrievanceDetailCompaignRequest
    {
        [Description("Submitted")]
        Submitted = 1,
        [Description("Assigned")]
        Assigned = 2,
        [Description("Closed")]
        Closed = 3,
        [Description("Grievance Register")]
        GrievanceRegister = 4,

    }
    public enum GrievanceDetailDisposalTypeId
    {
        [Description("Relief")]
        Relief = 1,
        [Description("Reject")]
        Reject = 2,
        [Description("Transfer")]
        Transfer = 3
    }
    public enum CampaignAllotmentStatus
    {
        [Description("Allotted")]
        Allotted = 1,
        [Description("CallBack")]
        CallBack = 2,
        [Description("Closed")]
        Closed = 3,
        [Description("Reject")]
        Reject = 5
    }

    public enum CCAgentActivityFixedValue
    {
        [Description("0")]
        V_TELE_SVR_ID = 1,
        [Description("0")]
        V_TELE_SVR_SESS_ID = 2,
        [Description("O")]
        V_CALLED_BY = 3,
        [Description("0")]
        V_ACTION_TYPE = 4,
        [Description("O")]
        V_CALL_TYPE = 5,
        [Description("0")]
        V_DOCUMENT_ID = 6,
        [Description("Closed By System")]
        V_REMARKS = 7

    }


    public enum ServiceCallBackLevel
    {
        [Description("ProfileSubmit")]
        ProfileSubmit = 1,
        [Description("EFormSubmit")]
        EFormSubmit = 2,
        [Description("DocumentSubmit")]
        DocumentSubmit = 3,
        [Description("OfficeDetailSubmit")]
        OfficeDetailSubmit = 4,
		[Description("Call Center (Broadcast)")]
		BroadcastSubmit = 5
	}

    public enum SLNOLevelDropDown
    {
        [Description("For Change")]
        ForChange = 1,
        [Description("Department Change")]
        DepartmentChange = 2,
        [Description("Subject Change")]
        SubjectChange = 3,
        [Description("Address Change")]
        AddressChange = 4,
        [Description("Change of Subject and Address")]
        ChangeOfSubjectAndAddress = 5,
        [Description("No Change")]
        NoChange = 6
    }
    public enum enmTimeConfigLevel
    {
        [Description("Lowest Level")]
        LowestLevel = -1,
        [Description("Level 1")]
        Level1 = 1,
        [Description("Level 2")]
        Level2 = 2,
        [Description("Level 3")]
        Level3 = 3,
        [Description("Level 4")]
        Level4 = 4
    }
    public enum enmTimeConfigLevelHindi
    {
        [Description("निम्नतम स्तर")]
        निम्नतमस्तर = -1,
        [Description("स्तर 1")]
        स्तर1 = 1,
        [Description("स्तर 2")]
        स्तर2 = 2,
        [Description("स्तर 3")]
        स्तर3 = 3,
        [Description("स्तर 4")]
        स्तर4 = 4
    }
    public enum enmAccountablityLevel
    {
        [Description("Level G")]
        Level0 = 0,
        [Description("Level 1")]
        Level1 = 1,
        [Description("Level 2")]
        Level2 = 2,
        [Description("Level 3")]
        Level3 = 3,
        [Description("Level 4")]
        Level4 = 4
    }
    public enum enmAccountablityLevelHindi
    {
        [Description("स्तर G")]
        स्तर0 = 0,
        [Description("स्तर 1")]
        स्तर1 = 1,
        [Description("स्तर 2")]
        स्तर2 = 2,
        [Description("स्तर 3")]
        स्तर3 = 3,
        [Description("स्तर 4")]
        स्तर4 = 4
    }

    public enum SLNOLevelDropDownRegional
    {
        [Description("परिवर्तन हेतु ")]
        परिवर्तनहेतु = 1,
        [Description("विभाग परिवर्तन ")]
        विभागपरिवर्तन = 2,
        [Description("विषय परिवर्तन ")]
        विषयपरिवर्तन = 3,
        [Description("पता परिवर्तन ")]
        पतापरिवर्तन = 4,
        [Description("विषय एवं पता परिवर्तन")]
        विषयएवंपतापरिवर्तन = 5,
        [Description("कोई परिवर्तन नहीं ")]
        कोईपरिवर्तननहीं = 6
    }
    public enum TimePeriodForSR
    {
        [Description("Today")]
        Today = 1,
        [Description("Yesterday")]
        Yesterday = 2,
        [Description("Weekly")]
        Weekly = 3,
        [Description("Monthly")]
        Monthly = 4,
        [Description("Yearly")]
        Yearly = 5,
        [Description("TillDate")]
        TillDate = 6,
        [Description("PreviousMonth")]
        PreviousMonth = 7
    }
    public enum ServiceRequestPriority
    {
        [Description("Normal")]
        Normal = 1,
        [Description("Urgent")]
        Urgent = 2,
        [Description("Most Urgent")]
        MostUrgent = 3
    }
    public enum ServiceRequestPriorityHindi
    {
        [Description("सामान्य")]
        सामान्य = 1,
        [Description("अति आवश्यक")]
        अतिआवश्यक = 2,
        [Description("सबसे जरूरी")]
        सबसेजरूरी = 3
    }
    public enum MapStatus
    {
        //[Description("All")]
        //All = 0,
        [Description("Mapped")]
        Mapped = 1,
        [Description("Unmapped")]
        Unmapped = 2
    }

    public enum MapStatusHindi
    {
        //[Description("सभी")]
        //सभी = 0,
        [Description("मैप किए गए")]
        मैपकिएगए = 1,
        [Description("अनमैप किया गया")]
        अनमैपकियागया = 2
    }
    public enum UserProfiles
    {
        [Description("L1")] L1 = 1,
        [Description("L2")] L2 = 2,
        [Description("L3")] L3 = 3,
        [Description("L4")] L4 = 4,
        [Description("SLNO")] SLNO = 10,
        [Description("CMO")] CMO = 6,
        [Description("CALL_CENTER")] CALL_CENTER = 7,
        [Description("EXT")] EXT = 8
    }

    public enum EntityType
    {
        [Description("GrievanceShortForm")] GrievanceShortForm = 1,
        [Description("GrievanceLongForm")] GrievanceLongForm = 2,
        [Description("BulkSchedule")] BulkSchedule = 3,
        [Description("ServiceProfilePhoto")] ServiceProfilePhoto = 4,
        [Description("Idea Innovation Form")] IdeaInnovationForm = 5,
        [Description("Document List")] DocumentList = 6,
        [Description("Notice Bulletin")] NoticeBulletin = 7,
        [Description("Bulk schedule")] Bulkschedule = 8,
        [Description("Scheme Service Master SVG Icon")] SchemeServiceMasterSVGIcon = 9,
        [Description("Service Request Registration")] ServiceRequestRegistration = 10,
        [Description("Scheme Service Master Blank Form")] SchemeServiceMasterBlankForm = 11,
        [Description("Approval Document")] ApprovalDocument = 12,
        [Description("Grievance Disposal")] GrievanceDisposal = 13,
        [Description("Scheme Service Enclosures")] SchemeServiceEnclosures = 14,
        [Description("Samadhan List")] SamadhanList = 15,
        [Description("Minister Master Profile Photo")] MinisterMasterProfilePhoto = 20,
        [Description("Scheme Category Master Image")] SchemeCategoryMasterImage = 21,
        [Description("PG DOCUMENT")] PG_DOCUMENT_BASE64 = 23,
        [Description("CAD_EvaultUploadDocument")] CAD_EvaultUploadDocument = 24,
        [Description("TOUR_SCHEDULE_ENTRY")] TOUR_SCHEDULE_ENTRY = 25,
        [Description("TOUR_INSPECTION_ENTRY")] TOUR_INSPECTION_ENTRY = 26,
        [Description("Suggestion")] Suggestion = 18,
        [Description("ServiceEFormPDF")] ServiceEFormPDF = 30,
    }

    public enum ProfileStatus
    {
        [Description("Completed")]
        Completed = 0,
        [Description("Incomplete")]
        Incomplete = 1,
        [Description("Partial Complete")]
        PartialComplete = 2
    }

    public enum ProfileDisplay
    {
        [Description("IsProfileDisplay")]
        IsProfileDisplay = 1
    }

    public enum SchemeApplicationStatus
    {
        [Description("DRAFT")]
        Drafted = 1,
        [Description("APPLICATION SUBMITTED")]
        Submitted = 2,
        [Description("Approved")]
        Approved = 3,
        [Description("Rejected")]
        Rejected = 4,
        [Description("Forwarded")]
        Forwarded = 5,
        [Description("In Progress")]
        InProgress = 6,
        [Description("SEND BACK TO CITIZENBYLEVELONE")]
        SendBackToCitizenByLevelOne = 7,
        [Description("RESUBMITTED")]
        Resubmitted = 8,
        [Description("ON HOLDBYLEVELONE")]
        OnHoldByLevelOne = 9

    }
    public enum SchemeApplicationStatusColour
    {
        [Description("Draft")]
        Blue = 1,
        [Description("APPLICATION SUBMITTED")]
        Gray = 2,
        [Description("APPLICATION APPROVED")]
        Green = 3,
        [Description("APPLICATION REJECTED")]
        Red = 4,
        [Description("Forwarded")]
        Black = 5
    }

    public enum SchemeApplicationStatusBorderColour
    {
        [Description("Draft")]
        Blue = 1,
        [Description("APPLICATION SUBMITTED")]
        Gray = 2,
        [Description("APPLICATION APPROVED")]
        Green = 3,
        [Description("APPLICATION REJECTED")]
        Red = 4,
        [Description("Forwarded")]
        Black = 5
    }


    public enum APIContentType
    {
        [Description("formurlencoded")]
        formurlencoded = 1
    }

    public enum EtDefaultCountryEng
    {
        [Description("INDIA")]
        India = 1
    }
    public enum EtDefaultCountryHin
    {
        [Description("भारत")]
        भारत = 1
    }
    public enum EtDefaultStateEng
    {
        [Description("Rajasthan")]
        Rajasthan = 1
    }
    public enum EtDefaultStateHin
    {
        [Description("राजस्थान")]
        राजस्थान = 1
    }

    public enum AccountType
    {
        [Description("Secondary")]
        Secondary = 0,
        [Description("Primary")]
        Primary = 1
    }
    public enum EMitraServices
    {
        [Description("Bonafide Certificate")]
        Bonafide = 2189,
        [Description("Caste Certificate OBC")]
        CasteCertificateOBC = 2317
    }
    public enum EMitraAutoGrievanceDefaultName
    {
        [Description("Auto generated grievance")]
        DefaultApplicantName = 1,
        [Description("स्वत: पंजीकृत परिवाद")]
        DefaultApplicantNameHindi = 2
    }
    public enum EMitraMerchantCode
    {
        [Description("SAMPARK2024")]
        SAMPARK2024 = 1
    }
    public enum EMitraHookAPIType
    {
        [Description("Call by Sewadwaar (hook api)")]
        CallBySewadwaar = 3,
        [Description("Saved Services (hook api)")]
        SavedServices = 1,
        [Description("Services Workflow (hook api)")]
        ServicesWorkflow = 2
    }

    public enum EMitraOnlineVerified
    {
        [Description("Online Verified")]
        OnlineVerified = 1
    }

    public enum ActionBtn
    {
        [Description("Edit")] Edit = 2,
        [Description("Delete")] Delete = 3,
        [Description("OverwriteMapping")] OverwriteMapping = 6,
        [Description("OverwriteMappingList")] OverwriteMappingList = 7,
        [Description("DowngradeMapping")] DowngradeMapping = 8,
        [Description("MappingHistory")] MappingHistory = 9,
        [Description("GroupEdit")] GroupEdit = 10,
        [Description("Comments")] Comments = 20
        //[Description("Show Overwrite Mapping")] ShowOverwriteMapping = 8,
        //[Description("Down Grade Mapping")] DownGradeMapping = 9,
        //[Description("Show Mapping History")] ShowMappingHistory = 10,
        //[Description("Group Edit")] GroupEdit = 11
    }


    public enum RealityCheckFor
    {
        [Description("ForRajSampark")] ForRajSampark = 4,
        [Description("ForDepartment")] ForDepartment = 5,
        [Description("ForBhamashah")] ForBhamashah = 534,
        [Description("ForExcelFile")] ForExcelFile = 535,
        [Description("ForSASData")] ForSASData = 537,
        [Description("ForInboundData")] ForInboundData = 553

    }
    public enum MessageType
    {
        [Description("Master Message")]
        MasterMsg = 1,
        [Description("Return Message")]
        ReturnMsg = 2
    }


    public enum ConfigurationReader
    {
        [Description("Division")] Division = 46,
        [Description("GrievanceType")] GrievanceType = 174,
        [Description("RuralId")] RuralId = 65,
        [Description("UrbanId")] UrbanId = 66,
        [Description("AdministrativeId")] AdministrativeId = 179
    }

    public enum RealityCheckModes
    {
        [Description("SMSEmailMode")] SMSEmailMode = 257,
        [Description("IVRMode")] IVRMode = 9,
        [Description("ManualCallMode")] ManualCallMode = 10,
        [Description("ManualCalling")] ManualCalling = 2025
    }

    public enum FormType
    {
        [Description("ShortForm")] ShortForm = 201,
        [Description("RequestForCallBack")] RequestForCallBack = 202
    }
    public enum PrivilegeActionFlow
    {
        [Description("All")]
        All = -1,
        [Description("Add")]
        Add = 1,
        //[Description("Edit")]
        //Edit = 2,
        //[Description("Delete")]
        //Delete = 3,
        [Description("View")]
        View = 4
    }
    public enum GrievanceDesc
    {
        [Description("Grievance through Scheme & service Application Number")]
        GrievanceMsgAppNo = 1,
        [Description("Grievance allocation not exists")]
        GrievanceMappingNotExists = 2,
        [Description("Scheme and Service")]
        SchemeAndService = 3
    }
    public enum QuestionType
    {
        [Description("Objective")]
        Objective = 170,
        [Description("Subjective")]
        Subjective = 169,
        [Description("MixMode")]
        MixMode = 569
    }

    public enum VerificationStatus
    {
        [Description("Pending")]
        Pending = 2,
        [Description("Relief")]
        Relief = 1,
        [Description("Reject")]
        Reject = 3,
        [Description("Relief Satisfied")]
        ReliefSatisfied = 13,
        [Description("Reject Satisfied")]
        RejectSatisfied = 35,
        [Description("Relief NonSatisfied")]
        ReliefNonSatisfied = 26,
        [Description("Reject NonSatisfied")]
        RejectNonSatisfied = 26
    }

    public enum SatisfactionLevel
    {
        [Description("Satisfied")]
        Satisfied = 1,
        [Description("Nonsatisfied")]
        Nonsatisfied = 2,
        [Description("All")]
        All = 3

    }
    public enum Departments // AR7,AR6,AR1 :Time Line State Monitoring Report
    {
        Value20 = 20,
        Value324 = 324,
        Value325 = 325,
        Value142 = 142,
        Value243 = 243,
        Value327 = 327,
        Value5 = 5,
        Value375 = 375,
        Value368 = 368,
        Value105 = 105,
        Value229 = 229,
        Value113 = 113,
        Value146 = 146,
        Value378 = 378,
        Value8 = 8,
        Value328 = 328,
        Value129 = 129,
        Value315 = 315,
        Value117 = 117,
        Value147 = 147,
        Value238 = 238,
        Value137 = 137,
        Value366 = 366,
        Value131 = 131,
        Value260 = 260,
        Value31 = 31,
        Value232 = 232,
        Value35 = 35,
        Value148 = 148,
        Value41 = 41,
        Value42 = 42,
        Value240 = 240,
        Value223 = 223,
        Value314 = 314,
        Value150 = 150,
        Value47 = 47,
        Value154 = 154,
        Value227 = 227,
        Value135 = 135,
        Value51 = 51,
        Value313 = 313,
        Value228 = 228,
        Value237 = 237,
        Value224 = 224,
        Value155 = 155,
        Value54 = 54,
        Value84 = 84,
        Value222 = 222,
        Value226 = 226,
        Value163 = 163,
        Value164 = 164,
        Value165 = 165,
        Value166 = 166,
        Value167 = 167,
        Value251 = 251,
        Value168 = 168,
        Value212 = 212,
        Value170 = 170,
        Value171 = 171,
        Value111 = 111,
        Value172 = 172,
        Value319 = 319,
        Value173 = 173,
        Value174 = 174,
        Value239 = 239,
        Value37 = 37,
        Value220 = 220,
        Value176 = 176,
        Value245 = 245,
        Value177 = 177,
        Value259 = 259,
        Value178 = 178,
        Value179 = 179,
        Value353 = 353,
        Value254 = 254,
        Value241 = 241,
        Value72 = 72,
        Value310 = 310,
        Value377 = 377,
        Value181 = 181,
        Value182 = 182,
        Value253 = 253,
        Value244 = 244,
        Value248 = 248,
        Value213 = 213,
        Value332 = 332,
        Value249 = 249,
        Value183 = 183,
        Value184 = 184,
        Value331 = 331,
        Value110 = 110,
        Value242 = 242,
        Value109 = 109,
        Value330 = 330,
        Value191 = 191,
        Value192 = 192,
        Value193 = 193,
        Value194 = 194,
        Value195 = 195,
        Value187 = 187,
        Value188 = 188,
        Value189 = 189,
        Value190 = 190,
        Value257 = 257,
        Value258 = 258,
        Value199 = 199,
        Value200 = 200,
        Value309 = 309,
        Value203 = 203,
        Value321 = 321,
        Value204 = 204,
        Value76 = 76,
        Value75 = 75,
        Value316 = 316,
        Value306 = 306,
        Value221 = 221,
        Value320 = 320,
        Value250 = 250,
        Value100 = 100,
        Value252 = 252,
        Value247 = 247,
        Value211 = 211,
        Value210 = 210,
        Value80 = 80,
        Value81 = 81,
        Value234 = 234,
        Value83 = 83,
        Value230 = 230,
        Value326 = 326,
        Value323 = 323,
        Value86 = 86,
        Value236 = 236,
        Value88 = 88,
        Value304 = 304,
        Value138 = 138,
        Value92 = 92,
        Value139 = 139,
        Value93 = 93,
        Value225 = 225,
        Value216 = 216,
        Value99 = 99
    }

    public enum pTypeForPE6
    {
        [Description("Registered")]
        Registered = 7,
        [Description("Disposed")]
        Disposed = 8,
        [Description("0-30")]
        LessThenEqualTo30 = 1,
        [Description("31-45")]
        GreaterThen30AndLessThenEqualTo45 = 2,
        [Description("46-60")]
        GreaterThen45AndLessThenEqualTo60 = 3,
        [Description("61-180")]
        GreaterThen60AndLessThenEqualTo180 = 4,
        [Description("180-365")]
        GreaterThen180AndLessThenEqualTo365 = 5,
        [Description(">365")]
        GreaterThen365 = 9,
        [Description("Total")]
        Total = 6
    }

    public enum pTypeForPE4
    {
        [Description("Registered")]
        Registered = 7,
        [Description("Disposed")]
        Disposed = 8,
        [Description("0-30")]
        LessThenEqualTo30 = 1,
        [Description("31-45")]
        GreaterThen30AndLessThenEqualTo45 = 2,
        [Description("46-60")]
        GreaterThen45AndLessThenEqualTo60 = 3,
        [Description("61-180")]
        GreaterThen60AndLessThenEqualTo180 = 4,
        [Description(">180")]
        GreaterThen180 = 5,
        [Description("Total")]
        Total = 6
    }

    public enum ViewAs
    {
        [Description("District Wise")] DistrictWise = 141,
        [Description("Department Wise")] DepartmentWise = 142
    }
    public enum ViewAsRegional
    {
        [Description("जिलावार")] वेबपोर्टल = 141,
        [Description("विभागवार")] कॉलसेंटर = 142
    }

    public enum DtypeForAR1
    {
        [Description("<= 30")]
        LessThenEqualTo30 = 1,
        [Description("31-45")]
        GreaterThen30AndLessThenEqualTo45 = 2,
        [Description("46-60")]
        GreaterThen45AndLessThenEqualTo60 = 3,
        [Description("61-90")]
        GreaterThen60AndLessThenEqualTo90 = 4,
        [Description("91-180")]
        GreaterThen90AndLessThenEqualTo180 = 5,
        [Description("180-365")]
        GreaterThen180AndLessThenEqualTo365 = 6,
        [Description(">365")]
        GreaterThen365 = 7
    }

    public enum DtypeForAR7 //For AR3 AND AR6
    {
        [Description("<= 30")]
        LessThenEqualTo30 = 1,
        [Description("31-45")]
        GreaterThen30AndLessThenEqualTo45 = 2,
        [Description("46-60")]
        GreaterThen45AndLessThenEqualTo60 = 3,
        [Description("61-180")]
        GreaterThen60AndLessThenEqualTo180 = 4,
        [Description("180-365")]
        GreaterThen180AndLessThenEqualTo365 = 5,
        [Description(">365")]
        GreaterThen365 = 6
    }

    public enum ReportType
    {
        [Description("AR1")]
        AR1 = 1,
        [Description("AR2")]
        AR2 = 2,
        [Description("AR3")]
        AR3 = 3,
        [Description("AR4")]
        AR4 = 4,
        [Description("AR5")]
        AR5 = 5,
        [Description("AR6")]
        AR6 = 6,
        [Description("AR7")]
        AR7 = 7,
        [Description("PE1")]
        PE1 = 8,
        [Description("PE2")]
        PE2 = 9,
        [Description("PE3")]
        PE3 = 10,
        [Description("PE4")]
        PE4 = 11,
        [Description("PE5")]
        PE5 = 12,
        [Description("PE6")]
        PE6 = 13,
        [Description("PE7")]
        PE7 = 14,
        [Description("PE8")]
        PE8 = 15,
        [Description("PE9")]
        PE9 = 16,
        [Description("PE10")]
        PE10 = 17,
        [Description("PE11")]
        PE11 = 19,
        [Description("DP1")]
        DP1 = 20,
        [Description("DP2")]
        DP2 = 21,
        [Description("DP3")]
        DP3 = 22,
        [Description("DP4")]
        DP4 = 23,
        [Description("DP5")]
        DP5 = 24

    }


    public enum OTPForAutomation
    {
        [Description("154530")]
        OTP = 1,
        [Description("7014565653")]
        OTPMobileNo = 2
    }

    public enum IsReminderEnd
    {

        [Description("Never End")]
        NeverEnd = 1,
        [Description("Occurance")]
        Occurance = 2,
        [Description("Reminder End Date")]
        ReminderEndDate = 3
    }

    public enum RealityCheckEmailStatus
    {
        [Description("Email sent successfully")]
        Emailsentsuccessfully = 477,
        [Description("Email sending failed")]
        Emailsendingfailed = 478,
        [Description("Email Id not valid...!")]
        EmailIdnotvalid = 485

    }
    public enum AllotmentStatus
    {
        [Description("CallSuccess")]
        CallSuccess = 36
    }
    public enum IdleDays
    {
        [Description(">15 Days")]
        GreaterThen15 = 1,
        [Description(">30 Days")]
        GreaterThen30 = 2,
        [Description(">45 Days")]
        GreaterThen45 = 3,
        [Description(">60 Days")]
        GreaterThen60 = 4,
        [Description(">180 Days")]
        GreaterThen180 = 5
    }
    public enum RealityCheckIVRModesStatus
    {
        [Description("IVRSuccess")]
        IVRSuccess = 506,
    }
    public enum RealityCheckManualCallStatus
    {
        [Description("ManualCallSuccessId")]
        ManualCallSuccessId = 36,
    }
    public enum CampaignModules
    {
        [Description("Grievance Verification")] GrievanceVerification = 32,
        [Description("Reality Check Outbound Survey")] RealityCheckOutboundSurvey = 33,
        [Description("Transfer Request")] TransferRequest = 34,
        [Description("Call Back Request")] CallbackRequest = 35,
        [Description("Short Comings- S&S")] ShortComings = 36,
        [Description("Grievance Follow up")] GrievanceFollowUp = 42,
		[Description("Call Center (Broadcast)")] CallCenterBroadcast = 242,
        [Description("Application Document Verification")] ApplicationDocumentVerification = 55,
		[Description("Suggestions")] Suggestions = 122


	}
    public enum IvrTypes
    {
        [Description("TextToSpeech")] TextToSpeech = 566,
        [Description("Automatic Speech Recognition")] Asr = 567,

    }
    public enum SampleTypes
    {
        [Description("FixedSample")] FixedSample = 573,
        [Description("OpenSample")] OpenSample = 572,
    }
    public enum PGIntegration
    {
        [Description("Reversed")] Reversed = 1,
        [Description("Forwarded")] Forwarded = 0
    }
    public enum PGIntegrationHindi
    {
        [Description("रिवर्स")] रिवर्स = 1,
        [Description("अग्रेषित")] अग्रेषित = 0
    }
    public enum enumComplainStatus
    {
        [Description("Disposed")]
        Disposed = 13,
        [Description("Specially Closed")]
        SpeciallyClosed = 35,
        [Description("Marked Not Satisfied")]
        MarkedNotSatisfied = 26
    }
    public enum enumComplainSubStatus
    {
        [Description("Proposed Relief")]
        ProposedRelief = 19,
        [Description("Proposed Disposal (Cancelled)")]
        ProposedDisposalCancelled = 21
    }

    public enum enumReasonOfEng
    {
        [Description("Not Reachable")]
        NotReachable = 1,
        [Description("Swicth Off")]
        SwicthOff = 2,
        [Description("Out Of Coverage Area")]
        OutOfCoverageArea = 3,
        [Description("Busy")]
        Busy = 4,
        [Description("Ringing")]
        Ringing = 5
    }
    public enum enumReasonOfHindi
    {
        [Description("पहुँचने योग्य नहीं")]
        पहुँचनेयोग्यनहीं = 1,
        [Description("स्विच ऑफ")]
        स्विचऑफ = 2,
        [Description("कवरेज क्षेत्र से बाहर")]
        कवरेजक्षेत्रसेबाहर = 3,
        [Description("व्यस्त")]
        व्यस्त = 4,
        [Description("रिंगिंग")]
        रिंगिंग = 5
    }

    public enum TourEventType
    {
        [Description("Inspection")]
        TourEventInspection = 1,
        [Description("Meeting")]
        TourEventMeeting = 2,
        [Description("Jansunwai")]
        TourEventJansunwai = 3,
        [Description("Ratrichaupal")]
        TourEventRatrichaupal = 4
    }

    public enum TourUserType
    {

        [Description("Departmental User")]
        DepartmentalUser = 1,
        [Description("Divisional Commissioner")]
        DivisionalCommissioner = 2,
        [Description("District Incharge Minister")]
        DistrictInchargeMinister = 3,
        [Description("District Incharge Secretary")]
        DistrictInchargeSecretary = 4,
        [Description("Departmental Incharge Secretary")]
        DepartmentalInchargeSecretary = 5,
        [Description("Departmental Incharge Secretary")]
        SuperintendentofPolice = 6,

    }
    public enum JansunwaiGrievanceType
    {
        [Description("New")]
        New = 1,
        [Description("Relief")]
        Relief = 2,
        [Description("Old")]
        Old = 3,

    }
    public enum DesignationAndRoleCombinedEnum
    {
        [Description("DivisionalCommissioner")]
        DivisionalCommissioner = 585,
        [Description("District Incharge Minister")]
        DistrictInchargeMinister = 893,
        [Description("District Incharge Secretary")]
        DistrictInchargeSecretary = 867,
        [Description("Departmental Secretary")]
        DepartmentalSecretary = 1512,
        [Description("District Collector")]
        DistrictCollector = 568,
        [Description("Superintendent of Police")]
        SuperintendentofPolice = 33,
    }

    public enum TourDesignationEnum
    {
        [Description("DivisionalCommissioner")]
        DivisionalCommissioner = 585,
        [Description("District Incharge Minister")]
        DistrictInchargeMinister = 893,
        [Description("District Incharge Secretary")]
        DistrictInchargeSecretary = 867,
        [Description("Departmental Secretary")]
        DepartmentalSecretary = 1512,
        [Description("District Collector")]
        DistrictCollector = 568,
        [Description("Superintendent of Police")]
        SuperintendentofPolice = 33,
    }


    public enum TourRoles
    {
        [Description("Tour Nodal Officer")]
        TourNodalOfficer = 824,
        [Description("Tour Departmental User")]
        TourDepartmentalUser = 822,
        [Description("Tour Super Admin")]
        TourSuperAdmin = 825,
        [Description("Tour Department HOD")]
        TourDepartmentHOD = 823,
        [Description("Tour Web SuperAdmin Portal")]
        TourWebSuperAdminPortal = 4,

    }
    public enum ReportViewAs
    {
        [Description("Follow")]
        Follow = 1,
        [Description("Detail")]
        Detail = 2
    }

    public enum ParamsRefTypeUPM
    {

        SUPPORT_GRVNC_HEAD_OF_DEPARTMENT,
        SUPPORT_GRVNC_STATE_LEVEL_NODAL_OFFICER,
        SUPPORT_GRVNC_DEPARTMENTAL_ADMINISTRATOR,
        SUPPORT_GRVNC_DISTRICT_LEVEL_NODAL_OFFICER,
        SUPPORT_TOUR_NODAL_OFFICER,
        SUPPORT_TOUR_AR_TIMES,
        SUPPORT_TOUR_TECHNICAL_ISSUES,
        SUPPORT_SAMPARK_CALL_CENTER,
        SUPPORT_SAMPARK_TECHNICAL_ISSUES,
        SUPPORT_SAMPARK_TRAINING_CENTER
    }

    public enum SMSRequestSewadwaar
    {
        [Description("dW3urYJT35EwGQthzekolK")]
        UserID1 = 1,
        [Description("A3HDVZLIKjJNmfELKao27YF2O9HNS")]
        Password = 2
    }
    public enum SMSRequestKeywords
    {
        [Description("Main Sampark Code")]
        SMPRK= 1,
        [Description("Grievance Reg Code")]
        GRVREG = 2,
        [Description("Service Reg Code")]
        SRVREG = 3,
        [Description("Survey Welcome Text Code")]
        SURV = 4
    }
    public enum Organizations
    {
        [Description("Sampark")]
        Sampark = 100,
        [Description("LDA")]
        LDA = 3
    }
    public enum ProfileIncomplete
    {
        [Description("IsProfileIncomplete")]
        IsProfileIncomplete = 2

    }
    public enum UserRoles
    {
        [Description("Super admin-portal")]
        SuperAdminPortal = 1,
        [Description("Department HOD")]
        DepartmentHod = 3,
        [Description(" Collectorate administrator")]
        CollectorateAdmin = 834,
    }


}