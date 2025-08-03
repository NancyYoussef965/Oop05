using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop05
{
    internal class Circle:ICircle
    {
        public double Radius { get; }
        public Circle (double radius)
        {
            Radius = radius;
        }


        public double area => Math.PI * Radius * Radius;

        public void DisplayShaoedInfo()
        {
            Console.WriteLine("Shape: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {area:F2}");
            Console.WriteLine("--------------------------");
        }
    }
}
