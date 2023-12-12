using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication_MusicShop.Areas.Identity.Data;

namespace WebApplication_MusicShop.Data;

public class LoginContext : IdentityDbContext<MusicShopUser>
{
    public LoginContext(DbContextOptions<LoginContext> options)
        : base(options)
    {
    }

    public DbSet<MusicShopUser> MusicShopUsers { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

    }
}
