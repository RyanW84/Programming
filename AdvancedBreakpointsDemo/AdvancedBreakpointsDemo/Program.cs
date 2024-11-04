using System;

namespace ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            RunsALot();
            Console.ReadLine();
        }

        private static void RunsALot()
        {
            long total = 0;
            int test = 0;
            for (int i = 0; i <= 100; i++)
            {
                total += i;
                Console.WriteLine($"The total is {i}");
                try
                {
                    test = i+5;
                }
                catch (Exception)
                {

                    Console.WriteLine("There was an Exception");
                }
            }
           
        }
    }
}