

int foodQuantity = int.Parse(Console.ReadLine());
int[] foodOrders = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Queue<int> orders = new Queue<int>(foodOrders);
Console.WriteLine(orders.Max());

while (orders.Count > 0)
{
	if (foodQuantity >= orders.Peek())
	{
        foodQuantity -= orders.Dequeue();
	}
	else if (foodQuantity < orders.Peek())
	{
		Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
        return;
    }
}

Console.WriteLine("Orders complete");