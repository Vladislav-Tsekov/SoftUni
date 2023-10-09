

//You will be given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper and so on) and every even - quantity. Your task is to collect the resources and print them each on a new line.

//Print the resources and their quantities in the following format:
//"{resource} –> {quantity}"

//The quantities will be in the range [1… 2 000000000].

Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

string resource = string.Empty;

while ((resource = Console.ReadLine()) != "stop")
{
    int quantity = int.Parse(Console.ReadLine());

	if (!keyValuePairs.ContainsKey(resource))
	{
		keyValuePairs.Add(resource, 0);
	}

	keyValuePairs[resource] += quantity;
}

foreach (var kvp in keyValuePairs)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}



