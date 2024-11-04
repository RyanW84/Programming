using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPracticeAreaCalculator
{
    public static class AreaCalculator
    {
        public static double RectangleArea(double x, double y)
        {
            Console.WriteLine("Calculate the Area of a Square or Rectangle");
          return x * y;
          //Console.WriteLine($"The area is{x * y}" );
        }
    }
}
