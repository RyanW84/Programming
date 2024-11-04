

//bool isComplete = true;

//if (isComplete) // You can have just an If Statement
//{               // You can remove curly braces, best practice not to, to avoid confusion
//    Console.WriteLine("The statement was true.");
//    Console.WriteLine("This line works in true");
//}
//else            // You cannot have just an else statement
//{
//    Console.WriteLine("The statement was false");
//    Console.WriteLine("This should also run"); // When not using curly braces it will only execute one line
//}

//Console.WriteLine("End of first If statement");

//bool isComplete2 = true;
//if  (isComplete2)
//    Console.WriteLine("The second statement is True");
//    //Console.WriteLine("Can you see if True?"); creates debug errors when adding second line
//else
//    Console.WriteLine("The second statement is False");
//    Console.WriteLine("Can you see me?");

Console.Write("What is your first Name: ");
string? firstName = Console.ReadLine();
string lastName; // defined outside of scope

if (firstName.ToLower() == "tim") // == Comparison, compares two values and returns boolean
{
    Console.WriteLine("Hello, Mr Corey"); // Curly braces denote scope
    lastName = "Corey";
}
else
{
    Console.WriteLine($"Hello {firstName}");
    lastName = "Smith";
}

// Test programs behind the Happy Path - e.g need to test beyond easy for user odd errors (tIM)
Console.WriteLine("End of program");
Console.WriteLine(lastName);  //lastName only existed inside the scope, but can be modified