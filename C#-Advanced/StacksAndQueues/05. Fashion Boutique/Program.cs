
int[] clothes = Console.ReadLine() // 5 4 8 6 3 8 7 7 9
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int rackCapacity = int.Parse(Console.ReadLine()); // 16

Stack<int> stackOfClothes = new Stack<int>(clothes);

int rackCount = 1;
int numberOfClothes = 0;

while (stackOfClothes.Count > 0)
{
    numberOfClothes += stackOfClothes.Peek();

    if (numberOfClothes <= rackCapacity)
        stackOfClothes.Pop();

    else
    {
        rackCount++;
        numberOfClothes = 0;
    }
}

Console.WriteLine(rackCount);