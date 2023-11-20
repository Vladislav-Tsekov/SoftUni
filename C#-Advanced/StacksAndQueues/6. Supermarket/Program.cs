

string input = string.Empty;

Queue<string> names = new Queue<string>();

while ((input = Console.ReadLine()) != "End") 
{
	if (input == "Paid")
	{
		while (names.Count > 0)
		{
			string currentName = names.Peek().Trim();
			Console.WriteLine(currentName);
			names.Dequeue();
        }
	}
	else 
	{
        names.Enqueue(input);
    }
	
}

Console.WriteLine($"{names.Count} people remaining.");