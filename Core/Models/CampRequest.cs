using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
  

    public class CampRequest
    {
        public int CampId { get; set; }
        public List<dynamic> RequestModel { get; set; }
        public dynamic GrievanceDetail { get; set; }
    }

}
