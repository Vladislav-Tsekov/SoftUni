
int rows = int.Parse(Console.ReadLine());
double[][] matrix = new double[rows][];

for (int row = 0; row < rows; row++)
{
    var inputRow = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(double.Parse)
        .ToArray();

    matrix[row] = new double[inputRow.Length];
    for (int col = 0; col < inputRow.Length; col++)
    { 
        matrix[row][col] = inputRow[col];
    }
}

string[] command = Console.ReadLine().Split();

while (command[0] != "END")
{
    int row = 0;
    int col = 0;
    int value = 0;

    for (int i = 0; i < matrix.Length; i++)
    {
        row = int.Parse(command[1]);
        col = int.Parse(command[2]);
        value = int.Parse(command[3]);

        if (row < 0 || row >= matrix.Length || col < 0 || col >= matrix[row].Length)
        {
            Console.WriteLine("Invalid coordinates");
            command = Console.ReadLine().Split();
            continue;
        }
    }

    if (command[0] == "Add")
    {
        matrix[row][col] += value;
    }
    else if (command[0] == "Subtract")
    {
        matrix[row][col] -= value;
    }

    command = Console.ReadLine().Split();
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        Console.Write(matrix[row][col] + " ");
    }
    Console.WriteLine();
}
