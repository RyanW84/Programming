/*  Write a program that gets a natural number N from input and outputs its middle digit to the screen.
 *  For example, the middle digit of the number 123 is 2, the middle digit of the number 987 is 8.
 */

using System;

class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number to get the middle number: ");
        int N = int.Parse(Console.ReadLine());
        N = N / 10;
        N = N % 10;
        Console.WriteLine($"The middle number is {N}");
    }
}