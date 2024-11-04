

class Program
{
    public static void Main(String[] args)
    {

        {
            Console.WriteLine("Enter the words to find the common prefix separated with a space:");
            string? enterText = Console.ReadLine();
            string[] input = enterText.Split(' ');
            if (input.Length == 0)
            {
                Console.WriteLine($" ");
            }
            Array.Sort(input);
            string prefix = "";
            for (int i = 0; i < input[0].Length; i++)
            {
                char c = input[0][i];
                for (int j = 1; j < input.Length; j++)
                {
                    if (i >= input[j].Length || input[j][i] != c)
                    {
                        Console.WriteLine(prefix);
                    }
                }
                prefix += c;
            }
            Console.WriteLine(prefix);
        }
    }
}
