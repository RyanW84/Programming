string? firstName;
string exitText;

/* Homework Assignment - Do While Loops
* Create a console application that asks the user for their name
*Welcome (me) Tim as professor, or anyone else as student
*Do this until the user types exit
*
*/

do
{
    Console.Write("\nWhat is your first name? ");
    firstName = Console.ReadLine();
    if (firstName.ToLower() == "tim")
    {
        Console.WriteLine($"\nHello Professor {firstName}");
    }
    else
    {
        Console.WriteLine($"\nHello Student {firstName}");
    }
    Console.Write("\nDo you wish to continue? if not type exit :");
    exitText= Console.ReadLine();
}
while (exitText.ToLower()!= "exit");



