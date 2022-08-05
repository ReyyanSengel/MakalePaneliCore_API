using DataAccessLayer.AppDbContext;
using DataAccessLayer.Repository.Abstract;
using Entity_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.Concrete
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(Context context) : base(context)
        {
        }
    }
}
