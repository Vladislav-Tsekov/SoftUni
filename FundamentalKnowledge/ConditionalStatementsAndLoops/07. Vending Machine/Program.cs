
var input = Console.ReadLine();

double coins = 0;

while (input != "Start")
{
	if (input == "0.1")
	{
		coins += 0.1; 
	}
	else if (input == "0.2")
	{
		coins += 0.2;
	}
	else if (input == "0.5")
	{
		coins += 0.5;
	}
	else if (input == "1")
	{
		coins += 1;
	}
	else if (input == "2")
	{
		coins += 2;
	}
	else
	{
		Console.WriteLine($"Cannot accept {input}");
	}

	input = Console.ReadLine();
}
if (input == "Start")
{
	while (input != "End")
	{
		input = Console.ReadLine();
        if (input == "End")
        {
            Console.WriteLine($"Change: {coins:f2}");
            return;
        }
        if (input == "Nuts")
		{
			if (coins >= 2)
			{
				coins -= 2;
				Console.WriteLine($"Purchased nuts");
				continue;
			}
			else
			{
				Console.WriteLine($"Sorry, not enough money");
				continue;
			}
		}
        else if (input == "Water")
        {
            if (coins >= 0.7)
            {
                coins -= 0.7;
                Console.WriteLine($"Purchased water");
                continue;
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
                continue;
            }
        }
        else if (input == "Crisps")
        {
            if (coins >= 1.5)
            {
                coins -= 1.5;
                Console.WriteLine($"Purchased crisps");
                continue;
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
                continue;
            }
        }
        else if (input == "Soda")
        {
            if (coins >= 0.8)
            {
                coins -= 0.8;
                Console.WriteLine($"Purchased soda");
                continue;
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
                continue;
            }
        }
        else if (input == "Coke")
        {
            if (coins >= 1.0)
            {
                coins -= 1.0;
                Console.WriteLine($"Purchased coke");
                continue;
            }
            else
            {
                Console.WriteLine($"Sorry, not enough money");
                continue;
            }
        }
        else
        {
            Console.WriteLine("Invalid product");
        }
    }
}