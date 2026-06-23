using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class UrlCodeModel
    {
        public string ShortUrlCode { get; set; }
    }
    public class ShortUrlDetailModel
    {
        public Int64 MappingId { get; set; }
        public string Originalurl { get; set; }
        public string Shorturl { get; set; }
        public string ExpiryDate { get; set; }
        public Int64? ModuleId { get; set; }
    }

   
}
