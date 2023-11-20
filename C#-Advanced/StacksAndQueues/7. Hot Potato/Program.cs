

string[] names = Console.ReadLine().Split(" ");
int n = int.Parse(Console.ReadLine());

Queue<string> playersQueue = new Queue<string>(names);

while (playersQueue.Count > 1)
{
	for (int i = 1; i < n; i++)
	{
		string player = playersQueue.Dequeue();
		playersQueue.Enqueue(player);
	}
	string playerLost = playersQueue.Dequeue();
    Console.WriteLine($"Removed {playerLost}");
}

string lastPlayer = playersQueue.Peek();
Console.WriteLine($"Last is {lastPlayer}");