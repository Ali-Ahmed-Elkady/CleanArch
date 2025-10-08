using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Infrastructure.DataBase
{
    public class ApplicationDbContext(DbContextOptions op) : IdentityDbContext<AppUser>(op)
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUserPasskey<string>>().Ignore(p => p.Data).HasNoKey();
        }
    }
}
