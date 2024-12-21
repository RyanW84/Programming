using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStaticClassCalculations
{
    public static class CalculateData
    {
        public static double Add(double x, double y)
        {
            double output = x + y;
            return output;
        }
        public static double Subtract(double x, double y)
        {
            double output = x - y;
            return output;
        }
        public static double Multiply(double x, double y)
        {
            double output = x * y;
            return output;
        }
        public static double Divide(double x, double y)
        {
            double output = x / y;
            return output;
        }
    }
}
