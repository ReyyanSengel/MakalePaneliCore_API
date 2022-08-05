using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.DTOs
{
    public class ProductDTO:BaseDTO
    {
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public int CategoryID { get; set; }
        public int WriterID { get; set; }
    }
}
