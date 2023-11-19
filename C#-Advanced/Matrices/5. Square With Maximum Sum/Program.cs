
int[] input = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int rowCnt = input[0];
int columnCnt = input[1];

int[,] matrix =  new int[rowCnt, columnCnt];

for (int rows = 0; rows < rowCnt; rows++)
{
    int[] numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
    for (int cols = 0; cols < columnCnt; cols++)
    {
        matrix[rows, cols] = numbers[cols];
    }
}

int maxSum = int.MinValue;
int rc = 0, rc1 = 0, r1c = 0, r1c1 = 0;
for (int r = 0; r < rowCnt-1; r++)
{
    for (int c = 0; c < columnCnt-1; c++)
    {
        int sum = matrix[r, c] + matrix[r, c + 1] + matrix[r + 1,c] + matrix[r + 1,c + 1];
        if (sum > maxSum)
        {
            maxSum = sum;
            rc = matrix[r, c];
            rc1 = matrix[r,c + 1];
            r1c = matrix[r + 1,c];
            r1c1 = matrix[r + 1, c + 1];
        }
    }
}

Console.WriteLine($"{rc} {rc1}");
Console.WriteLine($"{r1c} {r1c1}");
Console.WriteLine(maxSum);