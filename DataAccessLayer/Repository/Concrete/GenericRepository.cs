using DataAccessLayer.AppDbContext;
using DataAccessLayer.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T:class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public async Task AddAsync(T t)
        {
           await  _context.Set<T>().AddAsync(t);
        }

        public  void Delete(T t)
        {
             _context.Set<T>().Remove(t);
        }

        public IQueryable<T> GetAll()
        {
          return  _context.Set<T>().AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public void Update(T t)
        {
            _context.Set<T>().Update(t);
        }
    }
}
