using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypesDemo
{
    public class PersonModel
    {
        public string? FirstName { private get; set; } // anyone can set it, only inside this class can read it
        public string? LastName { get; private set; } //anyone can read it, but only inside this class it can be set

        private string _password;

        public string Password
        {
            set { _password = value; }  // write only
        }


        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}"; // read only
            }
        }



        //public int age { get; set; } //this currently allows numbers not suitable for age e.g -1 or 300

        private int _age; //private backing field underscore and then camel case 

        public int Age
        {
            get // only manipulate inside the curly braces
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 126) //will only set if you have a valid age range
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range");
                }
            }

        }

        //public string? SSN { get; set; } // Social Security Number 123-45-6789

        private string _ssn;

        public string SSN
        {
            get
            {
                // 123-45-6789 - 11 chars long -4 = 7 (start at pos 7)
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4); //prints last four digs
                return output;
            }
            set
            {
                _ssn = value;
            }
        }

        public PersonModel() // allows overloading 
        {
                
        }
        public PersonModel(string lastName)
        {
            LastName = lastName; //snippet "ctor" constructor method - runs when you build the house
        }
    }
}
