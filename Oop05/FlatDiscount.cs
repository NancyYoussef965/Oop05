using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop05
{

    public class FlatDiscount:Discount
    {
        private decimal flatAmount;

        public FlatDiscount(decimal flatAmount)
        {
            this.flatAmount = flatAmount;
            Name = $"Flat Discount: {flatAmount} per order";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return flatAmount * Math.Min(quantity, 1); 
        }
    }
}
