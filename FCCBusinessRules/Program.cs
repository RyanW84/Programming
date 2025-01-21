namespace FCCBusinessRules;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        Console.WriteLine($"Days Until Expiration {daysUntilExpiration}");

        if (daysUntilExpiration <= 10 && daysUntilExpiration >= 6) //Rule 2
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }
        else if (daysUntilExpiration <= 5 && daysUntilExpiration >= 2) //Rule 3
        {
            discountPercentage += 10;
            Console.WriteLine(
                $"Your subscription expires in {daysUntilExpiration} days time \n renew now and save {discountPercentage}%"
            );
        }
        else if (daysUntilExpiration == 1) //Rule 4
        {
            discountPercentage += 20;
            Console.WriteLine("Your subscription expires within a day. \nRenew now and save 20%");
        }
        else if (daysUntilExpiration == 0) //Rule 5
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else
        {
            Console.WriteLine();
        }
    }
}
