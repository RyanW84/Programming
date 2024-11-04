

string data = "Tim,Sue,Bob,Jane";
List<string> firstNames = data.Split(',').ToList();


foreach (string firstName in firstNames)
{
    Console.WriteLine(firstName);
}

string data2 = "1,2,3,4,5";
List<String> employeeID = data2.Split(",").ToList();

foreach (string employeeIDIndex in employeeID)
{
    Console.WriteLine(employeeIDIndex);
}


