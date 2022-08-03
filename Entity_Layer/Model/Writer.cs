using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Model
{
    public class Writer: BaseEntity
    {
       
        public string Surname { get; set; }
        public string Mail { get; set; }
        public List<Product> Products { get; set; }
    }
}
