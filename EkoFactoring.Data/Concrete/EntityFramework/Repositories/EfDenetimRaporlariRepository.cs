using EkoFactoring.Data.Abstract;
using EkoFaktoring.Entity.Concrete;
using EkoFaktoring.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace EkoFactoring.Data.Concrete.EntityFramework.Repositories
{
    public class EfDenetimRaporlariRepository : EfEntityRepositoryBase<DenetimRaporlari>, IDenetimRaporlariRepository
    {
        public EfDenetimRaporlariRepository(DbContext context) : base(context)
        {
        }
    }
}