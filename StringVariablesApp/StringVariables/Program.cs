

string firstName    = string.Empty;
//Hungarian Notation strFirstName  Microsoft started with it but it is now avoided
//use meanningful names, avoid acronyms avoid pointlessly long , give enough to understand
//e,g fName could be first name full name or file name
string lastName     = string.Empty;
string filePath     = string.Empty;

// expertsExchange important usage of camel case and how it can fall short
// www.expertsexchange.com

firstName = "Tim";
//firstName = "123";
lastName = "Corey";
//filePath = "C:\\Temp\\Demo \n";
filePath = @"C:\Temp\Demo"; //string literal


//String Interpolation
string testString = $@"The file for {firstName} is at C:\SampleFiles"; //string literal and interpolation combined doesnt matter which way round anymore
Console.WriteLine(firstName + " " +lastName);
Console.WriteLine($"Hello {firstName} {lastName}"); //string interpolation
Console.WriteLine(filePath);
Console.WriteLine(testString);



