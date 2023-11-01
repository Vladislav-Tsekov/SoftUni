
string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);



for (int i = 0; i < input.Length; i++)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, input.Length);
    string currentWord = input[i];
    string wordToSwap = input[randomIndex];

    input[i] = wordToSwap;
    input[randomIndex] = currentWord;
}

Console.WriteLine(string.Join(Environment.NewLine, input));