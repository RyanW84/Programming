using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine("Working with integers");
            Console.WriteLine($"a = {a}\nb = {b}");
            Console.ReadKey();
            Console.WriteLine($"c = a + b = {c}");
            Console.ReadKey(); 
            c = a - b;
            Console.WriteLine($"c = a - b = {c}");
            Console.ReadKey();
            c = a * b;
            Console.WriteLine($"c = a * b = {c}");
            Console.ReadKey();
            c = a / b;
            Console.WriteLine($"c = a / b = {c}");
            Console.ReadKey();
            Console.Clear();
            a = 5;
            b = 4;
            c = 2;
            int d = a + b * c;
            Console.WriteLine($"New Values\na = {a}\nb = {b}\nc = {c}\nd = a + b * c");
            Console.ReadKey();
            Console.WriteLine($"d = {d}");    
            Console.ReadKey();
            d = (a + b) * c;
            Console.WriteLine($"d = (a + b) *c = {d}");
            Console.ReadKey(); 
            d = (a + b) -6 *c +(12 *4) / 3 + 12;
            Console.WriteLine($"d = (a + b) -6 *c + (12*4) /3 + 12 = {d}");
            Console.ReadKey();
            a = 7;
            b = 4;
            c = 3;
            d= (a + b) / c;
            Console.WriteLine(d);
            Console.ReadKey();
            Console.Clear();
            int e = (a + b) % c;
            Console.WriteLine("Quotients, Remainders, Min and Max");
            Console.WriteLine($"quotient:{d}");
            Console.WriteLine($"remainder:{e}");
            Console.ReadKey(); 
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"\nThe range is integers is {min} to {max}");
            Console.ReadKey();
            int what = max + 3;
            Console.WriteLine($"\nAn example of overflow [Max+3] {what}");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Working with Double Type");
            double da = 5;
            double db = 4;
            double dc = 2;
            double dd = (da + db) / dc;
            Console.WriteLine($"a = {a}\nb = {b}\nc = {c}\nd = (a +b ) /c: {dd}");
            Console.ReadKey();
            Console.WriteLine("\nFormulae with doubles");
            da = 19;
            db = 23;
            dc = 8;
            dd = (da + db) / dc;
            Console.WriteLine(dd);
            Console.ReadKey();
            double dmax =double.MaxValue;
            double dmin =double.MinValue;
            Console.WriteLine($"\nThe range of doubles are {dmin} to {dmax}");
            Console.ReadKey();
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
            Console.ReadKey();
            decimal decmin =decimal.MaxValue;
            decimal decmax =decimal.MinValue;
            Console.WriteLine($"\nThe range of the decimal type is {decmin} to {decmax}");
            Console.ReadKey();
            da = 1.0;
            db = 3.0;
            Console.WriteLine(da/db);
            Console.ReadKey();
            decimal decc = 1.0M;
            decimal decd = 3.0M;
            Console.WriteLine(decc / decd);
            Console.ReadKey();
            Console.Clear();
            double Pi = Math.PI;
            double Radius = 2.50;
            double Area = Pi * (Radius * Radius);
            Console.WriteLine($"Calculating the area of a circle\n" +
                $"The radius is: {Radius}\n" +
                $"Pi is: {Pi}\n" +
                $"The area is Radius squared, multiplied by Pi: {Area}");
            Console.ReadKey();
            


        }
    }
}
