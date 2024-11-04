/*  Write a program that gets a natural number N. 
*   In the next N lines there is only one number in each line. 
*   Output the total sum of all of the entered numbers.
*/

using System;

class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Enter how many numbers to be Calculated 'N': ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter the numbers to add({i}): ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j <= numbers.Length - 1; j++)
        {
            result += numbers[j];
        }
        Console.WriteLine($"The result is: {result}");
    }
}