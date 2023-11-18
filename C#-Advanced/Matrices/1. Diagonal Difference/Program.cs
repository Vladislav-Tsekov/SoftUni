int matrixSize = int.Parse(Console.ReadLine());
int[,] matrix = new int[matrixSize, matrixSize];

for (int rows = 0; rows < matrixSize; rows++)
{
	int[] numbers = Console.ReadLine()
		.Split(" ", StringSplitOptions.RemoveEmptyEntries)
		.Select(int.Parse)
		.ToArray();

	for (int cols = 0; cols < matrixSize; cols++)
		matrix[rows, cols] = numbers[cols];
}

int primaryMatrix = 0;
for (int loops = 0; loops < matrixSize; loops++)
	primaryMatrix += matrix[loops, loops];

int secondaryMatrix = 0;
for (int rows = 0; rows < matrixSize; rows++)
{
	for (int cols = matrixSize - 1; cols >= 0; cols--)
	{
        secondaryMatrix += matrix[rows, cols];
		rows++;
    }
}

Console.WriteLine(Math.Abs(primaryMatrix - secondaryMatrix));