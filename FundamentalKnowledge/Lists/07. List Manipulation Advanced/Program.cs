



List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string cmd = Console.ReadLine();

bool hasChanges = false;

while (cmd != "end")
{
    string[] cmdBreakdown = cmd.Split(" ");

    if (cmdBreakdown[0] == "Add")
    {
        int convertedInt = Convert.ToInt32(cmdBreakdown[1]);
        numbers.Add(convertedInt);
        hasChanges = true;
    }
    else if (cmdBreakdown[0] == "Remove")
    {
        int convertedInt = Convert.ToInt32(cmdBreakdown[1]);
        numbers.Remove(convertedInt);
        hasChanges = true;
    }
    else if (cmdBreakdown[0] == "RemoveAt")
    {
        int convertedInt = Convert.ToInt32(cmdBreakdown[1]);
        numbers.RemoveAt(convertedInt);
        hasChanges = true;
    }
    else if (cmdBreakdown[0] == "Insert")
    {
        int convertedInt = Convert.ToInt32(cmdBreakdown[1]);
        int convertedIndex = Convert.ToInt32(cmdBreakdown[2]);
        numbers.Insert(convertedIndex, convertedInt);
        hasChanges = true;
    }
    else if (cmdBreakdown[0] == "Contains")
    {
        int convertedInt = Convert.ToInt32(cmdBreakdown[1]);
        bool Contains = numbers.Contains(convertedInt);

        if (Contains)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (cmdBreakdown[0] == "PrintEven")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        Console.WriteLine();
    }
    else if (cmdBreakdown[0] == "PrintOdd")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 != 0)
            {
                Console.Write(numbers[i] + " ");
            }
        }
        Console.WriteLine();
    }
    else if (cmdBreakdown[0] == "GetSum")
    {
        int totalSum = numbers.Sum();
        Console.WriteLine(totalSum);
    }
    else if (cmdBreakdown[0] == "Filter")
    {
        string condition = cmdBreakdown[1];
        int number = int.Parse(cmdBreakdown[2]);

        if (condition == ">=")
        {
            foreach (var item in numbers)
            {
                if (item >= number)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == "<=")
        {
            foreach (var item in numbers)
            {
                if (item <= number)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == ">")
        {
            foreach (var item in numbers)
            {
                if (item > number)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
        else if (condition == "<")
        {
            foreach (var item in numbers)
            {
                if (item < number)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }

    cmd = Console.ReadLine();
}

if (hasChanges)
{
    Console.WriteLine(String.Join(" ", numbers));
}

