using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop05
{
    public class RegularUser : User
    {
        public RegularUser(string name) : base(name) { }

        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }

}
