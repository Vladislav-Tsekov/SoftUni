using System.Data;

int[] matrixSize = Console.ReadLine() // 2 3
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rows = matrixSize[0], cols = matrixSize[1]; //2 3
string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] inputData = Console.ReadLine() 
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    for (int col = 0; col < cols; col++)
        matrix[row, col] = inputData[col];
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "END")
{
    string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string action = tokens[0];

    if (action == "swap" && tokens.Length == 5)
    {
        int row1 = int.Parse(tokens[1]);
        int col1 = int.Parse(tokens[2]);
        int row2 = int.Parse(tokens[3]);
        int col2 = int.Parse(tokens[4]);

        if (row1 <= rows && row2 <= rows && col1 <= cols && col2 <= cols)
        {
            var switchInfo = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = switchInfo;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}
