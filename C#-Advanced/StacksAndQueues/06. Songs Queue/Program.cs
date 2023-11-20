

string[] songsList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

Queue<string> songs = new Queue<string>(songsList);

while (songs.Count > 0)
{
	string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
	string command = cmd[0];

	if (command == "Play")
	{
		songs.Dequeue();
	}
	else if (command == "Add")
	{
		string songName = string.Empty;

		foreach (var word in cmd)
		{
			if (word != "Add")
			{
				songName += $"{word} ";
			}
		}

		songName = songName.Trim();

		if (songs.Contains(songName))
		{
            Console.WriteLine($"{songName} is already contained!");
			continue;
        }
		songs.Enqueue(songName);
	}
	else if (command == "Show")
	{
        Console.WriteLine(string.Join(", ", songs));
    }
}

Console.WriteLine("No more songs!");