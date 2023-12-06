using EkoFaktoring.Core.Repositories;
using EkoFaktoring.Core.Services;
using EkoFaktoring.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkoFaktoring.Service.Services
{
    public class TableService<T> : ITableService<T> where T : class
    {
        private readonly ITableRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public TableService(ITableRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<T>> GetDataAsync()
        {
            return await _repository.GetDataAsync();
        }

        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task SaveDataAsync(T entity)
        {
            await _repository.SaveDataAsync(entity);
            _unitOfWork.Commit();
        }

        public async Task UpdateDataAsync(T entity)
        {
            _repository.UpdateData(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
