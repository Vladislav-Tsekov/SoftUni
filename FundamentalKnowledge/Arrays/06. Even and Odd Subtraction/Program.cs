


int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int evenNumSum = 0;
int oddNumSum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        evenNumSum += numbers[i];
    }
    else
    {
        oddNumSum += numbers[i];
    }
}

int result = evenNumSum - oddNumSum;

Console.WriteLine(result);