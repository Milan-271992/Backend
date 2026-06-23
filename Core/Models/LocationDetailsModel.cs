using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class LocationDetailsModel
    {
        public int LocId { get; set; }
        public int locTypeId { get; set; }
        public string LocationName { get; set; }
        public string LocationNameRegional { get; set; }
        public string LocationTypeName { get; set; }
        public string LocationTypeNameRegional { get; set; }
        public string CensusCode { get; set; }
        public string ShapeLength { get; set; }
        public string ShapeArea { get; set; }
        public string ZoneName { get; set; }
        public string ZoneNameRegional { get; set; }
        public string MasterLocationName { get; set; }
        public string MasterLocationNameHindi { get; set; }
    }
}
