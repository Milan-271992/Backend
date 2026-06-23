using System.ComponentModel;

namespace JkTyre.Enums
{
    public class Enums
    {
    }
    public enum ReturnMessage
    {
        [Description("New record saved successfully.")]
        NewRecordSavedSuccessfully = 1,
        [Description("Record updated successfully.")]
        RecordUpdatedSuccessfully = 2,
        [Description("Data fetched successfully.")]
        DataFetchSuccessfully = 3,
        [Description("Selected record(s) deleted successfully.")]
        RecordAlreadyDeleted = 4,
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
        [Description("Record Cannot be Deleted")]
        RecordCantBeDeleted = 12,
        [Description("Password Reset successfully.")]
        SelectedRecordResetPasswordSuccessfully = 13,
        [Description("Status Change successfully.")]
        SelectedRecordChangeStatusSuccessfully = 14,
        [Description("Selected record(s) Submitted successfully.")]
        SelectedRecordSubmittedSuccessfully = 15,
        [Description("Application Submitted successfully.")]
        ApplicationSubmittedScuccessfully = 16,
        [Description("Application Already Submitted.")]
        ApplicationAlreadySubmitted = 17,
        [Description("Employee CPF Account Already Exist.")]
        EmployeeCPFAccountAlreadyExist = 18,
        [Description("Record Already Exist.")]
        RecordAlreadyExist = 19,
        [Description("Loan Settled Successfully")]
        LoanSettledSuccessfully = 20,
        [Description("Voucher Generated Successfully")]
        VoucherGeneratedSuccessfully = 21,
        [Description("Plot Divided Successfully")]
        PlotDividedSuccessfully = 22,
        [Description("Profile Created Successfully")]
        ProfileCreation = 23,
        [Description("Profile Updated Successfully")]
        ProfileUpdation = 24,
        [Description("Registration successful.")]
        RegistrationSuccessful = 25,
        [Description("Complaint Rejected.")]
        ComplaintRejected = 26,
        [Description("Selected record is under process of Delisting.")]
        SelectedRecordDelistedSuccessfully = 27,
        [Description("Payment Process Done.")]
        PaymentProcessSuccessfully = 28,
        [Description("Amount Paid Successfully.")]
        AmountPaidSuccessfully = 29,
        [Description("Financial Year of Excel File does not match with selected Financial Year .")]
        SelectedFinYrNotmatch = 30,
        [Description("File Imported Successfully.")]
        FileImported = 31,
        [Description("File Type is not valid.")]
        FileValid = 32,
        [Description("Assign Unit before Paygroup")]
        AssignPB = 33,
        [Description("Employees Selected must be of same unit to assign same Paygroup")]
        AssignSamePB = 34,
        [Description("You can not change paygroup, as It is already used in salary process.")]
        PaygroupAlreadyUsed = 35,
        [Description("Reason added successfully.")]
        ReasonAddedSuccessfully = 36,
        [Description("Could not delete, Please check related data.")]
        CouldNotDelete = 37,
        [Description("Bill Approve limit is less than the approve amount")]
        ApproveAmountLessThanLimit = 38,
        [Description("Please Enter Case Nature.")]
        PleaseEnterValue = 39,
        [Description("Documents/Image Size always less than 2 MB")]
        DocumentsImageSize = 40,
        [Description("Only jpg,png,gif image allowed")]
        ImageExtension = 41,
        [Description("Tenure Expired")]
        TenureExpired = 42,
        [Description("Mandatory Fields need to fill")]
        MandatoryMessage = 43,
        [Description("SMS Send Successfully")]
        SMSSendSuccessfully = 44,
        [Description("Configration is in used,Record can not be deleted ")]
        ConfigrationisinusedRecordcannotbedeleted = 45,
        [Description("Record Approved successfully.")]
        RecordApprovedSuccessfully = 46,
        [Description("Record Submitted Successfully.")]
        RecordSubmittedSuccessfully = 47
    }
}
