

using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
string alphanumericInput = string.Empty;
Dictionary<string, int> results = new Dictionary<string, int>();

foreach (var participant in participants)
{
    results.Add(participant, 0);
}

while ((alphanumericInput = Console.ReadLine()) != "end of race")
{
    MatchCollection nameMatches = Regex.Matches(alphanumericInput, @"([A-Za-z]+)");
    MatchCollection distanceMatches = Regex.Matches(alphanumericInput, @"(\d)");

        string name = string.Join(string.Empty, nameMatches);
        if (results.ContainsKey(name))
        {
        results[name] += distanceMatches.Select(x => int.Parse(x.Value)).Sum();
        }
}

var sortedKVP = results.OrderByDescending(kv => kv.Value).Take(3);

int i = 1;

foreach (var kvp in sortedKVP)
{
    if (i == 1)
    {
        Console.WriteLine($"1st place: {kvp.Key}");
    }
    else if (i == 2)
    {
        Console.WriteLine($"2nd place: {kvp.Key}");
    }
    else if (i == 3)
    {
        Console.WriteLine($"3rd place: {kvp.Key}");
    }
    i++;
}