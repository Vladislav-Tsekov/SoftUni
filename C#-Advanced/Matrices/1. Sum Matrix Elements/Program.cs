
int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rowsCnt = input[0];
int colsCnt = input[1];

int[,] matrix = new int[rowsCnt,colsCnt];

for (int row = 0; row < rowsCnt; row++)
{
	int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();	
	for (int col = 0; col < colsCnt; col++)
	{
		matrix[row, col] = numbers[col];
	}
}

//for (int row = 0; row < rowsCnt; row++)
//{
//    for (int col = 0; col < colsCnt; col++)
//    {
//		Console.Write(matrix[row, col] + " ");
//    }
//    Console.WriteLine();
//}

int totalSum = 0;
foreach (var num in matrix)
{
	totalSum += num;
}

Console.WriteLine(rowsCnt);
Console.WriteLine(colsCnt);
Console.WriteLine(totalSum);