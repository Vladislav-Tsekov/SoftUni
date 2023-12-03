using System.Linq;

int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

for (int i = 0; i < n; i++)
{
    string[] clothesInfo = Console.ReadLine() 
        .Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
    string color = clothesInfo[0];

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());
    }
    for (int piece = 1; piece < clothesInfo.Length; piece++)
    {
        string currentCloth = clothesInfo[piece];
        if (!wardrobe[color].ContainsKey(currentCloth))
        {
            wardrobe[color].Add(currentCloth, 0);
        }
        wardrobe[color][currentCloth]++;
    }
}

string[] clothesOfChoice = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string colorOfChoice = clothesOfChoice[0];
string clothOfChoice = clothesOfChoice[1];

foreach (var color in wardrobe)
{
    Console.WriteLine($"{color.Key} clothes:");
    foreach (var cloth in color.Value)
    {
        bool colorMatch = color.Key.Equals(colorOfChoice);
        bool clothMatch = cloth.Key.Equals(clothOfChoice);
        if (clothMatch && colorMatch)
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
            //* dress - 1 (found!)
        }
        else
        {
            Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
            //* dress - 1 
        }
    }
}