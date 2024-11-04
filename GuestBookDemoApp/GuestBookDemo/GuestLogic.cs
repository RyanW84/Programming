using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookDemo;

public static class GuestLogic
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Guest Book App");
        Console.WriteLine("*****************************");
        Console.WriteLine();
    }
    public static string GetPartyName()
    {
        Console.Write("What is your party/group name: ");
        string output = Console.ReadLine();
        return output;
    }
    public static int GetPartySize()
    {
        bool isValidNumber;
        int output;
        do
        {
            Console.Write("How many people are in your party: ");
            string partySizeText = Console.ReadLine();
            isValidNumber = int.TryParse(partySizeText, out output);
        } while (isValidNumber == false);
        return output;
    }
    public static bool AskToContinue()
    {
        Console.Write("\nAre there more guests coming (yes/no): ");
        string continueLooping = Console.ReadLine();
        Console.WriteLine();

        bool output = (continueLooping.ToLower() != "no");
        return output;
    }
    public static (List<string> guests, int total) GetAllGuests()
    {
        int totalGuests = 0;
        //string continueLooping;
        List<string> guests = new List<string>();
        do
        {
            guests.Add(GetPartyName());
            totalGuests += GuestLogic.GetPartySize();//did not know this!
        } while (AskToContinue());

        return (guests, totalGuests);

        //while (continueLooping.ToLower() != "no"); -->rather than using yes, use not no to accept any potential yes answers e.g yep, yarp,yeah
    }
    public static void DisplayGuests(List<string> guests)
    {
        Console.WriteLine($"\nThe Guests tonight were: ");
        foreach (string guest in guests)
        {
            Console.WriteLine(guest);
        }
    }
    public static void DisplayGuestCount(int totalGuests)
    {
        Console.WriteLine("\nThank you for everyone who attended.");
        Console.WriteLine($"\nThe total guest count for this evening was:  \n{totalGuests}");
    }
}
