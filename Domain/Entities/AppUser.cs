using Microsoft.AspNetCore.Identity;
namespace Domain.Entities
{
    public class AppUser :IdentityUser
    {
        public bool IsActive { get; set; }
        public DateTime RegisteredAt { get; set; } 
    }
}
