

//Asks the user for their name
Console.Write("[IF]What is Your name?");
String firstName = Console.ReadLine();
// Welcome "Tim" as professor
if (firstName.ToLower() == "tim" || firstName.ToLower() == "timothy")
{
    Console.WriteLine("\n[IF]Hello Professor");
}
else
{
    Console.WriteLine($"\n[IF]Hello Student {firstName}");
}

Console.Write("\n[Switch Case] What is your name? ");
string switchFirstName = Console.ReadLine();
switch (switchFirstName.ToLower())
{
    case "tim" or "timothy":
        Console.WriteLine("\n[Switch case]Hello Professor");
        break;
    default:
        Console.WriteLine($"\n[Switch case] Hello Student {switchFirstName}");
        break;
}



//Welcome anyone else as a student


// Make sure that "TIM" also gets called professor
// Make sut that it also greets Timothy as Professor


