using System.Globalization;

DateTime today = DateTime.Now; // based on local time so may not reflect correctly for a different user in a different timezone

//may not reflect daylight savings time

Console.WriteLine($"This is standard date and time notation:\n{today}");
Console.WriteLine($"\nThe short date d is:\n{today.ToString(format: "d")}");                        //Short date
Console.WriteLine($"\nThe long date D is:\n{today.ToString(format: "D")}");                         //Long date
Console.WriteLine($"\nThe short time t is:\n{today.ToString(format: "t")}");                        //Short time
Console.WriteLine($"\nThe long time T is:\n{today.ToString(format: "T")}");                         //Long time

//DateTime birthday = DateTime.Parse(s: "16/11/1984");                                              //beware of locale e.g us MM/DD/YYYY
DateTime birthday = DateTime.ParseExact(s:"06/11/1984", "dd/M/yyyy" , CultureInfo.InvariantCulture);//how to prase in a value irrespective of locale
Console.WriteLine($"\nMy Birthday in default format is\n{birthday}");

Console.WriteLine($"\nThe long version of the month is:\n{today.ToString(format: "MMMM")}");    // Four M's = Full Month
Console.WriteLine($"\nThe Short version of the month is:\n{today.ToString(format: "MMM")}");    // Three M's = Shortened Month
Console.WriteLine(value: $"\nExtended formatting for Birthday:\n{today.ToString(format: "dddd MMMM dd, yyyy hh:mm:ss tt zzz")} freetext");  
// tt = PM, zzz = UTC offset, K = timezone, h = 12 hour time, ss = seconds


/*
 * Consider where the program is being run, is it always going to be local time
 * Will you travel to different countries
 * Will the program be stored in the cloud
 * will the error reporting logs give the correct date and tume
 */

DateTime todayUTC =DateTime.UtcNow;
Console.WriteLine($"\nThe UTC time now is:{todayUTC.ToString(format: "\nHH:MM:ss zzz")}");