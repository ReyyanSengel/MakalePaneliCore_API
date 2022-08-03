using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Model
{
   public class Product: BaseEntity
    {
        
        public string Subject { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int WriterID { get; set; }
        public Category Category { get; set; }
        public Writer Writer { get; set; }

    }
}
