

//Ask the user for their first name
Console.Write("What is your first name? ");
string? firstName = Console.ReadLine();
Console.Write("\nWhat is your age? ");
string ageText = Console.ReadLine();
int.TryParse(ageText, out int age);


//if their name is Bob or Sue, Address them as professor
if 
    (firstName.ToLower() == "bob" || firstName.ToLower() == "sue")
{
    string formalName = "Hello Professor ";
    global::System.Console.WriteLine($"\n{formalName} + {firstName}");
}
//Address everyone else by name
else
{
    Console.WriteLine($"\nHello Student {firstName}");
}
//If ther person is under 21, recommend they wait X years to start this class
if (age < 21)
{
    //int ageDifference = 21 - age;
    Console.WriteLine($"\nSorry {firstName} you have to wait {21 - age} year(s) before starting this course");
}
else
{
    Console.WriteLine("Welcome to the course");
}
