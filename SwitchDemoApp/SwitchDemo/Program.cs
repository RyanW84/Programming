

string firstName = "sue";
int age = 189;

//switch (firstName.ToLower())
switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine("You are a child");
        break;
    case >= 18 and < 66:
        Console.WriteLine("You should have a job");
        break;
    case >= 66:
        Console.WriteLine("hopefully you are retiring soon");
        break;
    default:
        Console.WriteLine("Age was not in expected range");
        break;
        ////case "sue": // fall through if you stack cases without a break it will execute the code if any of the criteria match
        //case "tim" or "sue": // can have more complex case statements
        ////case "tim":
        //    Console.WriteLine("Hello Professor");
        //    break;
        //case "tom":
        //    Console.WriteLine("Hello Tom");
        //    break;
        //default:
        //    Console.WriteLine("I don't know you");
        //    break;
}
