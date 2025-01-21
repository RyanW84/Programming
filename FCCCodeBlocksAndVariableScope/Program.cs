namespace FCCCodeBlocksAndVariableScope;

internal class Program
{
    static void Main(string[] args)
    {
        int value = 0;
        bool flag = true;
        if (flag)
        {
            Console.WriteLine($"Inside the code block: {value}");
        }
        value = 10;
        Console.WriteLine($"Outside the code block: {value}");
    }
}
