using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace RuthsCarpentryCalculator;
{
string menuChoice = "";
    while (menuChoice != "x")
{
    displayMenu();
    menuChoice = Console.ReadLine();

    if (menuChoice == "1")
    {
        Console.Clear();
        Console.WriteLine("\tCalculate the Area of a Rectangle or Square\n");
        Console.WriteLine("\nPlease input the width of the shape");
        float squareWidth = 0.0f;
        squareWidth = Single.Parse(Console.ReadLine());
        Console.WriteLine("\nPlease input the length of the shape");
        float squareLength = 0.0f;
        squareLength = Single.Parse(Console.ReadLine());
        float squareArea = squareWidth * squareLength;
        Console.WriteLine($"\nThe Area of the shape is {squareArea}");
        Console.ReadKey(); //This was originally Console.Read which caused the "Please enter a correct option" error
    }
    else if (menuChoice == "2")
    {
        Console.Clear();
        Console.WriteLine("\t Calculate the Area of a Circle");
        Console.WriteLine("\n\nEnter the Radius of the Circle:");
        double circleRadius = Convert.ToDouble(Console.ReadLine());
        double circleArea = Math.PI * circleRadius * circleRadius;
        circleArea = Math.Round(circleArea, 2); // Rounds to two decimal places

        Console.WriteLine("\nThe Area of the circle is:\n" + circleArea);
        Console.ReadKey();
    }
    else if (menuChoice == "x")
    {
        Console.Clear();
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Please enter a correct option");
        Console.ReadKey();
    }
}
void displayMenu()
{
    Console.Clear();
    Console.WriteLine("\tWelcome to Ruth's Carpentry Calculations!\n");
    Console.WriteLine("1 Calculate the Area of a Rectangle or Square");
    Console.WriteLine("2 Calculate the Area of a Circle");
    Console.WriteLine("3 Calculate the Area of a Triangle");
    Console.WriteLine("4 Calculate the Square of a floor");

    Console.WriteLine("X to exit");
}
}
//class areaCalculator();
//{
//
//}
