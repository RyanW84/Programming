using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStaticClassCalculations
{
    public static class RequestData
    {
        public static double GetADouble(string message)
        {
            Console.WriteLine(message);
            string? numberText = Console.ReadLine();
            double output;

            bool isDouble = double.TryParse(numberText, out output);

            while (isDouble == false)
            {
                Console.WriteLine("Invalid Number");
                Console.WriteLine(message);

                numberText = Console.ReadLine();

                isDouble = double.TryParse(numberText, out output);
            }
            return output;
        }
    }
}
