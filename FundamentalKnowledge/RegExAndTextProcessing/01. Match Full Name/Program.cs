


using System.Text.RegularExpressions;

string regex = (@"\b([A-Z][a-z]+) ([A-Z][a-z]+)");

string names = Console.ReadLine();

MatchCollection match = Regex.Matches(names, regex);

foreach (Match m in match) {
    Console.Write(m.Value + " ");
}
