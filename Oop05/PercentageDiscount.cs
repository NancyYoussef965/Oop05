using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop05
{

    public class PercentageDiscount:Discount
    {
        private decimal percentage;

        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
            Name = $"{percentage}% Percentage Discount";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (percentage / 100);
        }
    }
}
