
List<int> firstHandOfCards = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondHandOfCards = Console.ReadLine().Split().Select(int.Parse).ToList();

while (firstHandOfCards.Count > 0 && secondHandOfCards.Count > 0)
{

    if (firstHandOfCards[0] > secondHandOfCards[0])
    {
        firstHandOfCards.Add(firstHandOfCards[0]);
        firstHandOfCards.Add(secondHandOfCards[0]); 
    }
    else if (secondHandOfCards[0] > firstHandOfCards[0])
    {
        secondHandOfCards.Add(secondHandOfCards[0]);
        secondHandOfCards.Add(firstHandOfCards[0]);
    }

    firstHandOfCards.RemoveAt(0);
    secondHandOfCards.RemoveAt(0);

    if (firstHandOfCards.Count == 0)
    {
        int sum = secondHandOfCards.Sum();
        Console.WriteLine($"Second player wins! Sum: {sum}");
        break;
    }
    else if (secondHandOfCards.Count == 0)
    {
        int sum = firstHandOfCards.Sum();
        Console.WriteLine($"First player wins! Sum: {sum}");
        break;
    }

}