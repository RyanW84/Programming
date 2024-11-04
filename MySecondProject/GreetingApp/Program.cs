

//1) Welcome user to app
Console.WriteLine("Welcome to the Greeting Application");
Console.WriteLine("This Application was made by Ryan Weavers");
Console.WriteLine("-----------------------------------------");
Console.WriteLine();

//2) Ask for first name
Console.Write("What is your first name: ");
string firstName;
firstName = Console.ReadLine();

//3) Greet user by name
Console.WriteLine();
Console.WriteLine("Hello " + firstName);
Console.WriteLine();
Console.WriteLine($"Thank you for using my application, {firstName}.");
Console.ReadLine();