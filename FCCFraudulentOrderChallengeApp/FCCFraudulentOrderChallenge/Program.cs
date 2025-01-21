namespace FCCFraudulentOrderChallenge;

internal class Program
{
    static void Main(string[] args)
    {
        string[] orderID = new string[]
        {
            "B123",
            "C234",
            "A345",
            "C15",
            "B177",
            "G3003",
            "C235",
            "B179",
        };

        foreach (var order in orderID)
        {
            if (order.StartsWith("B"))
            {
                Console.WriteLine($"Order {order} is a fraudulent order.");
            }
            else
            {
                Console.WriteLine($"Order {order} is a legitimate order.");
            }
        }
    }
}
