

string input = Console.ReadLine();
char[] charArray = input.ToCharArray();

Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

foreach (char letter in charArray)
{
	if (letter == ' ')
	{
		continue;
	}
	
	if (!keyValuePairs.ContainsKey(letter))
	{
		keyValuePairs.Add(letter, 0);
	}

	keyValuePairs[letter] += 1;
}

foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}