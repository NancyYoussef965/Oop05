using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop05
{
    public class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One 50% Off";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            int pairs = quantity / 2;
            return (price / 2) * pairs;
        }
    }
}
