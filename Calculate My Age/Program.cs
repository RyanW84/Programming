using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_My_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime MyAge;
            Console.WriteLine("Enter your Date of Birth [Format YYYY-MM-DD]");
            MyAge = Convert.ToDateTime(Console.ReadLine());
            int years=Convert.ToInt32((DateTime.Now.Subtract(MyAge).TotalDays))/360;
            Console.WriteLine("Your Age is " + years + " Years");
            Console.ReadKey();
        }
    }
}
