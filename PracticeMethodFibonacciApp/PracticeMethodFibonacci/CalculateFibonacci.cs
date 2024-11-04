using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMethodFibonacci
{
    internal class CalculateFibonacci
    {
        public static int CalcFibon(int n)
        {

            //Fibonacci sequence 0, 1, 1, 2, 3, 5, 8, 13, 21
            int a = 0;
            int b = 1;
            int c = 0;
            //n = 0;

            if (n == 0)
            {
                Console.WriteLine($"The value is {n}");
            }
            if (n == 1)
            {
                Console.WriteLine($"The value is {n}");
            }

            if (n >= 2)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Values before the sum: a = {a}, b = {b}, c = {c}\n");
                    c = a;
                    a = b;
                    b = b + c;
                    Console.WriteLine($"Values after the sum: a = {a}, b = {b}, c = {c}\n");
                }
                Console.WriteLine($"Poo The result is {a}");
                return a;
            }
            return a;

        }

    }
}
