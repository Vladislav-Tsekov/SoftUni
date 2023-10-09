
string cmd = string.Empty;

Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

while ((cmd = Console.ReadLine()) != "buy")
{
    string[] cmdArgs = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string productName = cmdArgs[0];
    double productPrice = double.Parse(cmdArgs[1]);
    double productQty = double.Parse(cmdArgs[2]);

    if (!products.ContainsKey(productName))
    {
        products.Add(productName, new List<double> { productPrice, productQty });
    }

    else
    {
        products[productName][0] = productPrice;
        products[productName][1] += productQty;
    }
}

foreach (var item in products)
{
    Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
}

