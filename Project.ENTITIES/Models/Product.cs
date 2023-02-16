﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        //Relational Properties

        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

        //Special Methods

        public override string ToString()
        {
            return $"{ProductName}..|  Price=>{UnitPrice}";
        }
    }
}
