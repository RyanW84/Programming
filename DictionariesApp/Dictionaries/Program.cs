

Dictionary<string, string> lookup = new Dictionary<string, string>();

lookup["animal"] = "Not a human";
lookup["fish"]= "Not a human that swims";
lookup["human"] = "Us";

// Keys and values

// create an index based upon a value we pass in, rather than a number

Console.WriteLine($"The definition of fish is {lookup["fish"]}");

Dictionary<int, string> employees = new Dictionary<int, string>();

employees[95] = "Tim Corey";
employees[28] = "Sue Storm"; // Doesn't have to be in order

Console.WriteLine($"The employee with ID number 28 is {employees[28]}");

Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();

dayOfWeek["Wednesday"] = 4;
dayOfWeek["Thursday"] = 5;
dayOfWeek["Friday"] = 6;

Console.WriteLine($"Wednesday is day number {dayOfWeek["Wednesday"]}"); //There can only be one key, they have to be unique

// Dictionaries are useful for storing a set of data you need to conver over
// Or When you need to have employees ID by name