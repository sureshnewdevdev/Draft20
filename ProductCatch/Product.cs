﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatch
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal Price { get; set; }

        public string GetProductInfo()
        {
            return $"Product ID: {ProductId}, Product Name: {ProductName}, Price: {Price}";
        }
    }
}
