

string input = Console.ReadLine();

var stack = new Stack<int>();

for (int i = 0; i < input.Length; i++)
{
    char currentChar = input[i];
	if (currentChar == '(')
	{ 
		stack.Push(i); 
	}
	else if (currentChar == ')')
	{
		int startIndex = stack.Pop();
		int endIndex = i + 1;
		string subExpression = input.Substring(startIndex, endIndex - startIndex);
		Console.WriteLine(subExpression);
	}
}