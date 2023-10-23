
//Input = 3 5 2 43 12 3 54 10 23   //Output = 3 76 5 5 2 34 43 2 12 4 3 12 54 10 23
//Input = 76 5 34 2 4 12

List<int> numbersOne = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
List<int> numbersTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

List<int> numbersCombined = new List<int>();

int loops = numbersTwo.Count;
int duration = numbersOne.Count;

if (numbersOne.Count < numbersTwo.Count)
{
    loops = numbersOne.Count;
    duration = numbersTwo.Count;
}

for (int i = 0; i < loops; i++)
{
    numbersCombined.Add(numbersOne[i]);
    numbersCombined.Add(numbersTwo[i]);
}

for (int i = loops; i < duration; i++)
{
    if (numbersOne.Count > numbersTwo.Count)
    {
        numbersCombined.Add(numbersOne[i]);
    }
    else
    {
        numbersCombined.Add(numbersTwo[i]);
    }
}

Console.WriteLine(string.Join(" ", numbersCombined));

