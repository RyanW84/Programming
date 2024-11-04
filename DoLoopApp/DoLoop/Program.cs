
bool isValidAge;
int age;
//int testNumber = 0;

/*do
 * {
 * Console.WriteLine(testNumber);
 * testNumber += 3;                 //the += this replaces having to write testnumber = testnumber +3
 * } while (testNumber < 10);       // previous !=10 created infinite loop
 */

//always check your loops - make sure the loop has an exit!!!

do
{
    Console.WriteLine("What is your age? ");
    string? ageText = Console.ReadLine();

    isValidAge = int.TryParse(ageText, out age); //int has been removed as variable has been declated at beginning

    if (isValidAge == false)
    {
        Console.WriteLine("That was an invalid age.");
    }
} while (isValidAge == false);              // this exits when valid age = false is false (aka true)

Console.WriteLine($"Your age is {age}");    //if not defined outside of the do loop, it will give a scope error
do
{
    //Runs the code at least once
    //Handy when you need to collect user input on the first time around and then evaluate
} while (true);

while (true)
{
    //Runs the code 0 or more times
    //Can be used to cleanup code and keep going until complete
}




