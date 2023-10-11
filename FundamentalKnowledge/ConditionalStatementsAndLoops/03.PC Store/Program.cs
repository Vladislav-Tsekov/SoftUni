double balance = double.Parse(Console.ReadLine());
double totalSpent = 0;
string gameName = Console.ReadLine();

while (gameName != "Game Time")
{
    if (gameName == "OutFall 4")
	{
	    if (balance - 39.99 < 0)
		{
			Console.WriteLine("Too Expensive");
		}
		else 
		{
			totalSpent += 39.99;
            balance -= 39.99;
			Console.WriteLine($"Bought {gameName}");
		}
	}
	else if (gameName == "CS: OG")
    {
        if (balance - 15.99 < 0)
        {
            Console.WriteLine("Too Expensive");
            
        }
        else
        {
            totalSpent += 15.99;
            balance -= 15.99;
            Console.WriteLine($"Bought {gameName}");
        }
    }
    else if (gameName == "Zplinter Zell")
    {
        if (balance - 19.99 < 0)
        {
            Console.WriteLine("Too Expensive");
            
        }
        else
        {
            totalSpent += 19.99;
            balance -= 19.99;
            Console.WriteLine($"Bought {gameName}");
        }
    }
    else if (gameName == "Honored 2")
    {
        if (balance - 59.99 < 0)
        {
            Console.WriteLine("Too Expensive");
            
        }
        else
        {
            totalSpent += 59.99;
            balance -= 59.99;
            Console.WriteLine($"Bought {gameName}");
        }
    }
    else if (gameName == "RoverWatch")
    {
        if (balance - 29.99 < 0)
        {
            Console.WriteLine("Too Expensive");
            
        }
        else
        {
            totalSpent += 29.99;
            balance -= 29.99;
            Console.WriteLine($"Bought {gameName}");
        }
    }
    else if (gameName == "RoverWatch Origins Edition")
    {
        if (balance - 39.99 < 0)
        {
            Console.WriteLine("Too Expensive");
            
        }
        else
        {
            totalSpent += 39.99;
            balance -= 39.99;
            Console.WriteLine($"Bought {gameName}");
        }
    }
    else
	{
		Console.WriteLine($"Not Found");
	}
    if (balance <= 0)
    {
        Console.WriteLine("Out of money!");
        return;
    }

    gameName = Console.ReadLine();

    if (gameName == "Game Time")
    {
        double remaining = balance - totalSpent;
        Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${balance:f2}");
    }
}

