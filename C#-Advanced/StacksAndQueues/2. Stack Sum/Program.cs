
int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Stack<int> numberStack = new Stack<int>();

foreach (var num in input)
{
    numberStack.Push(num);
}

string cmd = string.Empty;
while ((cmd = Console.ReadLine()) != "end")
{
    string[] cmdArgs = cmd.Split(" ");
    string action = cmdArgs[0].ToLower();

    if (action == "add")
    {
        int number1 = int.Parse(cmdArgs[1]);
        int number2 = int.Parse(cmdArgs[2]);
        numberStack.Push(number1);
        numberStack.Push(number2);
    }
    else if (action == "remove")
    { 
        int number = int.Parse(cmdArgs[1]);
        if (number > numberStack.Count)
        {
            continue;
        }
        for (int i = 0; i < number; i++)
        {
            numberStack.Pop();
        }
    }
}

int result = numberStack.Sum();
Console.WriteLine($"Sum: {result}");