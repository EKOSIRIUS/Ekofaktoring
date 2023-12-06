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
    public class PageService<T> : IPageService<T> where T : class
    {
        private readonly IPageRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public PageService(IUnitOfWork unitOfWork, IPageRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<T> GetPageAsync()
        {
            return await _repository.GetPageAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
