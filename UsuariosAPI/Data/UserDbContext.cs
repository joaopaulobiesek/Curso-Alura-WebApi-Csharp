using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UsuariosAPI.Data
{
    public class UserDbContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public UserDbContext(DbContextOptions<UserDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            IdentityUser<int> admin = new IdentityUser<int>
            {
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.com",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                Id = 99999
            };

            PasswordHasher<IdentityUser<int>> passwordHasher = new PasswordHasher<IdentityUser<int>>();

            admin.PasswordHash = passwordHasher.HashPassword(admin, "Admin123!");

            builder.Entity<IdentityUser<int>>().HasData(admin);

            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int> { Id = 99999, Name = "admin", NormalizedName = "ADMIN" });
            
            builder.Entity<IdentityRole<int>>().HasData(new IdentityRole<int> { Id = 99998, Name = "regular", NormalizedName = "REGULAR" });

            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int> { RoleId = 99999, UserId = 99999 });
        }

    }
}
