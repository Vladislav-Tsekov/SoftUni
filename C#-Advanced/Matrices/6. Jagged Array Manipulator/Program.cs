
int rows = int.Parse(Console.ReadLine());
int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] intInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    jaggedArray[row] = intInput;
}

for (int row = 0; row < rows - 1; row++)
{
    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
            jaggedArray[row][col] *= 2;

        for (int col = 0; col < jaggedArray[row+1].Length; col++)
            jaggedArray[row + 1][col] *= 2;
    }
    else if (jaggedArray[row].Length != jaggedArray[row + 1].Length)
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
            jaggedArray[row][col] /= 2;

        for (int col = 0; col < jaggedArray[row + 1].Length; col++)
            jaggedArray[row + 1][col] /= 2;
    }
}
string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string action = cmdArgs[0];

while (action != "End")
{
    action = cmdArgs[0];
    if (action == "End")
        break;

    int inputRow = int.Parse(cmdArgs[1]);
    int inputCol = int.Parse(cmdArgs[2]);
    int value = int.Parse(cmdArgs[3]);

    if (inputCol < 0 || inputRow < 0)
    {
        cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        continue;
    }

    if (action == "Add")
    {
        if (inputRow < rows)
            if (jaggedArray[inputRow].Length > inputCol)
                jaggedArray[inputRow][inputCol] += value;
    }

    else if (action == "Subtract")
    {
        if (inputRow < rows)
            if (jaggedArray[inputRow].Length > inputCol)
                jaggedArray[inputRow][inputCol] -= value;
    }

    cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
        Console.Write(jaggedArray[row][col] + " ");

    Console.WriteLine();
}
