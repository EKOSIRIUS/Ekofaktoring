using EkoFactoring.Data.Abstract;
using EkoFactoring.Data.Concrete;
using EkoFactoring.Data.Concrete.EntityFramework.Contexts;
using EkoFaktoring.Business.Abstract;
using EkoFaktoring.Business.Concrete;
using Microsoft.Extensions.DependencyInjection;

namespace EkoFaktoring.Business.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection LoadMyService(this IServiceCollection services)
        {
            services.AddDbContext<EkoFaktoringContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICvBasvuruService, CvBasvuruManager>();
            return services;
        }
    }
}