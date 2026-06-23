using System.Runtime.Serialization;

namespace Core.Models
{
    [Serializable]
    [DataContract]
#nullable disable
    public class AutoCompleteSearchModel
    {
        [DataMember]
        public Int32 OrgId { get; set; }

        [DataMember]
        public dynamic P1 { get; set; }

        [DataMember]
        public dynamic P2 { get; set; }

        [DataMember]
        public dynamic P3 { get; set; }

        [DataMember]
        public dynamic P4 { get; set; }

        [DataMember]
        public string Query { get; set; }
    }
}
