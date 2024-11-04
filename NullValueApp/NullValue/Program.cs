

//Null is the lack of value or does not have a value yet

//Haven't asked for the age yet
//int age = 0; // default value - 0 is a value e.g age in years for a baby under 12 months is 0 years old 11 months

int? age = null; //Int is not normally nullable but adding the question mark allows
bool? birthday = null;
double? battingAverage = null;
string? firstName = null; //string doesnt normally allow null - notice the green squiggly line as it flags a possible bug (? gets rid)
decimal? accountBalance = null;



//Have asked for the age now
age = 0;
Console.WriteLine($"age = {age}");
Console.WriteLine($"first name = {firstName}");   
Console.WriteLine($"Account balance = {accountBalance}");  
Console.WriteLine(birthday);    
Console.WriteLine(battingAverage);  
Console.WriteLine(firstName);   
