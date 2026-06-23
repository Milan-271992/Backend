using System.Runtime.Serialization;

namespace Core.Models
{
    [Serializable]
    [DataContract]
#nullable disable
    public class SelectListViewModel
    {
        public SelectListViewModel()
        {
            Selectable = true;
            Visible = true;
            Selected = false;
        }
        [DataMember]
        public Int64 Id { get; set; }
        [DataMember]
        public String IdStr { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string NameRegional { get; set; }
        [DataMember]
        public string AliasName { get; set; }
        [DataMember]
        public string AliasNameRegional { get; set; }

        [DataMember]
        public object Prop1 { get; set; }

        [DataMember]
        public object Prop2 { get; set; }

        [DataMember]
        public string OrgAddress { get; set; }
        [DataMember]
        public string ContactNumber { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string URL { get; set; }

        [DataMember]
        public string TollFreeNo { get; set; }

        [DataMember]
        public string ImageURL { get; set; }
        [DataMember]
        public bool Selected { get; set; }
        [DataMember]
        public bool Selectable { get; set; }
        [DataMember]
        public bool Visible { get; set; }
        [DataMember]
        public Decimal Area { get; set; }
        [DataMember]
        public Int32 PropertyAreaUnit { get; set; }
        [DataMember]
        public string PropertyAreaLabel { get; set; }
    }
}
