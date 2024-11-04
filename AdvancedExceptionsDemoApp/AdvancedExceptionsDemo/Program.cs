using System;
using System.Runtime.CompilerServices;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            try
            {
                DifferentMethod();

                Console.Write("What is your name? ");
                name = Console.ReadLine();
                ComplexMethod(name);
                SimpleMethod();

            }
            catch (InvalidOperationException ex) //most specif first, then most general
            {
                Console.WriteLine("You should not be calling these methods");
                Console.WriteLine(ex.Message);
            }
            catch (NotImplementedException)
            {
                Console.WriteLine();
            }
            catch (Exception ex) when (name.ToLower() == "tim") //general type  e.g car
            {

                Console.WriteLine("you used Tim's name!");
            }
            catch (Exception ex) //general type  e.g car
            {

                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("I always Run");// Connect to a db and it crashes, the finally block can run the close out code to prevent memory hole / Close connection
            }
            Console.ReadLine();
        }

        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "tim")
            {
                throw new InsufficientMemoryException("Tim is too tall for this method");
            }
            else
            {
                throw new ArgumentException("This person isn't Tim");
            }
        }

        private static void DifferentMethod()
        {
            Console.WriteLine("This is the different method working properly");
        }

        private static void SimpleMethod()
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod"); // more specifc type e.g Toyota
        }
    }
}

//Use Example - when connecting to a DB you can catcha failure to connect, or network error-  and you can retry the connection or fallback to a different DB