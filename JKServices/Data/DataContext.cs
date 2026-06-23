using JkTyre.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace JkTyre.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<IncentiveMaster> IncentiveMasters { get; set; }
    }
}
