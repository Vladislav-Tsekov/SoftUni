

int n = int.Parse(Console.ReadLine());

SortedSet<string> elements = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    string[] newElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

	for (int j = 0; j < newElements.Length; j++)
	{
		elements.Add(newElements[j]);
	}
}

Console.WriteLine(string.Join(" ", elements));