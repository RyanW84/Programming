using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;

/* 
 * Better Guestbook app
 * Capture info about each guest: (assumption at least one guest and unknown max)
 * First name, Last name, message to the host
 * Once done, loop through each guest and print their info
 */

namespace BetterGuestBook // video 80 24:07
{
    internal class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>(); //variable can live outside of a method - can be accessed - larger scope - depends on how much you're going to use it. Lives for the entire lifecycle of the program.


        static void Main(string[] args)
        {

            GetGuestInformation();

            PrintGuestInformation();


            Console.ReadLine();
        }
        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }
        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();


                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guests coming? (yes/no) ");

                guests.Add(guest);

                Console.Clear();
            }

            while (moreGuestsComing.ToLower() == "yes");
        }
        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}