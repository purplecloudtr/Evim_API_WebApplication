

using Evim_API_WebApplication.Entities;

namespace Evim_API_WebApplication.Interfaces
{
        public interface IAdvertisementRepository
        {
        Task<List<Advertisement>> GetAllAsync();
        Task<Advertisement> GetByIdAsync(int id);

        Task<Advertisement> CreateAsync( Advertisement advertisement);

        Task UpdateAsync( Advertisement advertisement);

        Task DeleteAsync (Advertisement advertisement);

        }
    
}
