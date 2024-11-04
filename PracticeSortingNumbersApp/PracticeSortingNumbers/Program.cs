/*  
 *  Write a program that gets three natural numbers A, B and C 
 *  from input and outputs the sorted sequence of those numbers.
 *  */

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Number Sorter");
        Console.WriteLine("*************");
        Console.Write("Enter a list of numbers (spaces): ");
        string input = Console.ReadLine();
        Console.Write("The result is: ");
        List<int> inputs = input.Split().Where(x => int.TryParse(x, out _)).Select(int.Parse).ToList();
        inputs.Sort();
        for (int i = 0; i < inputs.Count; i++)
        {
            int number = inputs[i];
            Console.Write($"{number} ");
        }
    }
}