

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string cmd = Console.ReadLine();

while (cmd != "end")
{
    string[] cmdBreakdown = cmd.Split(" ");

    if (cmdBreakdown[0] == "Add")
    {
        int convertedInt = Convert.ToInt32(cmdBreakdown[1]);
        numbers.Add(convertedInt);
    }
    else if (cmdBreakdown[0] == "Remove")
    {
        int convertedInt = Convert.ToInt32(cmdBreakdown[1]);
        numbers.Remove(convertedInt);
    }
    else if (cmdBreakdown[0] == "RemoveAt")
    {
        int convertedInt = Convert.ToInt32(cmdBreakdown[1]);
        numbers.RemoveAt(convertedInt);
    }
    else if (cmdBreakdown[0] == "Insert")
    {
        int convertedInt = Convert.ToInt32(cmdBreakdown[1]);
        int convertedIndex = Convert.ToInt32(cmdBreakdown[2]);
        numbers.Insert(convertedIndex, convertedInt);
    }
    cmd = Console.ReadLine();
}

Console.WriteLine(String.Join(" ", numbers));

