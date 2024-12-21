using BattleshipLibraryV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        Console.ReadLine();
    }

    private static void WelcomeMessage()
    {
        Console.WriteLine("\tWelcome to Battleship Lite");
        Console.WriteLine("\tCreated by Ryan Weavers");
        Console.WriteLine();
    }

    private static PlayerInfoModel CreatePlayer()
    {

    }
}
