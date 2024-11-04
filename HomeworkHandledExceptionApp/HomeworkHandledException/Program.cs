

int[] ages = new int[] {21, 22, 45, 46, 47};

try
{
	for (int i = 0; i <= ages.Length; i++)
	{
        Console.WriteLine($"Ages array {ages[i]}");
    }

	}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
	throw new Exception("outside of Array");
}

