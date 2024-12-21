namespace PropertyTypesDemo;

class Program // video 77 21:06
{

    /* Pro Tip
     * Use auto properties by defailt.
     * Move to full properties when needed.
     */
    static void Main(string[] args)
    {
        PersonModel person = new PersonModel(); // passsing into the constructor 
        person.FirstName = "Tim";
        //person.LastName = "Corey";
        person.Age = 40;
        person.SSN = "123-45-6789";

        Console.WriteLine(person.FullName);
        Console.WriteLine(person.SSN);

        Console.ReadLine();
    }
}