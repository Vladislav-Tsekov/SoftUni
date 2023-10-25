

List<string> numbers = Console.ReadLine().Split("|").Reverse().ToList();

var numbersToArray = new List<int>();

foreach (var item in numbers)
{
    numbersToArray.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
}

Console.WriteLine(string.Join(" ", numbersToArray));