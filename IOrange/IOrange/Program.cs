using IOrange.Data;
using IOrange.Services;
using Microsoft.EntityFrameworkCore;

namespace IOrange
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<IorangedatabaseContext>(options =>
            options.UseMySql("Server=localhost;Database=iorangedatabase;Uid=root;Pwd=root", new MySqlServerVersion(new Version(8, 0))));
            builder.Services.AddScoped<ItemService>();
            builder.Services.AddSession();
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            
            app.UseSession();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id=UrlParameter.Optional}");
            app.MapRazorPages();

            app.Run();
        }
    }
}
