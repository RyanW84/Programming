

using System.Diagnostics.Tracing;

Console.Write("What is your first name: ");
string firstName = Console.ReadLine();

///* 
// * protip avoid copying and pasting in code
// * this can create bugs and errors
// * for example missing changing the variable
// * where it appears elsewhere in the code
// */

Console.Write("What is your Last name: ");
string lastName = Console.ReadLine();

if (firstName.ToLower() == "tim" &&
    lastName.ToLower() == "corey")
{
    Console.WriteLine("Hello Professor Corey");
}
else if (firstName.ToLower() == "tim" || // double pipe = OR = if either side is true the return is true
            lastName.ToLower() == "corey") //Can use Ctrl +k +d
{
    Console.WriteLine("OR example: You have a great part in your name");
}
else
{
    Console.WriteLine(" If neither criteria are met in OR: Hello Student");
}

// Example of using && and to meet two critera

if (firstName.ToLower() == "tim" &&
    lastName.ToLower() == "corey") //Combining if statements, has to match both
                                   //C Sharp ignores line breaks inside parantheses
                                   //Note the choice of where to break the line so it is readable.
{
    Console.WriteLine("AND Criteria: Hello Mr Corey");
}
else if (firstName.ToLower() == "tim") //Use shift enter after closing parantheses to add curly brackets
{
    Console.WriteLine("Selecting out one Criteia in an IF statemnt: Hello, you have a cool first name"); // If the first critera matches but the second doesn't
}
else if (lastName.ToLower() == "corey")
{
    Console.WriteLine("You have a great last name"); // If the Last name matches but the first name doesn't
}
else //Clean up if none of the criteria match
{
    Console.WriteLine("Sorry you don't have a cooler name");
}

//An example of not chaining statements

//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("You have a cool first name");
//}
//else if (lastName.ToLower() == "corey")
//{
//    // Without using else IF, these IF statements are not chained - they print both outputs at once so you get "cool first name" and "great last name" after each other
//    Console.WriteLine("You have a great last name"); //This code will only run if the first test is negative and the second test is positive
//}
//else
//{
//    Console.WriteLine("Sorry your name isn't cooler");
//}



//if (isComplete=true) 

//if (firstName == "tim") // One equal is an assignment this will throw a cannot implicitly convert a string to a boole
////it is not doing a comparison
//{
//    Console.WriteLine("You have a cool first name");
//}
int age = 73;


/*
 * == equal to
 * > Great Than
 * < Less Than
 * >= Greater than or equal to
 * <= Less than or equal to
 * != Not equal to
 */
if ((age >= 40 && age < 50) || (age >= 70 && age < 80)) // Cannot have multiple AND evaluations - use OR instead 
                                                        // Use parentheses to make the evaluation clearer to you, the compiler or another programmer
                                                        // Not needed for same types but if mixing ANDS and ORS use parentheses
{
    Console.WriteLine("You are in your 40s or 70s");
    //important to test the edge cases. e.g checking input for 39, 40, 50, 49
}

