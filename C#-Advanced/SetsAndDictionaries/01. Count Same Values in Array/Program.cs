

string[] inputNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

for (int i = 0; i < inputNumbers.Length; i++)
{
	if (keyValuePairs.ContainsKey(inputNumbers[i]))
	{
		keyValuePairs[inputNumbers[i]]++;
		continue;
	}
    keyValuePairs.Add(inputNumbers[i], 1);
}

foreach (var kvp in keyValuePairs)
{
    Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
}