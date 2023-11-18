
string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(input[0]), cols = int.Parse(input[1]);
int matrixSize = rows * cols;
char[,] matrix = new char[rows, cols];
string snake = Console.ReadLine();

Queue<char> snakeQueue = new();

int loops = 0;
for (int i = 0; i < snake.Length; i++)
{
    snakeQueue.Enqueue(snake[i]);
    loops++;

    if (loops == matrixSize)
        break;
    if (i == snake.Length - 1)
        i = -1;
}

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
        for (int toRight = 0; toRight < cols; toRight++)
            matrix[row, toRight] = snakeQueue.Dequeue();

    else if (row % 2 != 0)
        for (int toLeft = cols - 1; toLeft > -1; toLeft--)
            matrix[row, toLeft] = snakeQueue.Dequeue();
}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
        Console.Write($"{matrix[row, col]}");
    Console.WriteLine();
}