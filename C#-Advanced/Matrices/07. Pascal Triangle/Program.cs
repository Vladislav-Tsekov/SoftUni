

long size = long.Parse(Console.ReadLine());
long[][] jArray = new long[size][];

for (long row = 0; row < size; row++)
{
    jArray[row] = new long[row + 1];

    for (long col = 0; col < row + 1; col++)
    {
        if (col > 0 && col < jArray[row].Length - 1)
        {
            jArray[row][col] = jArray[row - 1][col - 1] + jArray[row - 1][col];
        }
        else
        {
            jArray[row][col] = 1;
        }
    }
}

foreach (long[] element in jArray)
{
    Console.WriteLine(string.Join(' ', element));
}