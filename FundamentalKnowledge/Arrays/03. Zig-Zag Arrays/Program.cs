

int n = int.Parse(Console.ReadLine());

int[] firstArray = new int[n];
int[] secondArray = new int[n];

for (int i = 0; i < n; i++)
{
    int[] currentN = Console.ReadLine()
        .Split(" ")
        .Select(int.Parse)
        .ToArray();

    if (i % 2 == 0)
    {
        firstArray[i] = currentN[0];
        secondArray[i] = currentN[1];
    }
    else
    {
        firstArray[i] = currentN[1];
        secondArray[i] = currentN[0];
    }
}

Console.WriteLine(string.Join(" ", firstArray));
Console.WriteLine(string.Join(" ", secondArray));