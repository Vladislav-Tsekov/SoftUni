
int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, List<string>>> keyValuePairs = new();

for (int i = 0; i < n; i++) 
{
    string[] inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string continent = inputData[0];
    string country = inputData[1];
    string city = inputData[2];

    if (!keyValuePairs.ContainsKey(continent))
    {
        keyValuePairs.Add(continent, new Dictionary<string, List<string>>());
    }

    if (!keyValuePairs[continent].ContainsKey(country)) 
    {
        keyValuePairs[continent].Add(country, new List<string>());
    }

    keyValuePairs[continent][country].Add(city);
}

foreach (var (continent, countries) in keyValuePairs)
{
    Console.WriteLine($"{continent}:");

    foreach (var (country, cities) in countries)
    {
        Console.Write($"    {country} -> {string.Join(", ", cities)}");
        Console.WriteLine();
    }
}