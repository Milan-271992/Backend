using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class GrivncLifeCycleModel
    {

    }
    public class DetailGrivancesModel
    { 
        public string ComplainStatus { get; set; }    
        public string ComplainStatusHindi { get; set; }  
        public string ComplainantName { get; set; }
        public string Description { get; set; }
        public string GDate { get; set; }
        public string GrievanceArea { get; set; }
        public string GrievanceId { get; set; }
        public string LATEST_REMARKS { get; set; }
        public string MobileNo { get; set; }
        public string OwnerDepartment { get; set; }
        public string PendingforVerification { get; set; }
        public string Subject { get; set; }
    }
    public class AttatchmentModel { 
       public string EVoltID { get; set; }
        public string FileName { get; set; }
    }
    public class GrievancesLifeCycle 
    {
        public string SNO { get; set; }
        public string DATE_TIME { get; set; }
        public string ActingPerson { get; set; }
        public string ActionDetail { get; set; }
        public string ActionType { get; set; }
        public string Level { get; set; }
        public string FileName { get; set; }
        public string EVoltID { get; set; }
          
    }
    public class GrievancesWithLifeCycle 
    { 
        public List<AttatchmentModel> AttatchmentClient { get; set; }
        public List<AttatchmentModel> AttatchmentOfficer { get; set; }
        public DetailGrivancesModel DetailGrivances { get; set; }
        public List<GrievancesLifeCycle> GrievancesActionHistory { get; set; }
    }
    public class GrievanceDTLSubject {
        public string GrievanceId { get; set; }
        public string ComplainantName { get; set; }
        public string GDate { get; set; }
        public string MobileNo { get; set; }
        public string Department { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string ComplainStatus { get; set; }
        public string LastAction { get; set; }
        public string LastRemarks { get; set; }
        public string PendingSince { get;set; }
        public string DisposalTime { get; set; }
        public string PendingWith { get; set; }
        public string ReliefRequired { get; set; }
        public string FatherName { get; set; }
        public string FeedbackReminder { get; set; }
        public string CityBlock { get; set; }
        public string WardGramPanchayat { get; set; }
        public string AttachedGrievance { get; set; }
    }
    
    /// <summary>
  /// Blow model class related to nfsa API 
  /// </summary>
    public class SetGrievanceServiceModel 
    { 
        public string stateField { get; set; }
        public string tokenField { get; set; }
        public string authStringField { get; set; }
        public propSetGrievanceServiceModelGrievanceData grievanceDataField { get; set; }
        public propSetGrievanceServiceModelPropGrievanceAttachmentDetails[] attachmentDetailsField;
    }
    public class propSetGrievanceServiceModelGrievanceData 
    {
        public string nFSAGrievanceIdField { get; set; }
        public string grievanceDateField { get; set; }
        public string grievanceTypeCodeField { get; set; }
        public string tentativeCompletionDateField { get; set; }
        public string modeofGrievanceCodeField { get; set; }
        public string platformofGrievanceCodeField { get; set; }
        public string nameField { get; set; }
        public string mobileField { get; set; }
        public string emailField { get; set; }
        public string addressField { get; set; }
        public string rCNoField { get; set; }
        public string fPSNoField { get; set; }
        public string fPSNameField { get; set; }
        public string stateField { get; set; }
        public string districtField { get; set; }
        public string tahsilField { get; set; }
        public string fPSStateField { get; set; }
        public string fPSDistrictField { get; set; }
        public string aadharNumberField { get; set; }
        public string grievanceDetailsField { get; set; }
        public string grievanceStatusField { get; set; }
    }
    public class  propSetGrievanceServiceModelPropGrievanceAttachmentDetails
    {
        public string attachmentNameField { get; set; }
        public string attachmentFileTypeField { get; set; }
        public string base64DataField { get; set; }

    }

    public class GrievanceResponse 
    {
        public string stateField { get; set ; }
        public string tokenField { get; set; }
        public string ackCodeField { get; set; }
        public string statusField { get; set; }
        public string remarksField { get; set; }
        public string serviceDateField { get; set; }

        public propGrievanceResponsePropResponseDetails[] responseDetailsField;
    }
    public class propGrievanceResponsePropResponseDetails
    {
        public string stateGrievanceIdField { get; set; }
        public string grievanceDateField { get; set; }
        public string nFSAGrievanceIdField { get; set; }
        public string statusField { get; set; }
        public string remarksField { get; set; }

    }
}
