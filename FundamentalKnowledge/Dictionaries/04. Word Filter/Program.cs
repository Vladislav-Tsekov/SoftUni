

string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(words => words.Length % 2 == 0).ToArray();

foreach (var word in words)
{
    Console.WriteLine(word);
}