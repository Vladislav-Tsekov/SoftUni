

int capacity = int.Parse(Console.ReadLine());

Queue<string> traffic =  new Queue<string>();

string carOrGreen = string.Empty;

int carsPassed = 0;

while ((carOrGreen = Console.ReadLine()) != "end")
{
	if (carOrGreen == "green")
	{
        for (int i = 0; i < capacity; i++)
        {
			if (traffic.Count > 0)
			{
                string currentCar = traffic.Dequeue();
                Console.WriteLine($"{currentCar} passed!");
                carsPassed++;
            }
			//if (traffic.Count < 1)
			//{
			//	break;
			//}
        }        
	}
	else
	{
        traffic.Enqueue(carOrGreen);
    }
	
}

Console.WriteLine($"{carsPassed} cars passed the crossroads.");