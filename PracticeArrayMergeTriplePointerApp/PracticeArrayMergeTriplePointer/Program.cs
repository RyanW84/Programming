using System;

class Program
{
    public static void Main()
    {
        int[] a1 = new int[] { 1, 2, 3, 6, 5 };
        int[] a2 = new int[] { 24, 54, 85, 63, 76, 63, 75, 84 };
        Array.Sort(a1);

        Array.Sort(a2);
        int[] a3 = new int[a1.Length + a2.Length];
        Console.WriteLine($"The length of the output array is {a3.Length}");
        int a1Pointer = 0; ;
        int a2Pointer = 0;
        int a3Pointer = 0;
        if (a1.Length == 0)
        {
            Console.WriteLine(a1);
        }
        else if (a2.Length == 0)
        {
            Console.WriteLine(a2);
        }
        while (a1Pointer <= a1.Length - 1)
        {

            if (a1[a1Pointer] < a2[a2Pointer])
            {
                a3[a3Pointer] = a1[a1Pointer];
                a1Pointer++;
                a3Pointer++;
            }
            else if (a1[a1Pointer] > a2[a2Pointer])
            {
                a3[a3Pointer] = a2[a2Pointer];
                a2Pointer++;
                a3Pointer++;
            }
            else if (a1[a1Pointer] == a2[a2Pointer])
            {
                a3[a3Pointer] = a1[a1Pointer];
                a3Pointer++;
                a3[a3Pointer] = a2[a2Pointer];
                a1Pointer++;
                a2Pointer++;
                
            }
        }
        if (a2Pointer < a2.Length)
        {
            for (; a2Pointer < a2.Length; a2Pointer++)
            {
                a3[a3Pointer] = a2[a2Pointer];
                a3Pointer++;
            }
        }
        else if (a1Pointer < a1.Length)
        {
            for (; a1Pointer < a1.Length; a1Pointer++)
            {
                a3[a3Pointer] = a1[a1Pointer];
                a3Pointer++;
            }
        }

        for (int i = 0; i < a1.Length; i++)
        {
            Console.WriteLine(a3[i]);
        }
    }
}