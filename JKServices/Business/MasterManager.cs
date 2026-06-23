using JkTyre.Data;
using JkTyre.Data.Entities;
using JkTyre.Models;
using Microsoft.EntityFrameworkCore;

namespace JkTyre.Business
{
    public class MasterManager
    {
        private readonly DataContext _context;

        public MasterManager(DataContext context)
        {
            _context = context;
        }

        public async Task<List<IncentiveMaster>> GetIncentiveMasterAsync()
        {
            try
            {
                return await _context.IncentiveMasters.ToListAsync();
            }
            catch (Exception)
            {
                throw; // Keep original stack trace
            }
        }

        public async Task AddEditIncentiveMaster(IncentiveMasterModel mdm)
        {
            if (mdm == null)
                throw new ArgumentNullException(nameof(mdm));

            IncentiveMaster im;
            if (mdm.Id > 0)
            {
                // Update existing
                im = await _context.IncentiveMasters.FindAsync(mdm.Id);
                if (im != null)
                {   
                    im.Name = mdm.Name;
                    im.Code = mdm.Code;
                    im.Description = mdm.Description;
                    im.IsActive = mdm.IsActive;
                    im.EffectiveFrom = mdm.EffectiveFrom;
                    im.EffectiveTo = mdm.EffectiveTo;
                    
                    _context.IncentiveMasters.Update(im);
                }
            }
            else
            {
                // Add new
                im = new IncentiveMaster
                {
                    Name = mdm.Name,
                    Code = mdm.Code,
                    Description = mdm.Description,
                    IsActive = mdm.IsActive,
                    EffectiveFrom = mdm.EffectiveFrom,
                    EffectiveTo = mdm.EffectiveTo,

                };
                await _context.IncentiveMasters.AddAsync(im);
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteIncentiveMaster(long id)
        {
            var im = await _context.IncentiveMasters.FindAsync(id);
            if (im != null)
            {
                _context.IncentiveMasters.Remove(im);
                await _context.SaveChangesAsync();
            }
        }
    }
}
