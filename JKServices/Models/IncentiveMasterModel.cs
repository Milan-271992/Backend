using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JkTyre.Models
{
    public class IncentiveMasterModel
    {
            public long Id { get; set; }
            public int OrgId { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public DateTime? EffectiveFrom { get; set; }
            public DateTime? EffectiveTo { get; set; }
            public int StatusId { get; set; }
            public short? IsActive { get; set; }
            public DateTime? CreatedOn { get; set; }
            public int CreatedBy { get; set; }
            public DateTime? UpdatedOn { get; set; }
            public int UpdatedBy { get; set; }
        }
}
