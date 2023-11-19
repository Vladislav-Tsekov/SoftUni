

using System.Numerics;

int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];

for (int rows = 0; rows < n; rows++)
{
	char[] inputChar = Console.ReadLine().ToCharArray();
	for (int cols = 0; cols < n; cols++)
	{
		matrix[rows, cols] = inputChar[cols];
	}
}

char symbol = char.Parse(Console.ReadLine());

for (int rows = 0; rows < n; rows++)
{
    for (int cols = 0; cols < n; cols++)
    {
		if (matrix[rows, cols] == symbol)
		{
			Console.WriteLine($"({rows}, {cols})");
			return;
        }
    }
}

Console.WriteLine($"{symbol} does not occur in the matrix");