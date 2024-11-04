
// this is a method. Write one line calls 100s of lines of code
// same thing, but the system is implicit due to "Using System"

using Methods; // Methods is the namespace and enables calling the method
using System.Runtime.InteropServices;
using System.Xml;


//DRY - Don't Repeat Yourself
//SOLID - SRP - Single Responsibility Principle
// Quarterback - makes the call

string name = ConsoleMessages.GetUsersName();

ConsoleMessages.SayHi(name); //passes name to the method as a parameter 
//Doesn't have to match Firstname in the class as a string is being passed
ConsoleMessages.SayHi("Tim"); //Parameters can be hard coded in

ConsoleMessages.SayGoodbye();

double result = MathShortcuts.Add(5, 3);
Console.WriteLine($"The result is {result}"); // easier for breakpoints when debugging
Console.WriteLine($"The result is {MathShortcuts.Add(6,3)}"); // can be done in line

double[] vals = new double[] { 2, 5, 6, 21, 52, 98 };
MathShortcuts.AddAll(vals);

(string firstName, string lastName) fullName = ConsoleMessages.GetFullName();

// Discard character (_) can be put in the place of last name "we don't care about this" ignore one of the return types

//var fullName = ConsoleMessages.GetFullName(); can be used to simplify
Console.WriteLine( $"First Name: {fullName.firstName}");
Console.WriteLine($"Last Name: {fullName.lastName}");

string ageText = "43";
bool isValidAge = int.TryParse(ageText, out int age); // returning boolen true and int age - TryParse existed before Tuple types

Console.ReadLine(); 



//Ctrl and J to quickly change method

// you only have to correct the method and not multiple lines of code
// e.g a tax calculation - where an error is found and it is used 5 times
// or risk of error - e.g its corrected in 4 places not 5
// Fix it once rather than a 100 times


//Don't use Quick Action re the current context, it just creates a new local method

//Even Shorter shortcut "using static Methods.SampleMethods;" and "SayHi();"
//Another example adding "using static System.Console" means you can write "Writeline();" rather than "Console.WriteLine()";

//There is a downside, if you have two different places, that have the same method name. Ambiguous Name / Ambiguous Call

//Methods help reduce repetition of code (DRY)
//Naming is critical - Name things for what they do

// Methods can call Methods




