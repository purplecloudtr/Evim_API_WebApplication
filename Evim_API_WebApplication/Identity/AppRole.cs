using Microsoft.AspNetCore.Identity;

namespace Evim_API_WebApplication.Identity
{
    public class AppRole : IdentityRole<int>
    {
        public string? Description { get; set; }
    }
}
