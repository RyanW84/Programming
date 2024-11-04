/* create an array of three names
 * ask the user which number to select.
 * When the user gives a number, return that name.
 * Make sure to check for invalid numbers
 */
bool isValidNumber;
int number;
string[] firstName = new string[] { "James", "Dave", "Steve" };
do
{
    Console.Write("\n\tChoose a number between 0 and 2? ");
    string? numberText = Console.ReadLine();
    isValidNumber = int.TryParse(numberText, out number); //int has been removed as variable has been declared at beginning
    if (number < 0 || number > 2)
    {
        isValidNumber = false;
        Console.WriteLine("\n\tPlease enter a number between 0 and 2\n");
    }
    else if (isValidNumber == false)
    {
        Console.WriteLine("\n\tletters are not allowed: \n\tTry inputting a NUMBER between 0 & 2");
    }
} while (isValidNumber == false);

Console.WriteLine($"\tYour selection is {number}: {firstName[number]}");
