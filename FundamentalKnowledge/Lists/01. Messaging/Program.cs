List<int> numbers = Console.ReadLine() // 11 2 32 43 331 522 441 2241 711 1821
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

List<int> numbersSum = new List<int>();

string text =  Console.ReadLine(); //69da343n44ge96rous311!
string newText = string.Empty; // 2 2 5 7 7 9..

foreach (var num in numbers)
{
    char[] numToChar = num.ToString().ToCharArray(); // 1+1, 2, 3+2, 4+3..
    int totalSum = 0;

    foreach (var ch in numToChar)
        totalSum += int.Parse(ch.ToString());

    numbersSum.Add(totalSum);
}

foreach (var num in numbersSum)
{
    int number = num;

    while (number > text.Length)
    {
        number -= text.Length;
    }
    
    string currentChar = text.Substring(number, 1);
    newText += currentChar;
    text = text.Remove(number, 1);
}

Console.WriteLine(newText);