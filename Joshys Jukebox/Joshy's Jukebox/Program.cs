using System;

int shuffleCount=0;
bool shuffled;
int albumPointer = 0;
string menuChoice;
string[] albums =
            {
                "(1) Master Of Puppets by Metallica",
                "(2) Paranoid by Black Sabbath",
                "(3) Reign in Blood by Slayer",
                "(4) Ride the Lightning by Metallica",
                "(5) Killers by Iron Maiden",
                "(6) Rust In Peace by Megadeath",
                "(7) British Steel by Judas Priest",
                "(8) The Number of the Beast by Iron Maiden",
                "(9) Ace of Spades by Motorhead",
                "(10) Holy Diver by Dio",
                "(11) Joshua Tree by U2",
                "(12) Rumours by Fleetwood Mac",
                "(13) Tracy Chapman by Tracy Chapman",
                "(14) Dark side of the moon by Pink Floyd",
                "(15) Hot Fuss by The Killers",
                "(16) Back to Black by Amy Winehouse",
                "(17) Californication by Red Hot Chili Peppers",
                "(18) Dookie by Greenday",
                "(19) Born this way by Lady Gaga",
                "(20) Automatic for the People by R.E.M",
                "(21) Jagged little pill by Alanis Morisette",
                };
int lastIndex = albums.Count() - 1;
void Shuffler()
{

    while (lastIndex >= 0)
    {
        shuffled = true;
        string tempValue = albums[lastIndex];
        int randomIndex = new Random().Next(0, lastIndex);
        albums[lastIndex] = albums[randomIndex];
        albums[randomIndex] = tempValue;
        lastIndex--;
        shuffleCount++;
    }

    //shuffled = true;
}

shuffled = false;
Console.WriteLine("Welcome to Joshy's Jukebox \n");
do
    Shuffler();
while (shuffled == false);
Console.WriteLine($"The albums have now been shuffled");
{
    Console.WriteLine($"\nThe album to listen to this week is:\n\n{albums[albumPointer]}");
    //Console.WriteLine("\nThis is the shuffled contents of the Array:\n{0}", string.Join("\n", albums));
    do
    {
        Console.Write("\nDo you wish to shuffle again? (Y or N)");
        menuChoice = Console.ReadLine();
        albumPointer++;
        Console.Clear();
        Console.WriteLine($"\nThe Next album to listen to is:\n\n{albums[albumPointer]}");
        //Console.WriteLine($"Album Pointer:{ albumPointer}");
    }
    while (menuChoice.ToLower() == "y" && albumPointer < albums.Count() - 1);
    {
        Console.WriteLine("\nYou have reached the end of the albums, or have decided to exit");
    }
}




