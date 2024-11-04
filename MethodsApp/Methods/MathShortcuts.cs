using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y)
        {
            //Console.WriteLine($"The value of {x} + {y} = {x + y}");
            double output = x + y;
            return output;
            //can just do return x + y; to be less verbose
        }
        public static void AddAll(double[] values)
        {
            double result = 0;
            //Int cannot do divide so thats why double was chosen
            //most commonly used with math equations
            //values.Sum();  Linq can do the same as the next line
            foreach (var value in values)
            {
                result += value;
            }
            Console.WriteLine($"The total is {result}");
        }
    }
}
