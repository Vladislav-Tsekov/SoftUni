string input = Console.ReadLine();

int evenOrOdd = input.Length % 2;
bool isEven = evenOrOdd == 0;
if (isEven == false)
{
    Console.WriteLine("NO");
    return;
}

Stack<string> openingBrackets = new Stack<string>();

foreach (var ch in input)
{
    if (ch == '{')
    {
        openingBrackets.Push(ch.ToString());
        int indexOf = input.IndexOf('{');
        input = input.Remove(indexOf, 1);
    }
    else if (ch == '[')
    {
        openingBrackets.Push(ch.ToString());
        int indexOf = input.IndexOf('[');
        input = input.Remove(indexOf, 1);
    }
    else if (ch == '(')
    {
        openingBrackets.Push(ch.ToString());
        int indexOf = input.IndexOf('(');
        input = input.Remove(indexOf, 1);
    }
}

while (openingBrackets.Count > 0)
{
    if (openingBrackets.Peek() == "{" && input[0] == '}')
    {
        openingBrackets.Pop();
        input = input.Remove(0, 1);
    }
    else if (openingBrackets.Peek() == "[" && input[0] == ']')
    {
        openingBrackets.Pop();
        input = input.Remove(0, 1);
    }
    else if (openingBrackets.Peek() == "(" && input[0] == ')')
    {
        openingBrackets.Pop();
        input = input.Remove(0, 1);
    }
    else
    {
        Console.WriteLine("NO");
        return;
    }
}

bool isEmpty = input.Length == 0 || openingBrackets.Count == 0;

if (isEmpty)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");
