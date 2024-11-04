using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            
            Console.WriteLine("Please enter Name");
            string Name;
            Name = Console.ReadLine();
            if(Name == "Ryan") //Ryan is a great name
            {
                Console.WriteLine("Hello again");
            }
            else if (Name == "Neal")
            { 
                Console.WriteLine("That's a cool name"); //Neal is not a cool name
            }
            else
            {
                Console.WriteLine("Nice to meet you " + Name); 
            }
            Console.ReadLine();
            /*
             * Ryan is a great name
             * Neal is not
             */
        }
    }
}
