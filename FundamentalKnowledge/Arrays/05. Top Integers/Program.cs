
//Input
//                          Output
//1 4 3 2                   4 3 2
//14 24 3 19 15 17          24 19 17
//27 19 42 2 13 45 48       48


int[] numbers = Console.ReadLine()  //1 4 3 2
.Split(" ")
.Select(int.Parse)
.ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    bool isTop = true;
	for (int j = i + 1; j < numbers.Length; j++)
	{
		if (numbers[i] <= numbers[j])
		{
			isTop = false;
			break;
		}
	}
	if (isTop)
	{
		Console.Write($"{numbers[i]} ");
	}

}
