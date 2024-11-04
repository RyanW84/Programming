/* Create a dictionary list of Employee ID
 * Name that goes with the ID
 * Fill in a few records
 * Ask the user fo their ID
 * return their name
 */

using static System.Runtime.InteropServices.JavaScript.JSType;


Dictionary<string, string> employeeID = new Dictionary<string, string>();
employeeID["1"] = "Ryan Weavers";
employeeID["2"] = "Ruth Weavers";
employeeID["3"] = "Joshy Weavers";
employeeID["4"] = "Lloyd Weavers";
employeeID["5"] = "Freddie Weavers";
employeeID["6"] = "Ronnie Weavers";
employeeID["7"] = "Jack Weavers";
employeeID["8"] = "Julie Weavers";

while (true)
{
    Console.WriteLine("Enter an ID and Name separated by a space \n(or type exit to move to selection");
    string? input = Console.ReadLine();

    if (input == "exit")
    {
        break;
    }

    string[] items = input.Split(','); //, StringSplitOptions.RemoveEmptyEntries);
    if (items.Length != 2)
    {
        Console.WriteLine("Expecting CSV '{ID],{Name} {Surname}'");
        continue;
    }
    //string.Join("", items[1] + items[2]); 
    employeeID.Add(items[0], items[1]);
}

Console.Write("\n\tWhat is your Employee ID Number? ");
string? numberText = Console.ReadLine();

Console.WriteLine($"\tYour selection is {numberText}:{employeeID[numberText]}");

//string? addIDText = Console.ReadLine();
//isValidUserAddID = int.TryParse(addIDText, out addIDNumber);
//Console.Write("Add an employee Value: ");
//string? addValueText = Console.ReadLine();
//employeeID.add{addIDNumber] = addValueText; // need to figuer out how to add variable as key

