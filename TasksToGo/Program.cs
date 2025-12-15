using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TasksToGo.Context;
using TasksToGo.Models.AuthModel;

namespace TasksToGo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var builder = WebApplication.CreateBuilder(args);

            //// Add services to the container.
            //builder.Services.AddControllersWithViews();

            //builder.Services.AddDbContext<ApplicationDbContext>(options=>
            //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));

            //var app = builder.Build();

            //// Configure the HTTP request pipeline.
            //if (!app.Environment.IsDevelopment())
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            //app.UseHttpsRedirection();
            //app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            //app.Run();

            var builder = WebApplication.CreateBuilder(args);
            // 1. Add DbContext (you probably have this)
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration
            .GetConnectionString("DefaultConnection")));
            // 2. ADD IDENTITY SERVICES - NEW!
            builder.Services.AddIdentity<AppUser, IdentityRole>(options => //عشان يستخدم AppUser
            {
                // option هي اوبجكت خاص بالسكيورتي ************************

                // Password settings (easier for development)
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 4;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();


            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            // ... other middleware ...
            // 3. ADD AUTH MIDDLEWARE - ORDER MATTERS!
            app.UseAuthentication(); // WHO are you? (FIRST!)
            app.UseAuthorization(); // WHAT can you do?


            app.MapControllerRoute(/* ... */);
        }
    }
}
