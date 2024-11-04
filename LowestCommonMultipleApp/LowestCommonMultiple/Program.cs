using System;

class Program
{
    public static void Main(string[] args)
    {

        int a1 = 4000;
        int a2 = 8000;
        for (int i = 1;i<=1000000000; i++)
        {
            if (i % a1 == 0 && i % a2 == 0)
            {
                Console.WriteLine($"The Lowest Common Multiple is {i}");
                break;
            }

        }
    }
}