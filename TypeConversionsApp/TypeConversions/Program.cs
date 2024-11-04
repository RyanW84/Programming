

Console.Write("What is your age? ");                    // Want the input on the same line
string? ageText = Console.ReadLine();

Console.WriteLine(ageText +15);                         // VS treats this as a string addition e.g age 43 - becomes 4315

//int age = int.Parse(ageText);                         //when using parse it will treat it as a number not a string
bool isValidInt = int.TryParse(ageText, out int age);   // Note that the int age is declared inline
Console.WriteLine(value:$"This is valid: {isValidInt}. The number was {age}");

Console.WriteLine(age);
Console.WriteLine(age + 15);   //Now that the data is parsed it does the addition correctly (43 +15 = 58)

double testDouble = age;
//decimal testDecimal = testDouble; incompatible types without casting
decimal testDecimal = (decimal)testDouble; //this does not work unless you cast it