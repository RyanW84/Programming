using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Case_use
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter a character:");
            ch = Convert.ToChar(Console.ReadLine());
            switch (Char.ToLower(ch))
                {
                case 'a': case 'e': case 'i': case 'o':case 'u':
                        Console.WriteLine("\nVowel");
                    break;
                    default:
                    Console.WriteLine("\nNot a Vowel");
                    break ;
            }
            Console.ReadKey();
        }
    }
}
