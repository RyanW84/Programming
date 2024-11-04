/*Homework For Each Loop
 * Ask the user for their name,
 * Continue asking for first names until there are no more
 * Loop through each name using ForEach
 * Tell each person Hello on the console
 */
string input;
List<string> output = new List<string>();
Console.Write("Welcome User, please enter your first name: ");
input = Console.ReadLine();
output.Add(input);
Console.WriteLine($"\nHello {input}");

while (true)
{
    Console.WriteLine("\nNow enter some more names or type exit to end ");
    input = Console.ReadLine();
    if (input == "exit")
    {
        break;
    }
    output.Add(input);

}
foreach (string inputLine in output)
{
    Console.WriteLine($"\nHello {inputLine}");
}









