using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JkTyre.Data.Entities
{
    [Table("jktyre_incentive_master")]
    public class IncentiveMaster
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ID")]
        public long Id { get; set; }

        [Column("ORG_ID")]
        public int OrgId { get; set; }

        [Column("CODE")]
        public string Code { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }
        [Column("EFFECTIVE_FROM")]
        public DateTime? EffectiveFrom { get; set; }
        [Column("EFFECTIVE_TO")]
        public DateTime? EffectiveTo { get; set; }

        [Column("STATUS_ID")]
        public int StatusId { get; set; }

        [Column("IS_ACTIVE")]
        public short? IsActive { get; set; }

        [Column("CREATED_ON")]
        public DateTime? CreatedOn { get; set; }

        [Column("CREATED_BY")]
        public int CreatedBy { get; set; }

        [Column("UPDATED_ON")]
        public DateTime? UpdatedOn { get; set; }

        [Column("UPDATED_BY")]
        public int UpdatedBy { get; set; }
    }
}
