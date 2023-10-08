
int[] array = Console.ReadLine()
.Split(" ")
.Select(int.Parse)
.ToArray();

int currentSequenceLength = 1;
int maxSequenceLength = 0;
int indexValue = 0;

for (int i = 0; i < array.Length; i++)
{
	int currentArrayIndex = i - 1;
	
	while (i < array.Length - 1 && array[i] == array[i + 1])
	{
		currentSequenceLength++;
		i++;
	}
	if (currentSequenceLength > maxSequenceLength)
	{
		maxSequenceLength = currentSequenceLength;
		indexValue = array[i];
	}
	currentSequenceLength = 1;
}
for (int j = 1; j <= maxSequenceLength; j++)
{
	Console.Write(indexValue + " ");
}


