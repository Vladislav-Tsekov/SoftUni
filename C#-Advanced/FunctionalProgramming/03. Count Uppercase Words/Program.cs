

string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

Func<string, bool> isUpper = c => Char.IsUpper(c[0]);

string[] upperCase = text.Where(isUpper).ToArray();

foreach (var word in upperCase)
{
    Console.WriteLine(word);
}