

/* Homework Assignment: For Loops
 * Ask the user for a comma separated list of first Names (No Spaces)
 * Split the string into a string array
 * loop through the array
 * print "Hello <name>" 
 * to the console
 * for each peron
 */

Console.WriteLine("Enter a CSV list of names (No Spaces)");
string data = Console.ReadLine();
string[] firstNames = data.Split(",");
Console.WriteLine("");

for (int i = 0; i < firstNames.Length; i++)
{
 
    Console.WriteLine($"Hello {firstNames[i]}");
}




