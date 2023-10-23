﻿

List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

numbers.RemoveAll(x => x < 0);
numbers.Reverse();

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
    return;
}

Console.WriteLine(String.Join(" ", numbers));