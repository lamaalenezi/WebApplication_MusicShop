using WebApplication_MusicShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using WebApplication_MusicShop.Data;
using WebApplication_MusicShop.Areas.Identity.Data;

namespace WebApplication_MusicShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("LoginContextConnection") ?? throw new InvalidOperationException("Connection string 'LoginContextConnection' not found.");


            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // Add DbContext
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                           options.UseSqlServer(connectionString));
            builder.Services.AddDbContext<LoginContext>(options =>
                                      options.UseSqlServer(connectionString));
            builder.Services
                
                .AddDefaultIdentity<MusicShopUser>(options => options.SignIn.RequireConfirmedAccount = false )
                .AddEntityFrameworkStores<LoginContext>();

            builder.Services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });


            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())   
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Songs}/{action=Index}/{id?}");

            app.UseSession();
            app.MapRazorPages();

            app.Run();
        }
    }
}
