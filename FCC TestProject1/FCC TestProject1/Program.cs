using System;

namespace FCC_TestProject1;

internal class Program
{
    static void Main(string[] args)
    {
        //string[] fraudulentOrderIDs = new string[3];
        //{
        //    fraudulentOrderIDs[0] = "A123";
        //    fraudulentOrderIDs[1] = "B456";
        //    fraudulentOrderIDs[2] = "C789";
        //    fraudulentOrderIDs[3] = "D000";
        //}

        //string[] fraudulentOrderIDs = ["A123", "B456", "C789"];

        //Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        //Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        //Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        //fraudulentOrderIDs[0] = "F000";

        //Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        //Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

        //string[] names = { "Rowena", "Robin", "Bao" };
        //foreach (string name in names)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine(name);
        //}

        //int[] inventory = { 200, 450, 700, 175, 250 };

        //int sum = 0;
        //int bin = 0;

        //foreach (int items in inventory)
        //{
        //    sum += items;
        //    bin++;
        //    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        //}
        //Console.WriteLine($"We have {sum} items in inventory.");

        Random dice = new Random();
        int roll = dice.Next(1, 7);
        Console.WriteLine(roll);

        Random adice = new Random();
        int aRoll = adice.Next(1, 10);
        Console.WriteLine(aRoll);

        int number = 7;
        string text = "seven";

        Console.WriteLine(number);
        Console.WriteLine();
        Console.WriteLine(text);

        Random bdice = new Random();
        int roll1 = bdice.Next();
        int roll2 = bdice.Next(101);
        int roll3 = bdice.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");

        dice = new Random();
        dice.GetHashCode();

        int firstValue = 500;
        int secondValue = 600;
        int largerValue = System.Math.Max(firstValue, secondValue);

        Console.WriteLine($"The larger value is: {largerValue}");
    }
}
