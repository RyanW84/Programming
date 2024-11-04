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
            
            Console.WriteLine("Please enter Name");
            string Name;
            Name = Console.ReadLine();
            if(Name == "Ryan" ||Name=="Ruth")  //Ryan is a great name
            {
                Console.WriteLine("Hello again");
            }
            else if (Name == "Neal")
            { 
                Console.WriteLine("{1} That's a cool name {0}", Name, "sorry ryan"); //Neal is not a cool name
            }
            else
            {
                Console.WriteLine("Nice to meet you " + Name); 
            }

            for (int i = 0; i < 10; i++)
                Console.WriteLine("this is i:{0} " , i);

            int f = 10;
            while (f < 20)
                {
                Console.WriteLine("this is f:{0} ", f);
                f++;
            }
            
            Console.ReadKey();           /*
             * Ryan is a great name
             * Neal is not
             */
        }
    }
}
