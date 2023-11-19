
int matrixSize = int.Parse(Console.ReadLine());

int[,] matrix = new int[matrixSize, matrixSize];

for (int rows = 0; rows < matrixSize; rows++)
{
	int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
	for (int cols = 0; cols < matrixSize; cols++)
	{
		matrix[rows, cols] = numbers[cols];
	}
}

int diagonalSum = 0;
for (int rows = 0; rows < matrixSize; rows++)
{
	for (int cols = 0; cols < matrixSize; cols++)
	{
		diagonalSum += matrix[rows, cols];
		rows++;
	}
}

Console.WriteLine(diagonalSum);