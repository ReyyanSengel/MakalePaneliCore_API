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
    public class WriterRepository : GenericRepository<Writer>, IWriterRepository
    {
        public WriterRepository(Context context) : base(context)
        {
        }
    }
}
