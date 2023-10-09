


using System.Diagnostics.Tracing;

Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

int loops = int.Parse(Console.ReadLine());

for (int i = 0; i < loops; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!synonyms.ContainsKey(word))
    {
        List<string> newWords = new List<string>();
        synonyms.Add(word, newWords);
    }

    List<string> currentWords = synonyms[word];
    currentWords.Add(synonym);
   
}

foreach (var word in synonyms)
{
    Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
}