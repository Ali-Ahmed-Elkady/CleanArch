namespace Infrastructure.DataBase
{
    public class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
         
        }
    }
}
