using EkoFaktoring.Business.Extensions;
using Microsoft.Extensions.FileProviders;

namespace EkoFaktoring.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.LoadMyService();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }

            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "wwwroot", "dashboard")),
                RequestPath = "/dashboard"
            });

            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "wwwroot", "home")),
                RequestPath = "/home"
            });

            app.UseRouting();
            app.UseAuthorization();
            app.UseAuthentication();

            app.MapAreaControllerRoute(
                name: "Admin",
                areaName: "Admin",
                pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
            );

            app.MapDefaultControllerRoute();
            app.Run();
        }
    }
}