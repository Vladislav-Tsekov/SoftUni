

//Input 1 2 3 4 5 - Output 6 6 3
//Input 1 2 3 4 - Output 5 5



List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

List<int> endResult = new List<int>();

int loops = numbers.Count / 2;

for (int i = 0; i < numbers.Count / 2; i++)
{
    int currentSum = numbers[i] + numbers[numbers.Count - 1 - i];
    endResult.Add(currentSum);
}

if (numbers.Count % 2 != 0)
{

    endResult.Add(numbers[numbers.Count / 2]);
}

Console.Write(string.Join(" ", endResult));
