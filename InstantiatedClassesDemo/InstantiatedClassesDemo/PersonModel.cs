using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassesDemo
{
    // Blueprint
   
    public class PersonModel // a model holds information together - no static
    {
        //public string firstName;
        //public string lastName;
        //public string emailAddress;
        //not the way you are meant to store data in class instances
        //(variables dont work well in data binding / reflection - introduction to properties.

        //not static, have to create an instance of the object e.g PersonModel.firstName

        public string? FirstName { get; set; } // prop tab tab (autoproperty)
        public string? LastName { get; set; }  //different naming convention - PascalCase
        public string? EmailAddress { get; set; }
        public bool HasBeenGreeted { get; set; }
    }
}
