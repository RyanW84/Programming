using System;
class MainClass
{
    public static void Main(string[] args)
    {

        DateTime bday = new DateTime(1984, 12, 11);
        DateTime now = DateTime.Today;
        int age = now.Year - bday.Year;
        if (bday > now.AddYears(-age))
            age--;

        Console.WriteLine($"The age for someone with the DOB {bday} is {age}");
        Console.ReadKey();
    }
}