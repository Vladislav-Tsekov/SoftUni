

string[] setsLength = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();

for (int i = 0; i < int.Parse(setsLength[0]); i++)
{
    int num1 = int.Parse(Console.ReadLine());
    firstSet.Add(num1);
}
for (int i = 0; i < int.Parse(setsLength[1]); i++)
{
    int num2 = int.Parse(Console.ReadLine());
    secondSet.Add(num2);
}

firstSet.IntersectWith(secondSet);

foreach (var item in firstSet)
{
    Console.Write($"{item} ");
}
