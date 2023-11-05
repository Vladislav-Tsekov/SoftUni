

using System.Text;

string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

StringBuilder wordsCollection = new StringBuilder();

foreach (string word in words)
{
	for (int i = 0; i < word.Length; i++)
	{
		wordsCollection.Append(word);
	}
}

Console.WriteLine(wordsCollection);
