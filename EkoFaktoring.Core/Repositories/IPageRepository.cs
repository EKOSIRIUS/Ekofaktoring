using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Core.Repositories
{
    public interface IPageRepository<T> where T : class
    {
        Task<T> GetPageAsync();
        void Update(T entity);
    }
}
