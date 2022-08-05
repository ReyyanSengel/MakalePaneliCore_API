using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.DTOs
{
    public class WriterDTO:BaseDTO
    {
        public string Surname { get; set; }
        public string Mail { get; set; }
    }
}
