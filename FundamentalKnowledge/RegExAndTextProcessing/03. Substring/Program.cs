

using System.Diagnostics.Tracing;

var wordToRemove = Console.ReadLine();
var words = Console.ReadLine();



while (words.Contains(wordToRemove))
{
    int index = words.IndexOf(wordToRemove);
    words = words.Remove(index, wordToRemove.Length);
}

Console.WriteLine(words);