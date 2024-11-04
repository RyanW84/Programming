using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MethodsPracticeAreaCalculator;

public class MenuSystem()
{
    public static void MainMenu();
{
    Console.Clear();
    Console.WriteLine("\tWelcome to Ryan's Area Calculator");
    Console.WriteLine("Please make a choice:");
    Console.WriteLine("(1) Square / Rectangle");
    Console.WriteLine("(2) Circle");
    Console.WriteLine("(3) Triangle");
    Console.WriteLine("(4) Exit the App");
    Console.Write("\r\nPlease select an option");
    switch (Console.ReadLine());
    {
        case "1":
            MethodsPracticeAreaCalculator.AreaCalculator.RectangleArea();
            return true;
        case "2":
            Console.WriteLine("Circle");
            return true;
        case "3":
            Console.WriteLine("Triangle");
            return true;
        case "4":
            return false;
        default:
            return true;
        }

    }
}