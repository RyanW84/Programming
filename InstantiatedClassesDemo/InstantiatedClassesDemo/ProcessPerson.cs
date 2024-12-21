using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassesDemo
{
    public static class ProcessPerson
    {
        public static void GreetPerson(PersonModel person) 
            // not making a copy
            // when you give your address you are giving the location and not sending the house
        {
            Console.WriteLine($"Hello {person.FirstName} {person.LastName}");
            person.HasBeenGreeted = true;
        }
    }
}
