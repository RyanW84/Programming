using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeworkMethodWelcomeUser;

public static class ConsoleMessages
{
    public static void Welcome()
    {
        //string greeting = "Welcome";
        Console.WriteLine($"Welcome");

    }
    public static string GetUsersName()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        return name;
    }
    public static void SayHi(string firstName)
    {
        Console.Write($"Hello {firstName}");
    }
}
