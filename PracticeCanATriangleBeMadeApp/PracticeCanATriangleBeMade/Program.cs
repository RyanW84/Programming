

using System;

class Program
{
    public static void Main(String[] args)
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        if ((A + B > C) && (B + C > A) && (A + C > B))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

our current approach reads three separate integers from the console, but the input is provided as a single string with numbers separated by spaces. You need to:

Read the entire input line as a string.
Split the string into individual components to extract the numbers.
Parse these components into integers.
This will allow you to correctly check the triangle inequality conditions.