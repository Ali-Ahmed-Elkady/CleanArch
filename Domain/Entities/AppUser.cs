using Microsoft.AspNetCore.Identity;
namespace Domain.Entities
{
    public class AppUser :IdentityUser<int>
    {
        public bool IsActive { get; set; }
        public DateTime RegisteredAt { get; set; } 
    }
}
