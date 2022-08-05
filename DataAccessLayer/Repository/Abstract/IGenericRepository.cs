using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.Abstract
{
    public interface IGenericRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T t);
        void Update(T t);
        void Delete(T t);




    }
}
