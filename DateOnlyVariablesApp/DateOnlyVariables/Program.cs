

//only works in .Net 6+

DateOnly birthday = DateOnly.Parse(s: "11/6/1998");

Console.WriteLine(birthday.ToString(format: "MMMM dd, yyyy"));

DateTime today = DateTime.Now;

Console.WriteLine(value:$"Today full format:{today}"); // Outputs date and time - so its best to use DateOnly
Console.WriteLine(value:$"Today just Date: {today.Date}");
Console.WriteLine(value: $"Birthday full format:{birthday}");

/* 
 * Notice how this uses value to make writing the code and including text easier 
 * for string interpolation
 */
