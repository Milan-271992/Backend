using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    //public class CommonEntityModel
    //{
    //    public Int64 CreatedBy { get; set; }
    //    public DateTime CreatedOn { get; set; }
    //    public Int64? ModifiedBy { get; set; }
    //    public DateTime? ModifiedOn { get; set; }
    //    public int? IsActive { get; set; }
    //    public int? IsDeleted { get; set; }
    //}



    public class CommonEntityModel
    {
        public Int64 CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now; // Default to current date and time
        public Int64? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsActive { get; set; } = 1; // Default to 1 (active)
        public int? IsDeleted { get; set; } = 0; // Default to 0 (not deleted)

        // Constructor (optional)
        public CommonEntityModel()
        {
            CreatedOn = DateTime.Now; // Ensure CreatedOn is set during initialization
            IsActive = 1; // Active by default
            IsDeleted = 0; // Not deleted by default
        }
    }

    public class AuditTrialModel
    {
        public Int64 AuditId { get; set; }
        public string Module { get; set; }
        public string API { get; set; }
        public DateTime EntryPoint { get; set; }
        public DateTime ExitPoint { get; set; }
        public string Model { get; set; }
        public Int64? UserId { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class SchedulerLogModel
    {
        public Int64 Id { get; set; }
        public string SchedulerName { get; set; }        
        public DateTime? StartOn { get; set; }
        public DateTime? EndOn { get; set; }
        public Int64 StatusId { get; set; }
        public string ErrorLog { get; set; }
    }
}
