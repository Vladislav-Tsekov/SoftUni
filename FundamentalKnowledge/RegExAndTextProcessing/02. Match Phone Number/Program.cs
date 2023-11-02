

using System.Text.RegularExpressions;

string regex = (@"\s?\+359( |-)\d{1}\1\d{3}\1\d{4}\b");

string input = Console.ReadLine();

MatchCollection match = Regex.Matches(input, regex);

var matchedPhones =  match.Cast<Match>().Select(a => a.Value.Trim()).ToList();

Console.WriteLine(string.Join(", ", matchedPhones));