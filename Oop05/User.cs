using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop05
{
    public abstract class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public abstract Discount GetDiscount();
    }

}
