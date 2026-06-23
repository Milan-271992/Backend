using System;
using System.Runtime.Serialization;
namespace Core.Models;

[DataContract]
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/Aahaar.BeInvolved")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/Aahaar.BeInvolved", IsNullable = false)]
public  class NtoSRequestModel
{

    private NtoSRequestModelAttachmentDetails[] attachmentDetailsField;
    private string authStringField;
    private NtoSRequestModelDetails responseDetailsField;
    private string stateField;
    private string tokenField;

    [DataMember]
    [System.Xml.Serialization.XmlArrayItem("NtoSRequestModelAttachmentDetails", IsNullable = false)]
    public NtoSRequestModelAttachmentDetails[] AttachmentDetails
    {
        get
        {
            return attachmentDetailsField;
        }
        set
        {
            attachmentDetailsField = value;
        }
    }

    [DataMember]
    public string AuthString
    {
        get
        {
            return authStringField;
        }
        set
        {
            authStringField = value;
        }
    }

    [DataMember]
    public NtoSRequestModelDetails ResponseDetails
    {
        get
        {
            return responseDetailsField;
        }
        set
        {
            responseDetailsField = value;
        }
    }

    [DataMember]
    public string State
    {
        get
        {
            return stateField;
        }
        set
        {
            stateField = value;
        }
    }

    [DataMember]
    public string Token
    {
        get
        {
            return tokenField;
        }
        set
        {
            tokenField = value;
        }
    }

}

[DataContract]
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/Aahaar.BeInvolved")]
public partial class NtoSRequestModelDetails
{

    private string issueStatusIdField;
    private string nFSAGrievanceIdField;
    private string nFSAResponseIdField;
    private string reponseDetailsField;
    private string respondedByField;
    private string responseDateField;
    private string stateGrievanceIdField;
    private string tentativeCompletionDateField;

    [DataMember]
    public string IssueStatusId
    {
        get
        {
            return issueStatusIdField;
        }
        set
        {
            issueStatusIdField = value;
        }
    }

    [DataMember]
    public string NFSAGrievanceId
    {
        get
        {
            return nFSAGrievanceIdField;
        }
        set
        {
            nFSAGrievanceIdField = value;
        }
    }

    [DataMember]
    public string NFSAResponseId
    {
        get
        {
            return nFSAResponseIdField;
        }
        set
        {
            nFSAResponseIdField = value;
        }
    }

    [DataMember]
    public string ReponseDetails
    {
        get
        {
            return reponseDetailsField;
        }
        set
        {
            reponseDetailsField = value;
        }
    }

    [DataMember]
    public string RespondedBy
    {
        get
        {
            return respondedByField;
        }
        set
        {
            respondedByField = value;
        }
    }

    [DataMember]
    public string ResponseDate
    {
        get
        {
            return responseDateField;
        }
        set
        {
            responseDateField = value;
        }
    }

    [DataMember]
    public string StateGrievanceId
    {
        get
        {
            return stateGrievanceIdField;
        }
        set
        {
            stateGrievanceIdField = value;
        }
    }

    [DataMember]
    public string TentativeCompletionDate
    {
        get
        {
            return tentativeCompletionDateField;
        }
        set
        {
            tentativeCompletionDateField = value;
        }
    }
}

[DataContract]
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/Aahaar.BeInvolved")]
public partial class NtoSRequestModelAttachmentDetails
{

    private string attachmentFileTypeField;
    private string attachmentNameField;
    private string base64DataField;

    [DataMember]
    public string AttachmentFileType
    {
        get
        {
            return attachmentFileTypeField;
        }
        set
        {
            attachmentFileTypeField = value;
        }
    }

    [DataMember]
    public string AttachmentName
    {
        get
        {
            return attachmentNameField;
        }
        set
        {
            attachmentNameField = value;
        }
    }

    [DataMember]
    public string Base64Data
    {
        get
        {
            return base64DataField;
        }
        set
        {
            base64DataField = value;
        }
    }

}

[DataContract]
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/Aahaar.BeInvolved")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.datacontract.org/2004/07/Aahaar.BeInvolved", IsNullable = true)]
public partial class NtoSGrievanceRequestResponse
{

    private string ackCodeField;
    private string remarksField;
    private List<NtoSGrievanceRequestResponsePropDetails> responseDetailsField;
    private string serviceDateField;
    private string stateField;
    private string statusField;
    private string tokenField;

    [DataMember]
    public string AckCode
    {
        get
        {
            return ackCodeField;
        }
        set
        {
            ackCodeField = value;
        }
    }

    [DataMember]
    public string Remarks
    {
        get
        {
            return remarksField;
        }
        set
        {
            remarksField = value;
        }
    }

    [DataMember]
    [System.Xml.Serialization.XmlArrayItem("propDetails", IsNullable = true)]
    public List<NtoSGrievanceRequestResponsePropDetails> ResponseDetails
    {
        get
        {
            return responseDetailsField;
        }
        set
        {
            responseDetailsField = value;
        }
    }

    [DataMember]
    public string ServiceDate
    {
        get
        {
            return serviceDateField;
        }
        set
        {
            serviceDateField = value;
        }
    }

    [DataMember]
    public string State
    {
        get
        {
            return stateField;
        }
        set
        {
            stateField = value;
        }
    }

    [DataMember]
    public string Status
    {
        get
        {
            return statusField;
        }
        set
        {
            statusField = value;
        }
    }

    [DataMember]
    public string Token
    {
        get
        {
            return tokenField;
        }
        set
        {
            tokenField = value;
        }
    }
}

[DataContract]
[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://schemas.datacontract.org/2004/07/Aahaar.BeInvolved")]
public partial class NtoSGrievanceRequestResponsePropDetails
{

    private string nFSAGrievanceIdField;
    private string nFSAResponseIdField;
    private string remarksField;
    private string stateGrievanceIdField;
    private string stateResponseIdField;
    private string statusField;

    [DataMember]
    public string NFSAGrievanceId
    {
        get
        {
            return nFSAGrievanceIdField;
        }
        set
        {
            nFSAGrievanceIdField = value;
        }
    }

    [DataMember]
    public string NFSAResponseId
    {
        get
        {
            return nFSAResponseIdField;
        }
        set
        {
            nFSAResponseIdField = value;
        }
    }

    [DataMember]
    public string Remarks
    {
        get
        {
            return remarksField;
        }
        set
        {
            remarksField = value;
        }
    }

    [DataMember]
    public string StateGrievanceId
    {
        get
        {
            return stateGrievanceIdField;
        }
        set
        {
            stateGrievanceIdField = value;
        }
    }

    [DataMember]
    public string StateResponseId
    {
        get
        {
            return stateResponseIdField;
        }
        set
        {
            stateResponseIdField = value;
        }
    }

    [DataMember]
    public string Status
    {
        get
        {
            return statusField;
        }
        set
        {
            statusField = value;
        }
    }

}
