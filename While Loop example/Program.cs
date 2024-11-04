using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            //int k = 0;
            while (i < 3)
            {
                Console.WriteLine("This is a while loop - so while I is less than 3 it executes code " + i);
               i++;
            }
            Console.WriteLine("\n");
            do
            {
                Console.WriteLine("This is a do while loop - this is guaranteed to execute at least once " + j);
                j++;
            }
            while (j <= 0);
            Console.WriteLine("\n");
            for (int k = 0;k< 2;k++)
            {
                Console.WriteLine("This is a for loop - for loops are used to execute a block of code a specified number of times " +k);
            }
            Console.ReadKey();
        }
    }
 }



