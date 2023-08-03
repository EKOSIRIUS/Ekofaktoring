using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFactoring.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        ICvBasvuruRepository CvBasvuru { get; }
        IDenetimRaporlariRepository DenetimRaporlari { get; }
        IHakkimizdaRepository Hakkimizda { get; }
        IInsanKaynaklariRepository InsanKaynaklari { get; }
        Task<int> SaveAsync();
    }
}