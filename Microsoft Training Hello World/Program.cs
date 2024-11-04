using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft_Training_Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World\n");
            Console.ReadKey();
            Console.WriteLine("Use of Strings:");
            String aFriend = "Bill";
            Console.WriteLine(aFriend);
            Console.ReadKey();
            aFriend = "Changed to Maira\n";
            Console.WriteLine(aFriend);
            Console.ReadKey();
            aFriend = "Maira\n";
            Console.WriteLine("Adding strings in speechmarks:");
            Console.WriteLine("Hello " + aFriend);
            Console.ReadKey();
            string firstFriend = "Maria";
            string secondFriend = "Sage";
            Console.WriteLine($"Multiple stings and lengths: \nMy Friends are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters ");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters");
            Console.ReadKey();
            Console.WriteLine("\nTrimming Text:");
            String greeting = "     Hello World!     ";
            Console.WriteLine($"[{greeting}]");
            String trimmedGreetingStart = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreetingStart}]");
            String trimmedGreetingEnd = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreetingEnd}]");
            String trimmedGreetingBoth = greeting.Trim();
            Console.WriteLine($"[{trimmedGreetingBoth}]");
            Console.ReadKey();
            Console.WriteLine("\nReplacing text:\n");
            String sayHello = "Hello World!\n";
            Console.WriteLine(sayHello);
            Console.ReadKey();
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine($"Replaced Text From Hello to Greetings:\n{ sayHello}");
            Console.ReadKey(true);
        }
    }
}
