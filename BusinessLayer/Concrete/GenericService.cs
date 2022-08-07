using BusinessLayer.Abstract;
using DataAccessLayer.Repository.Abstract;
using DataAccessLayer.UnitOfWorks.Absract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public GenericService(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<T> AddAsync(T t)
        {
            await _repository.AddAsync(t);
            await _unitOfWork.CommitAsync();
            return t;
        }

        public void Delete(T t)
        {
            _repository.Delete(t);
           _unitOfWork.CommitAsync();
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Update(T t)
        {
            _repository.Update(t);
            _unitOfWork.Commit();
        }

       
    }
}