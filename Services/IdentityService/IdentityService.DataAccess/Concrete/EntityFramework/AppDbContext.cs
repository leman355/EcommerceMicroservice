using CorePackage.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace IdentityService.DataAccess.Concrete
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=WIN-OO1ICO19G9E;initial catalog=IdentityService;Trusted_connection=true;TrustServerCertificate=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}