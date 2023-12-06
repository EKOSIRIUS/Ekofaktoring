using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Services
{
    public interface ITableService<T> where T : class
    {
        Task SaveDataAsync(T entity);
        Task RemoveAsync(T entity);
        Task UpdateDataAsync(T entity);
        Task<List<T>> GetDataAsync();
    }
}
