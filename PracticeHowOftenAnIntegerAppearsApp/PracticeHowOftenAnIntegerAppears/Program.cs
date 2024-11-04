using System;
using System.Reflection.PortableExecutable;
using System.Xml;

class Program
{
    public static void Main(string[] args)
    {

        //int[] a = { 4, 5, 4, 3, 2, 1, 3};
        int[] a = new int[100];
        int[] frequency = new int[100];   // Array to store frequency
        int i, j, ctr;  // Variables for size, loop control, and frequency counting
        int n;

        Console.Write("\n\nCount the frequency of each element of an array:\n");
       Console.Write("-------------------------------------------------\n");

       Console.Write("Input the number of elements to be stored in the array :");
        n = Convert.ToInt32(Console.ReadLine());  // Read the number of elements

        Console.Write("Input {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());  // Read elements into the array
            frequency[i] = -1;  // Initialize frequency array with -1
        }

        // Count frequency of each element
        for (i = 0; i <= n; i++)
        {
            ctr = 1;  // Initialize counter to 1
            for (j = i + 1; j <n; j++)
            {
                if (a[i] == a[j])  // If current element matches other elements
                {
                    ctr++;  // Increment frequency counter
                    frequency[j] = 0;  // Mark duplicates by setting their frequency to 0
                }
            }

            if (frequency[i] != 0)  // If not a duplicate
            {
                frequency[i] = ctr;  // Store the frequency
            }
        }

        // Display frequency of each element
       // Console.Write("\nThe frequency of all elements of the array : \n");
        for (i = 0; i <= n; i++)
        {
            if (frequency[i] != 0)  // If frequency is not 0 (indicating duplicate)
            {
                Console.Write("{0} occurs {1} times\n", a[i], frequency[i]);
               // Console.Write($"{a[i]} {frequency[i]}"); // Display element and its frequency
            }
        }
    }
}


