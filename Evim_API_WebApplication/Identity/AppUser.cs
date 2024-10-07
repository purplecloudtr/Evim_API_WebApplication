using Microsoft.AspNetCore.Identity;

namespace Evim_API_WebApplication.Identity
{
    public class AppUser : IdentityUser <int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
