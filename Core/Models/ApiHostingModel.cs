using System.Runtime.Serialization;

namespace Core.Models
{
    [Serializable]
    [DataContract]
#nullable disable
    public class ApiHostingModel
    {
        [DataMember]
        public string Module { get; set; }

        [DataMember]
        public string URL { get; set; }
    }
}
