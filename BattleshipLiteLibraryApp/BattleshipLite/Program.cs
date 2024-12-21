using BattleshipLiteLibrary;
using BattleshipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite; // video 88 30:21

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        PlayerInfoModel activePlayer = CreatePlayer("\n\tPlayer 1");
        PlayerInfoModel opponent = CreatePlayer("\n\tPlayer 2");
        PlayerInfoModel winner = null;

        do
        {
            // Display grid from activePlayer on where they fired
            DisplayShotGrid(activePlayer);

            // Determine shot results
            RecordPlayerShot(activePlayer, opponent);

            // Determine if the game is still active
            bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

            // If over , set activePlayer as the winner
            // Else, swap positions (activePlayer to opponent
            if (doesGameContinue == true)
            {
                // Swap positions using a temp variable
                //PlayerInfoModel tempHolder = opponent;
                //opponent = activePlayer;
                //activePlayer = tempHolder;

                // Swap positions
                // Use Tuple (Prevents needing a temporary spaceholder as it doesn't overwrite it swaps)
                (activePlayer, opponent) = (opponent, activePlayer);
            }
            else
            {
                winner = activePlayer;
            }

        } while (winner == null);

        IdentifyWinner(winner);

        Console.ReadLine();
    }

    private static void IdentifyWinner(PlayerInfoModel winner)
    {
        Console.WriteLine($"\n\tCongratulations to {winner.UsersName} for winning!");
        Console.WriteLine($"\n\t{winner.UsersName} took {GameLogic.GetShotCount(winner)} shots.");
    }

    private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
    {

        bool isValidShot = false;
        string row = "";
        int column = 0;

        do
        {
            string shot = AskForShot();
            (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
            isValidShot = GameLogic.ValidateShot(activePlayer, row, column);

            if (isValidShot == false)
            {
                Console.WriteLine("\n\tInvalid shot location, please try again.");
            }

        } while (isValidShot == false); //better to use this than (!isValidShot) as its more visible and understandable to humans

        bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

        GameLogic.MarkShotResult(activePlayer, row, column, isAHit);
    }

    private static string AskForShot()
    {
        Console.Write("\n\tPlease enter your shot selection: ");
        string output = Console.ReadLine();

        return output;
    }

    private static void DisplayShotGrid(PlayerInfoModel activePlayer)
    {
        string currentRow = PlayerInfoModel.ShotGrid[0].SpotLetter;

        foreach (var gridSpot in PlayerInfoModel.ShotGrid)
        {
            if (gridSpot.SpotLetter != currentRow)
            {
                Console.WriteLine();
                currentRow = gridSpot.SpotLetter;
            }

             
            if (gridSpot.Status == Enums.GridSpotStatus.Empty)
            {
                Console.Write($" {gridSpot.SpotLetter}{gridSpot.SpotNumber} ");
            }
            else if (gridSpot.Status == Enums.GridSpotStatus.Hit)
            {
                Console.Write(" X ");
            }
            else if (gridSpot.Status == Enums.GridSpotStatus.Miss)
            {
                Console.Write(" O ");
            }
            else
            {
                Console.Write(" ? ");
            }

        }
    }

    private static void WelcomeMessage()
    {
        Console.WriteLine("\tWelcome to Battleship Lite");
        Console.WriteLine("\tCreated by Ryan Weavers");
        Console.WriteLine();
    }

    private static PlayerInfoModel CreatePlayer(string playerTitle)
    {
        PlayerInfoModel output = new PlayerInfoModel(); //instantiate a new version of the class

        Console.WriteLine($"\n\tPlayer information for {playerTitle}");

        //Ask the user for their name
        output.UsersName = AskForUsersName();

        //Load up the shot grid
        GameLogic.InitialiseGrid(output);

        //Ask the user for their 5 ship placements
        PlaceShips(output);

        //Clear the screen
        Console.Clear();

        return output;
    }
    private static string AskForUsersName()
    {
        Console.Write("\n\tWhat is your name: ");
        string? output = Console.ReadLine();

        return output;
    }

    private static void PlaceShips(PlayerInfoModel model)
    {
        do
        {
            Console.Write($"\n\tWhere do you want to place ship number {PlayerInfoModel.ShipLocations.Count + 1}: ");
            string location = Console.ReadLine();

            bool isValidLocation = GameLogic.PlaceShip(model, location);

            if (isValidLocation == false)
            {
                Console.WriteLine("\n\tThat was not a valid location. Please try again.");
            }

        } while (PlayerInfoModel.ShipLocations.Count > 5);
    }

}