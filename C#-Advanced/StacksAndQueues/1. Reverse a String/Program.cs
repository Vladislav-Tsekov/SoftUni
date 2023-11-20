

string input = Console.ReadLine();

Stack<char> newStack = new Stack<char>();

foreach (var ch in input)
{
    newStack.Push(ch);
}

while (newStack.Count > 0)
{
    Console.Write(newStack.Pop());
}
    

    
