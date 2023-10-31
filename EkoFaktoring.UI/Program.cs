using EkoFaktoring.Core.Repositories;
using EkoFaktoring.Core.Services;
using EkoFaktoring.Core.UnitOfWorks;
using EkoFaktoring.Repository;
using EkoFaktoring.Repository.Repositories;
using EkoFaktoring.Repository.UnitOfWork;
using EkoFaktoring.Service.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EkoFaktoring.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

            builder.Services.AddDbContext<AppDbContext>(
                x =>
                {
                    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
                    {
                        option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext)).GetName().Name);
                    });
                }
            );

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
             
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}