int[] matrixSize = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0], cols = matrixSize[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] text = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < cols; col++)
        matrix[row, col] = text[col];
}

int squaresFound = 0;

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        if (matrix[row, col] == matrix[row, col + 1] &&
            matrix[row + 1, col] == matrix[row + 1, col + 1] &&
            matrix[row + 1, col] == matrix[row, col + 1] &&
            matrix[row, col + 1] == matrix[row + 1, col + 1])
                squaresFound++;
    }
}


    Console.WriteLine(squaresFound);

