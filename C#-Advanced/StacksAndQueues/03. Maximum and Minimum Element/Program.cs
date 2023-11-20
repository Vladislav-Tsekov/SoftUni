

int loops = int.Parse(Console.ReadLine());

Stack<int> stack = new Stack<int>();

for (int i = 0; i < loops; i++)
{
    int[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

	int action = cmdArgs[0];

	if (action == 1)
	{
		int numberToPush = cmdArgs[1];
		stack.Push(numberToPush);
	}
	else if (action == 2 && stack.Any())
		stack.Pop();
	else if (action == 3 && stack.Any())
		Console.WriteLine(stack.Max());
	else if (action == 4 && stack.Any())
		Console.WriteLine(stack.Min());
}

Console.WriteLine(string.Join(", ", stack));