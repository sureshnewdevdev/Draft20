using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatch
{
    public class DiscountProduct : Product
    {
        public decimal Discount { get; set; }
        public decimal GetDiscountPrice()
        {
            return Price - Discount;
        }
    }
     
}
