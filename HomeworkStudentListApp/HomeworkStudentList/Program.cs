/* Homework Assignment: Student List
 * Add students to a class roster List
 * until there are no more students
 * Then print out the count of thestudents to the  console
 */

List<string> studentNames = new List<string>();
string menuChoice;

do
{
    Console.Write("Please enter a Students name: ");
    string studentName = Console.ReadLine();
    studentNames.Add(studentName);
    Console.Write("\nEnter Y to add another Student? \nor anything else\n to exit ");
    menuChoice = Console.ReadLine();
} while (menuChoice.ToLower() == "y");

Console.WriteLine($"Adding to list ended, there are {studentNames.Count()} entries");







