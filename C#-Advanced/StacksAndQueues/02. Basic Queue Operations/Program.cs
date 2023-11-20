

int[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

int elementsToEnqueue = cmd[0];
int elementsToDequeue = cmd[1];
int elementToLookFor = cmd[2];

Queue<int> queue = new();

int[] ints = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

for (int i = 0; i < elementsToEnqueue; i++)
{
    queue.Enqueue(ints[i]);
}
for (int i = 0; i < elementsToDequeue; i++)
{
    queue.Dequeue();
}

if (!queue.Any())
{
    Console.WriteLine("0");
}
else if (queue.Contains(elementToLookFor))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(queue.Min());
}