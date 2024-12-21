using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStaticClassCalculations
{
    public static class Menu
    {
        public static void MenuMethod()
        {
            string menuChoice;
            int menuOption;
            double result;
            double x;
            double y;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Calculation App");
                Console.WriteLine("(1) Addition");
                Console.WriteLine("(2) Subtract");
                Console.WriteLine("(3) Multipy");
                Console.WriteLine("(4) Divide");
                Console.WriteLine("(5) Exit");
                Console.Write("Enter your choice here: ");
                menuChoice = Console.ReadLine();
                bool isInt = int.TryParse(menuChoice, out menuOption);

                if (menuOption == 1)
                {
                    Console.Clear() ;
                    Console.WriteLine("\nAddition Chosen\n");
                    x = RequestData.GetADouble("Please enter your first number: ");
                    y = RequestData.GetADouble("\nPlease enter your second number: ");
                    result = CalculateData.Add(x, y);
                    Console.WriteLine($"\nThe addition of {x} and {y} is: {result}\n");
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                }
                else if (menuOption == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nSubtraction Chosen\n");
                    x = RequestData.GetADouble("Please enter your first number: ");
                    y = RequestData.GetADouble("\nPlease enter your second number: ");
                    result = CalculateData.Subtract(x, y);
                    Console.WriteLine($"\nThe subtraction of {x} and {y} is: {result} \n");
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                }
                else if (menuOption == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\nMultiplication Chosen\n");
                    x = RequestData.GetADouble("Please enter your first number: ");
                    y = RequestData.GetADouble("\nPlease enter your second number: ");
                    result = CalculateData.Multiply(x, y);
                    Console.WriteLine($"\nThe Multiplication of {x} and {y} is: {result}\n");
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                }
                else if (menuOption == 4)
                {
                    Console.Clear();
                    Console.WriteLine("\nDivision Chosen\n");
                    x = RequestData.GetADouble("Please enter your first number: ");
                    y = RequestData.GetADouble("\nPlease enter your second number: ");
                    result = CalculateData.Divide(x, y);
                    Console.WriteLine($"\nThe Division of {x} and {y} is: {result}\n");
                    Console.WriteLine("Please press any key to continue...");
                    Console.ReadKey();
                }
                else if (menuOption != 5)
                {
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter a valid menu choice");
                }


                while (isInt == false)
                {
                    Console.WriteLine("\nInvalid Number\n");
                    Console.Write("Please choose using a number or enter 5 to exit: ");

                    menuChoice = Console.ReadLine();
                    isInt = int.TryParse(menuChoice, out menuOption);
                }
            }
            while (menuOption != 5);
        }
    }
}

