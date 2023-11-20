

int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int elementsToPush = input[0];
int elementsToPop = input[1];
int elementToLookFor = input[2]; //If it’s found, print "true" on the console. If it isn't, print the smallest element currently present in the stack. If there are no elements in the sequence, print 0 on the console.

int[] ints = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Stack<int> stack = new();

for (int i = 0; i < elementsToPush; i++)
{
    stack.Push(ints[i]);
}

for (int j = 0; j < elementsToPop; j++)
{
    stack.Pop();
}

if (!stack.Any())
{
    Console.WriteLine("0");
}
else if (stack.Contains(elementToLookFor))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine($"{stack.Min()}");
}




