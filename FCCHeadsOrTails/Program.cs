namespace FCCHeadsOrTails;

internal class Program
{
    static void Main(string[] args)
    {
        Random coin = new Random();
        //int flip = coin.Next(0, 2);
        //Console.WriteLine(flip);
        Console.WriteLine((coin.Next(0, 2) == 0) ? "Heads" : "Tails");
    }
}
