using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ServiceSchemeListModel : CommonEntityModel
    {
        public Int32 schemeId { get; set; }
        public Int32 departmentId { get; set; }
        public string schemeType { get; set; }
        public string schemeName { get; set; }
        public string schemeNameRegional { get; set; }
        public string departmentName { get; set; }
        public string departmentNameRegional { get; set; }
        public string schemeIcon { get; set; }
    }
    public class ServiceSchemeDListModel
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
      //  public string schemeNameRegional { get; set; }
       
        
    }
    public class SchemeDListModel_Old
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string schemeNameRegional { get; set; }
    }
    public class SchemeDListModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string NameHindi { get; set; }
    }

}
