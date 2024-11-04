using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesDemo
{
    public static class CalculateData
    {
        //public static int myage; 
        
        //we don't typically store data in a static class, it stays the same through the whole application (using storage and memory space)

        // only used for small pieces of data, such as connecting path to a database
        public static double Add(double x, double y)
        {
            double output = x + y;
            return output;
        }

        //public void subtract() - when the class is static it won't let you instantiate non static methods
    }
}
