using System;

namespace Oop05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ICircle circle = new Circle(5);
            IRectangle rectangle = new Rectangle(4, 6);

            circle.DisplayShaoedInfo();
            rectangle.DisplayShaoedInfo();
            #endregion







        }
    }
}