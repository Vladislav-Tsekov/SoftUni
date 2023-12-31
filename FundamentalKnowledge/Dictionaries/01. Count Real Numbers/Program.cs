﻿


internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        SortedDictionary<int, int> sortedNumbers = new SortedDictionary<int, int>();

        foreach (var number in input)
        {
            if (!sortedNumbers.ContainsKey(number))
            {
                sortedNumbers.Add(number, 1);
            }
            else
            {
                sortedNumbers[number]++;
            }
        }

        foreach (var number in sortedNumbers) 
        {
            Console.WriteLine($"{number.Key} -> {number.Value}");
        }
    }
}