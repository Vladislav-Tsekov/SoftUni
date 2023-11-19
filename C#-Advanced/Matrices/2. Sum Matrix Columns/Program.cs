int[] input = Console.ReadLine()
	.Split(", ", StringSplitOptions.RemoveEmptyEntries)
	.Select(int.Parse)
	.ToArray();
int rowsCnt = input[0];
int colsCnt = input[1];

int[,] matrix = new int[rowsCnt, colsCnt];

for (int rows = 0; rows < rowsCnt; rows++)
{
	int[] numbers = Console.ReadLine()
		.Split(" ", StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse)
		.ToArray();
	for (int cols = 0; cols < colsCnt; cols++)
	{
		matrix[rows,cols] = numbers[cols];
	}
}

for (int cols = 0; cols < colsCnt; cols++)
{
	int colSum = 0;
	for (int rows = 0; rows < rowsCnt; rows++)
    {
		colSum += matrix[rows, cols];
    }
    Console.WriteLine(colSum);
}

