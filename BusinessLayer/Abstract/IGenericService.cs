using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T:class
    {
        IEnumerable<T> GetAll();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T t);
        void Update(T t);
        void Delete(T t);
    }
}
