

// 0 - based counting - 0,1,2,3,4
// 1 - based counting - 1,2,3,4,5

//using System.Runtime.ExceptionServices;

//string[] firstNames = new string[5]; //Want to know for certain, otherwise you have to reprovision your entire array
//// You also don't want to provision an array too big either


//firstNames[0] = "Tim";
//firstNames[1] = "Sue";
//firstNames[2] = "Bob";
//firstNames[4] = "Jane"; // Can skip or not need to do in order

//Console.WriteLine($"The first names are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, {firstNames[4]}");

//firstNames[0] = "Timothy";
//Console.WriteLine(firstNames[0]);

//firstNames[5] = "Robert";


string data = "Tim,Sue,Bob,Jane,Frank"; // example of CSV
string[] firstNames = data.Split(',');
//single quote (double quotes is a different kind of value
// single quote identifies a char - character
// double quotes identifies a string value data.split(" , ")

Console.WriteLine(firstNames[1]);
Console.WriteLine(firstNames[firstNames.Length - 1]);
// Using Firstnames.length will take you out of bounds of the array so to output the last item in the array, you have to use -1 to account for the 1 based coutning

Console.WriteLine(firstNames.Length); // 1 based counting

string[] lastNames = new string[] { "Corey", "Smith", "Jones" }; // 3 elements - positions 0,1,2

int[] ages = new int[] { 2, 3, 4 }; // Can use many differen types in arrays including boolean - type does matter