using EkoFaktoring.Core.Models.Kurumsal.TahvilBono;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Repositories
{
    public interface ITableRepository<T> where T : class
    {
        Task SaveDataAsync(T entity);
        void Remove(T entity);
        void UpdateData(T entity);
        Task<List<T>> GetDataAsync();
    }
}
