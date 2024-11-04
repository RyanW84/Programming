
using System;
class MainClass
{
    public static void Main(string[] args)
    {

        DateTime bday = new DateTime(1990, 12, 15);
        DateTime now = DateTime.Today;
        int age = now.Year - bday.Year;
        if (bday > now.AddYears(-age))
            age--;

        Console.WriteLine(age);
    }
}