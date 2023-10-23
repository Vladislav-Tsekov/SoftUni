//Input            Output
//4                1.Apples
//Potatoes         2.Onions
//Tomatoes         3.Potatoes
//Onions           4.Tomatoes
//Apples


int n = int.Parse(Console.ReadLine());
List<string> listOfProducts = new List<string>();

for (int i = 1; i <= n; i++)
{
    string products = Console.ReadLine();
    listOfProducts.Add(products);
}

listOfProducts.Sort();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"{i}.{listOfProducts[i-1]}");
}

