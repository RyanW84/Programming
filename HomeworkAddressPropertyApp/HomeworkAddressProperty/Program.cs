

using System.Net;

namespace HomeworkAddressProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressModel myAddress = new AddressModel
            {
                Street = "123 Main St",
                City = "Wantage",
                State = "Oxfordshire",
                PostalCode = "OX12 0EQ",
                Country = "United Kingdom"
            }; // Print the address

            Console.WriteLine("Address:");
            Console.WriteLine($"Street: {myAddress.Street}");
            Console.WriteLine($"City: {myAddress.City}");
            Console.WriteLine($"State: {myAddress.County}"); 
            Console.WriteLine($"Postal Code: {myAddress.PostCode}");
            Console.WriteLine($"Country: {myAddress.Country}";
        }
    }
}