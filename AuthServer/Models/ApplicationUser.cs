using Microsoft.AspNetCore.Identity;

namespace AuthServer.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public DateTime CreatedAt { get; init; } = DateTime.UtcNow;

    }
}