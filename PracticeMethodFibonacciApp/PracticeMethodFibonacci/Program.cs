using System;
using System.Runtime.CompilerServices;
using PracticeMethodFibonacci;
class Program
{
    private static void Main(string[] args)
    {
        int userN = 0;
        while (userN != null)
        {
            Console.Write("Enter the Fibonacci Power: ");
            userN = Convert.ToInt32(Console.ReadLine());
            CalculateFibonacci.CalcFibon(userN);

            //bool isValidNumber;
            //int output;
            //do
            //{
            //    Console.Write("How many in the party? ");
            //    string inputText = Console.ReadLine();
            //    isValidNumber = int.TryParse(inputText, out output);
            //}
            //while (isValidNumber == false);
            //return output;
        }
    }
}
