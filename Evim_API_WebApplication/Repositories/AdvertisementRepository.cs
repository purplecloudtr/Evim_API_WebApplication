
using Evim_API_WebApplication.Data;
using Evim_API_WebApplication.Entities;
using Evim_API_WebApplication.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Evim_API_WebApplication.Repositories
{
    public class AdvertisementRepository : IAdvertisementRepository
    {
        private readonly EvimDbContext _context;

        public AdvertisementRepository(EvimDbContext context)
        {
            _context = context;
        }

        public async Task<Advertisement> CreateAsync(Advertisement advertisement)
        {
            await _context.Advertisements.AddAsync(advertisement);
            await _context.SaveChangesAsync();
            return advertisement;
        }

        public async Task DeleteAsync(Advertisement advertisement)
        {
            _context.Advertisements.Remove(advertisement);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Advertisement>> GetAllAsync()
        {
            return await _context.Advertisements.ToListAsync();
        }

        public async Task<Advertisement> GetByIdAsync(int id)
        {
            var advertisement = await _context.Advertisements.FindAsync(id);
            return advertisement;
        }

        public async Task UpdateAsync(Advertisement advertisement)
        {
            var local = await _context.Advertisements.FirstOrDefaultAsync(a => a.AdvertisementId == advertisement.AdvertisementId);
            _context.Entry(local).CurrentValues.SetValues(advertisement);
            await _context.SaveChangesAsync();

        }

    }
}    
