using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Services
{
    public interface IPageService<T> where T : class
    {
        Task<T> GetPageAsync();
        Task UpdateAsync(T entity);
    }
}
