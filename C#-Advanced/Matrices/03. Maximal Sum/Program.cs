﻿
int[] matrixSize = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = matrixSize[0], cols = matrixSize[1];
int[,] matrix = new int[rows,cols];

for (int row = 0; row < rows; row++)
{
    int[] numbers = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    for (int col = 0; col < cols; col++)
        matrix[row, col] = numbers[col];
}

int maxSum = int.MinValue;
int rowStartIndex = 0;
int colStartIndex = 0;

for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{
    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        //int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
        //            + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
        //            + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

        var sum = 0;
        for (var longitute = row; longitute < row + 3; longitute++)
        {
            for (var latitude = col; latitude < col + 3; latitude++)
            {
                sum += matrix[longitute, latitude];
            }
        }

        if (sum > maxSum)
        {
            maxSum = sum;
            rowStartIndex = row;
            colStartIndex = col;
        }
    }
}

Console.WriteLine($"Sum = {maxSum}");

for (int row = rowStartIndex; row <= rowStartIndex + 2; row++)
{
    for (int col = colStartIndex; col <= colStartIndex + 2; col++)
    {
        Console.Write($"{matrix[row, col]} ");
    }
    Console.WriteLine();
}
