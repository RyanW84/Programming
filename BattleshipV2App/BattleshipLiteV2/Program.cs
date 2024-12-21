
using BattleshipLibraryV2;
using BattleshipLibraryV2.Models;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Xml;

namespace BattleshipLiteV2
{
    public class DisplayShotResults
    {
        static void Main(string[] args)  // Video 89 - 20:53
        {
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");

            PlayerInfoModel winner = null;

            do
            {
                // Display grid from activePlayer on where they fired
                DisplayShotGrid(activePlayer);
                // ask activeplayer for ashot
                // determine if a valid shot
                // determine shot results

                RecordPlayerShot(activePlayer, opponent);
                // determine if the game should continue

                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                // if over set activeplayer as winner
                // else swap

                if (doesGameContinue == true)
                {
                    // swap using a temp variable
                    //PlayerInfoModel tempHolder = opponent;
                    //opponent = activePlayer;
                    //activePlayer = tempHolder;

                    //using tuple - doesn not overwrite, does not need temp holder
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
            Console.WriteLine($"Congratulations to {winner.UsersName} for winning! ");
            Console.WriteLine($"{winner.UsersName} took {GameLogic.GetShotCount(winner)} shots ");
        }

        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            bool isValidShot = false;
            string row = "";
            int column = 0;

            do
            {
                string shot = AskForShot(activePlayer);
                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    isValidShot = false;
                }

                if (isValidShot == false)
                {
                    Console.WriteLine("\nInvalid shot location, please try again.");
                }

            } while (isValidShot == false);

            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);

            DisplayShotResults(row, column, isAHit);
        }

        private static void DisplayShotResults(string row, int column, bool isAHit)// delete and generate
        {
            Console.WriteLine($"{row} {column} ");
        }

        private static string AskForShot(PlayerInfoModel player)
        {
            Console.WriteLine($"{player.UsersName}, Please enter your shot selection: ");
            string output = Console.ReadLine();

            return output;
        }

        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;

            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter != currentRow)
                {
                    Console.WriteLine("");
                    currentRow = gridSpot.SpotLetter;
                }

                if (gridSpot.Status == Enums.GridSpotStatus.Empty)
                {
                    Console.Write($"{gridSpot.SpotLetter}{gridSpot.SpotNumber}");
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
                    Console.WriteLine(" ? ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("\tWelcome to Battleship Lite");
            Console.WriteLine("\t Created by Ryan Weavers");
            Console.WriteLine();
        }

        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player information for {playerTitle}");

            // Ask the user for thier name
            output.UsersName = AskForUsersName();

            // Load up the shot grid
            GameLogic.InitialiseGrid(output);

            // Ask the user for their 5 ship placements 
            PlaceShips(output);

            // Clear
            Console.Clear();

            return output;
        }

        private static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();
            return output;
        }

        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you want to place ship number {model.ShipLocations.Count + 1}: ");
                string location = Console.ReadLine();

                bool isValidLocation = GameLogic.PlaceShip(model, location);

                if (isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again.");
                }

            } while (model.ShipLocations.Count < 5);
        }
    }
}
