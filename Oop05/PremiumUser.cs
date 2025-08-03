using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop05
{
    public class PremiumUser : User
    {
        public PremiumUser(string name) : base(name) { }

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
