
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

//static void main

try
{
    BadCall();

    }
catch (Exception ex)
{
    Console.WriteLine("method call");
    Console.WriteLine(ex.Message);
}
Console.ReadLine();

static void BadCall()
{
    int[] ages = new int[] { 1, 3, 5 };

    for (int i = 0; i <= ages.Length; i++) //cause out of array stack error (<=.length)
    {
        try
        {
            Console.WriteLine($"array slot {i} is {ages[i]}");
        }
        catch (Exception ex) //stores the exception value in "ex"
        {
            Console.WriteLine("inside bad call error"); //handled exception --doesn't pause program
            Console.WriteLine(ex.Message); //Can use ex.message for a succinct error description
            throw new Exception("There was an error handling our array",ex);
        }
    }
}
