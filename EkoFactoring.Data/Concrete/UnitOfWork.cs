using EkoFactoring.Data.Abstract;
using EkoFactoring.Data.Concrete.EntityFramework.Contexts;
using EkoFactoring.Data.Concrete.EntityFramework.Repositories;

namespace EkoFactoring.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EkoFaktoringContext _context;
        private readonly EfCvBasvuruRepository efCvBasvuruRepository;
        private readonly EfDenetimRaporlariRepository efDenetimRaporlariRepository;
        private readonly EfHakkimizdaRepository efHakkimizdaRepository;
        private readonly EfInsanKaynaklariRepository efInsanKaynaklariRepository;
        public UnitOfWork(EkoFaktoringContext context)
        {
            _context = context;
        }
        public ICvBasvuruRepository CvBasvuru => efCvBasvuruRepository ?? new EfCvBasvuruRepository(_context);
        public IDenetimRaporlariRepository DenetimRaporlari => efDenetimRaporlariRepository ?? new EfDenetimRaporlariRepository(_context);
        public IHakkimizdaRepository Hakkimizda => efHakkimizdaRepository ?? new EfHakkimizdaRepository(_context);
        public IInsanKaynaklariRepository InsanKaynaklari => efInsanKaynaklariRepository ?? new EfInsanKaynaklariRepository(_context);
        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}