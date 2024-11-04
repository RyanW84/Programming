

TimeOnly opensAt = TimeOnly.Parse(s: "8:00 AM");

TimeOnly rightNow =TimeOnly.FromDateTime(DateTime.Now); //reads time from Date and Time and only outputs time

Console.WriteLine(opensAt);
Console.WriteLine($"Current time: {rightNow}");