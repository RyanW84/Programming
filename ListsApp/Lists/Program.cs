

List<string> firstNames = new List<string>();
// This list will only hold strings
// The second part of line creates the list
// Lists don't have to specify the size so can be added to without reallocating the whole structure

firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jane");
firstNames.Add("Frank");

Console.WriteLine(firstNames[3]);
Console.WriteLine(firstNames.Count());
Console.WriteLine(firstNames[firstNames.Count()-1]);
//Length is for arrays
//Count is for lists

List <int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);
ages.Add(4);
ages.Add(5);

// Lists are more versatile and an easy way to set things up

// List<T> - generic - You can choose the type you put in and even create your own generic

string data = "Corey,Smith,Jones,Weavers";
List<string> lastNames = data.Split(',').ToList();
lastNames.Add("Franklin");
// Very verstile
// Tim Corey's primay way of working with data 
// In most cases, the absolute maxium efficiency of code isn't quite as important as being able to work with it well, when we create it





