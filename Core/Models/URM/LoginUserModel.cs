using System.Runtime.Serialization;

namespace Core.Models.URM
{
    [Serializable]
    [DataContract]
#nullable disable
    public class LoginUserModel
    {
        [DataMember]
        public int OrgId { get; set; }
        [DataMember]
        public Int32 UserId { get; set; }
        [DataMember]
        public string LoginId { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public Int32 UserType { get; set; }
        [DataMember]
        public Int64 UserReferenceNumber { get; set; }
        [DataMember]
        public Int64 LoginLogId { get; set; }
        [DataMember]
        public string OrgCode { get; set; }
        [DataMember]
        public string OrganizationName { get; set; }
        [DataMember]
        public string IPAddress { get; set; }
        [DataMember]
        public string FormUrl { get; set; }
        [DataMember]
        public string ApiKey { get; set; }
        [DataMember]
        public List<int> AllPriviliges { get; set; }
        [DataMember]
        public dynamic OtherDetails { get; set; }
    }
}
