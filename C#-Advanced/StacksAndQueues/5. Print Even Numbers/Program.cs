
using System.Text;

int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
Queue<int> queue = new Queue<int>();

foreach (var num in input)
{
    queue.Enqueue(num);
}

List<int> sb = new List<int>();

while (queue.Count > 0)
{
    int currentNum = queue.Peek();

    if (currentNum % 2 == 0)
	{
        sb.Add(currentNum);
        queue.Dequeue();
	}
    else
    {
        queue.Dequeue();
    }
}

Console.WriteLine(string.Join(", ", sb));