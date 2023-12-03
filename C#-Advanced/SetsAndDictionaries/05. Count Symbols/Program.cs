
string input = Console.ReadLine();

SortedDictionary<char, int> characters = new SortedDictionary<char, int>();

foreach (var ch in input)
{
	if (!characters.ContainsKey(ch))
	{
        characters.Add(ch, 0);
    }
    characters[ch]++;
}

foreach (var character in characters)
{
    Console.WriteLine($"{character.Key}: {character.Value} time/s");
}