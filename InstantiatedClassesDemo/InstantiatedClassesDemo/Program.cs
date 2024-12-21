using System;

namespace InstantiatedClassesDemo

    /*Pro Tip
     * In general, instantiated classes store data
     * Static classes are for stateless processing
     * Don't often use static classes
     * More often use instantiated classes
     */
    
{
    class Program
    {
        static void Main(string[] args)
        {

            //string firstName;
            //string lastName;
            //string emailAddress;

            //List<string> firstNames = new List<string>();
            //List<string> lastNames = new List<string>();
            //firstNames[0];
            //lastNames[0];
            // how do I make sure that person 1s first name match the correct last name in the second list for last name - e,g what if Tim is deleted, but Corey remains

            //Building a house from the Blueprint
            //PersonModel person = new PersonModel();

            //person.firstName = "Tim";

            //PersonModel secondPerson = new PersonModel();
            //secondPerson.firstName = "Sue";

            //Console.WriteLine(person.firstName);
            //Console.WriteLine(secondPerson.firstName);
            //same blueprint different living rooms - a copy of the living room, different chairs

            //List<PersonModel> people = new List<PersonModel>();
            //list is instantiated class hence the second part of the command

            //variable holds the street address for the house that you built
            //PersonModel person = new PersonModel();
            //person.firstName = "Tim";
            //people.Add(person);

            //person = new PersonModel(); // New street address
            //person.firstName = "Sue";
            //people.Add(person);

            //foreach (PersonModel p in people)
            //{
            //    Console.WriteLine(p.firstName);
            //}

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";

            do
            {
                Console.Write("First name (or type exit to stop): ");
                firstName = Console.ReadLine();

                Console.Write("Last name (or type exit to stop): ");
                string lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel(); //inside the scope
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person); // adds to the outside list scope
                }

            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }

            Console.ReadLine();
        }
    }
}