using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ParentLocationNodeListModel
    {
        public Int32 RootLocId { get; set; }
        public Int32 LocId { get; set; }
        public Int32 ParentLocId { get; set; }
        public Int32 LocType { get; set; }
        public string LocName { get; set; }
        public string LocNameRegional { get; set; }
        public int? OrderBy { get; set; }
    }

    public class ChildLocationNodeListModel
    {
        public Int64 LocId { get; set; }
        public Int64 ParentLocationId { get; set; }
        public Int64 LocationTypeId { get; set; }
        public string LocationName { get; set; }
        public Int32 LEVEL { get; set; }

    }
    public class ChildLocationNodeListModelNew
    {
        public Int64 LocId { get; set; }
        public Int64 ParentLocationId { get; set; }
        public Int64 LocationTypeId { get; set; }
        public string LocationName { get; set; }
        public Int32 LEVEL { get; set; }
        public List<ChildLocationNodeListModelNew> Children { get; set; } = new List<ChildLocationNodeListModelNew>();
    }
}
