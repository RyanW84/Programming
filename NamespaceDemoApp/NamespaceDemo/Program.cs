using System;
using FoundationInfo.Calculators.Test;
using NamespaceDemo.Models;

namespace NamespaceDemo;

class Program
{
    static void Main  (string[] args)
    {
        List<PersonModel> people = new List<PersonModel> ();
        PersonModel person = new PersonModel();

        FoundationInfo.Calculators.Test.Calculations.Add(4, 4);
        //namespaceDemo is greyed out as its consistent across the program and classes
        Console.ReadLine();

        System.Console.WriteLine(""); // don't need to write
    }
}