using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making Decisions using the IF statement");
            int a = 5;
            int b = 6;
            int c = 4;
            Console.WriteLine($"a is {a}\nb is {b}\n\nis a and b multiplied greater than ten?");
            if (a * b > 10) 
            Console.WriteLine("Yes");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Making If and Else work together \na = {a}\nc = {c}\n\nIf I add a and c what is the result?");
            if (a + c > 10)
                Console.WriteLine("\nThe answer is greater than ten");
            else
                Console.WriteLine("\nThe answer is less than ten");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Multiple Conditions\na = {a}\nb = {b}\nc = {c}\n\nif the three values combine are more than ten AND are the first and second values the same?");
            if ((a + b + c > 10) && (a == b))
            {
                Console.Write("\nThe answer is greater than ten");
                Console.Write(" and the first number is equal to the second");
            }
            else
            {
                Console.Write("\nThe answer is not greater than ten");
                Console.Write(" or the first number is not equal to the second");
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Multiple Conditions\na = {a}\nb = {b}\nc = {c}\n\nif the three values combine are more than ten or are the first and second values the same?");
            if ((a + b + c > 10) || (a == b))
            {
                Console.Write("\nThe answer is greater than ten");
                Console.Write(" or the first number is equal to the second");
            }
            else
            {
                Console.Write("\nThe answer is not greater than ten");
                Console.Write(" or the first number is not equal to the second");
            }
            Console.ReadKey();
            //Point reached on the 18/12/21 at 18:58
        }
        }
    }
