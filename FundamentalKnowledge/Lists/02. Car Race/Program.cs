

List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int middle = numbers.Count / 2;

List<int> leftCar = new List<int>();
List<int> rightCar = new List<int>();

for (int i = 0; i < middle; i++)
{
    leftCar.Add(numbers[i]);
}
for (int i = middle + 1; i < numbers.Count; i++)
{
    rightCar.Add(numbers[i]);
}

double totalTimeRC = 0;
double totalTimeLC = 0;

{
foreach (var num in leftCar)
    if (num == 0)
        totalTimeLC = totalTimeLC * 0.8;
    else
        totalTimeLC += num;
}
foreach (var num in rightCar)
{ 
    if (num == 0)
        totalTimeRC = totalTimeRC * 0.8;
    else
        totalTimeRC += num;
}

if (totalTimeLC > totalTimeRC)
{
    if (!rightCar.Contains(0))
    {
        Console.WriteLine($"The winner is right with total time: {totalTimeRC}");
        return;
    }
    Console.WriteLine($"The winner is right with total time: {totalTimeRC}");
}
else if (totalTimeLC < totalTimeRC)
{
    if (!leftCar.Contains(0))
    {
        Console.WriteLine($"The winner is left with total time: {totalTimeLC}");
        return;
    }
    Console.WriteLine($"The winner is left with total time: {totalTimeLC}");
}