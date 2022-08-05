using BusinessLayer.Abstract;
using DataAccessLayer.Repository.Abstract;
using DataAccessLayer.UnitOfWorks.Absract;
using Entity_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductService : GenericService<Product>, IProductService
    {
        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
