﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer.Model
{
   public class Category: BaseEntity
    {
       
        public List<Product> Products { get; set; }
    }
}
