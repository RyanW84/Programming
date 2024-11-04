using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NameAndAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            string LastName;
            int Age;
            string HairColour;
            string cmd = "";
            string Path = @"C:\Users\Ryanw\OneDrive\Desktop\Programming\NameAndAddress\MyTest.txt";
            while (cmd != "x")
            {
                DisplayMenu();
                cmd = Console.ReadLine();
                if (cmd == "1")
                {
                    ClearScreen();
                    Console.WriteLine("Please Enter Your First Name");
                    FirstName = Console.ReadLine();
                    Console.WriteLine("Please Enter Your Last Name");
                    LastName = Console.ReadLine();
                    Console.WriteLine("Please Enter Your Age");
                    Age = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Please Enter Your Hair Colour");
                    HairColour = Console.ReadLine();



                    if (!File.Exists(Path))
                    {
                        //Create A File to write to
                        System.IO.FileStream sw = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.ReadWrite);

                    }
                    File.AppendAllText(Path, "First Name " + FirstName + "," + "Last Name " + LastName + "," + "Age " + Age + "," + "Hair Colour " + HairColour + "\n");

                }

                else if (cmd == "2") //Go to Search Records
                    {
                    ClearScreen();    
                    Console.WriteLine("Search Records");
                        //We read all the lines from the file
                        IEnumerable<string> lines = File.ReadAllLines(Path);

                        //We read the input from the user
                        Console.Write("Enter the word to search: ");
                        string input = Console.ReadLine().Trim();

                        //We identify the matches. If the input is empty, then we return no matches at all
                        IEnumerable<string> matches = !String.IsNullOrEmpty(input)
                                                      ? lines.Where(line => line.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                                                      : Enumerable.Empty<string>();

                        //If there are matches, we output them. If there are not, we show an informative message
                        Console.WriteLine(matches.Any()
                                          ? String.Format("Matches:\n> {0}", String.Join("\n> ", matches))
                                          : "There were no matches");
                    Console.ReadKey();
                    }
                else if (cmd == "3") // Go to Replace records
                {
                    ClearScreen();
                }
                else if (cmd == "x") //Exit to Menu
                {
                    ClearScreen();
                }

                else
                {
                    ClearScreen();
                    Console.WriteLine("Please Enter a correct option");

                }
            }
            void DisplayMenu()
            {
                ClearScreen();
                Console.WriteLine("\tData Entry Menu\n\n\n");
                Console.WriteLine("1. Enter New Record:");
                Console.WriteLine("2. Search for a record");
                Console.WriteLine("3. Amend a record");
                Console.WriteLine("");
                Console.WriteLine("Enter 'X' to finish");
            }
            void ClearScreen()
            {
                Console.Clear();
            }

        }
    }
}
