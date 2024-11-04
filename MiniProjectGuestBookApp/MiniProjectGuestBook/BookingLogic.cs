using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectGuestBook;

public class BookingLogic
{
    public static void WelcomeUser()
    {
        Console.WriteLine("Welcome to the Guest Book App");
        Console.WriteLine("****************************");
        Console.WriteLine();
    }

    public static string GetBookingName()
    {
        Console.Write("What name is the booking under? ");
        string? output = Console.ReadLine();
        return output;

    }
    public static int GetBookingSize()
    {
        bool isValidNumber;
        int output;
        do
        {
            Console.Write("How many in the party? ");
            string inputText = Console.ReadLine();
            isValidNumber = int.TryParse(inputText, out output);
        }
        while (isValidNumber == false);
        return output;
    }
    public static (List<string> guests, int totalGuests) GetAllGuests()
    {
        int totalGuests = 0;
        List<string> guests = new List<string>();
        do
        {
            guests.Add(GetBookingName());
            totalGuests += BookingLogic.GetBookingSize();
        }
        while (AskToContinue());
        return (guests, totalGuests);
    }
    public static void DisplayGuests(List<string> guests)
    {
        Console.WriteLine("\nThe guests tonight were: ");
        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }
    }
    public static void DisplayGuestCount(int totalGuests)
    {
        Console.WriteLine("Thank you for coming");
        Console.WriteLine($"The total amount of guests were: {totalGuests}");
    }
    public static bool AskToContinue()
    {
        Console.WriteLine("Are there more guests coming (Y or N): ");
        string continueLooping = Console.ReadLine();
        Console.WriteLine();
        bool output = (continueLooping.ToLower() != "n");
        return output;
    }
}
