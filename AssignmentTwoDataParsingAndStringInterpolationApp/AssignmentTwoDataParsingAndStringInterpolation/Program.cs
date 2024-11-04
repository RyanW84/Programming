

//Capture users input
Console.Write("What is your age? ");
string? ageText = Console.ReadLine();
int.TryParse(ageText, out int age );
Console.Write("What is your Name? ");
string? name=Console.ReadLine();

//Identify how old the will be in 25 years
int agePlus25 = age + 25;

//Identify hold old they were 25 years ago
int ageMinus25 = age - 25;

//Print that information to the console in Natural Language
Console.WriteLine($"Good morning, Your age is {age}" +
    $"\nYour age in twenty five years will be {agePlus25}" +
    $"\nYour age twenty five years ago was {ageMinus25}");

if ((ageMinus25 > 0 && name.ToLower()=="jack") || (ageMinus25 < 0 && name.ToLower() == "jack")) // had error cannot combine bool and string - turns out I needed to add ==
{
    Console.WriteLine("You are very old or your name is Jack"); // This insults jack whatever his age range
}                                               // It did not work without parentheses, it now does work with () and matches both criteria
//else if (ageMinus25 < 0 || name.ToLower() == "ryan") ;
//{
//    Console.WriteLine("You are young or your name is Ryan");
//}
