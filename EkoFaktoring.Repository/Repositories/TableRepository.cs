using EkoFaktoring.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Repository.Repositories
{
    public class TableRepository<T> : ITableRepository<T> where T : class
    {
        protected readonly AppDbContext _appDbContext;
        private readonly DbSet<T> _dbSet;
        public TableRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<T>();
        }
        public async Task<List<T>> GetDataAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task SaveDataAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void UpdateData(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
