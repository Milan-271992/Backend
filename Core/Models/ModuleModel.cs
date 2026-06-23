using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public  class ModuleModel
    {
        public int SrNo { get; set; }
        public int TotalRecordCount { get; set; }
        public int FilteredRecordCount { get; set; }
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public string ModuleNameRegional { get; set; }
        public string Title { get; set; }
        public string ParentId { get; set; }
        public string ModuleStatus { get; set; }
        public string IsActive { get; set; }

        public string IconSvg { get; set; }

    }

    public class MenuObjectListexcel
    {

        [DataMember]
        [DisplayName("Module Name")]
        public string ModuleName { get; set; }

        [DataMember]
        [DisplayName("Module Name Hindi")]
        public string ModuleNameRegional { get; set; }

        [DataMember]
        [DisplayName("Abbreviation")]
        public string Title { get; set; }

        [DataMember]
        [DisplayName("Status")]
        public string ModuleStatus { get; set; }


    }


}
