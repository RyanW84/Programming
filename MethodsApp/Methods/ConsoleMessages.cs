using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods;
//You can use "Using namespace Methods; to remove the first lot of curly braces

//Every single line is indentned by 4 spaces - most code will be 8 spaces deep.

//Only works in .Net6++


public static class ConsoleMessages //allows to make a call directly to the method, rather than instantiation

    //Use control +"." to rename in other places and or change filename
{
    public static void SayHi(string firstName) //Pascal casing
    {
        Console.WriteLine($"Hello {firstName}");
        Console.WriteLine("I hope you are having a good day.");
    }

    public static string GetUsersName() // changed from void as we want to return a string value
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();

        return name;
    }

    //Tuple - return two or more parameters as return value
    public static (string firstName, string lastName) GetFullName()
    {
        Console.Write("What is your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name: ");
        string lastName = Console.ReadLine(); 

        return (firstName, lastName);
    }
    public static void SayGoodbye()
    {
        Console.WriteLine("Goodbye, my user.");
        Console.WriteLine("Thank you for visiting.");
        Console.WriteLine("I cannot wait to see you again");
    }
    // public is modifier
    // static - call it directly / Static vs instantiation - learn later
    // Void - return value - null/
    //Public [anyone can use this stuff]
    //Internal [anyone inside this project can use this stuff]
    //Private [anyone inside of this scope can use it but nobody else]
    //its not meant for security
    //The purpose is to not allow people to call things
    //they really shouldn'
}
