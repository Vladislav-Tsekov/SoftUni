using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<string> productsList = new List<string>();
            double totalSpent = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                var regex = "^>{2}(?<product>\\w+)<{2}(?<price>\\d+\\.?\\d+)!(?<quantity>\\d+)";

                MatchCollection matches = Regex.Matches(input, regex);

                foreach (Match match in matches) 
                {
                    string product = match.Groups["product"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    double totalPrice = price * quantity;
                    totalSpent += totalPrice;
                    
                    productsList.Add(product);
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (var product in productsList)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total money spend: {totalSpent:f2}");
        }
    }
}