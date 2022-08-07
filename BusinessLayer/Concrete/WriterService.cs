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
    public class WriterService : GenericService<Writer>, IWriterService
    {
        public WriterService(IGenericRepository<Writer> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
