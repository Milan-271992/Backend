using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class SubjectProjectListModel
    {
        public Int32 SrNo { get; set; }
        public Int32 TotalRecordCount { get; set; }
        public Int32 FilteredRecordCount { get; set; }
        //public Int64 LocationTypeId { get; set; }
        //public Int64 LocationId { get; set; }
        public Int64 SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectNameRegional { get; set; }
        public string ProjectName { get; set; }
        public string TimeLimit { get; set; }
        public string TimeLimitRegional { get; set; }
        public string ProjectNameRegional { get; set; }
        //public Int32 LevelId { get; set; }
        public Int32 level1 { get; set; }
        public Int32 level2 { get; set; }
        public Int32 level3 { get; set; }
        public Int32 level4 { get; set; }
    }

    public class SubjectListModel
    {
        public Int64 Dept { get; set; }
        public Int64 SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectNameRegional { get; set; }
        public Int64 ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectNameRegional { get; set; }
        public string TimeLimit { get; set; }
        public string TimeLimitRegional { get; set; }
        public string Extended { get; set; }
        public Int64 locType { get; set; }
        public Int64 Loc { get; set; }
        public Int64 lvl { get; set; }

    }
    public class SubjectListWO_mapping
    {
        public Int64 SrNo { get; set; }
        public Int64 FilteredRecordCount { get; set; }
        public Int64 SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectNameRegional { get; set; }
        public string TimeLimit { get; set; }
        public string TimeLimitRegional { get; set; }
        public string SubjectActive { get; set; }

    }
}
