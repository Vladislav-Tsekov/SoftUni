string input = string.Empty;

SortedDictionary<string, Dictionary<string, double>> keyValuePairs = new();

while ((input = Console.ReadLine()) != "Revision")
{
    string[] inputData = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    string shopName = inputData[0];
    string productName = inputData[1];
    double productPrice = double.Parse(inputData[2]);

    if (!keyValuePairs.ContainsKey(shopName))
    {
        keyValuePairs.Add(shopName, new Dictionary<string, double>());
    }

    keyValuePairs[shopName].Add(productName, productPrice);
}

foreach (var kvp in keyValuePairs)
{
    Console.WriteLine($"{kvp.Key}->");

    foreach (var shopItems in kvp.Value)
    {
        Console.WriteLine($"Product: {shopItems.Key}, Price: {shopItems.Value}");
    }
}