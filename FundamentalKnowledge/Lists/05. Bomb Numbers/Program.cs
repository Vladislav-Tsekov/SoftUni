using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bomb = array[0];
            int bombPower = array[1];
            int bombIndex = numbers.IndexOf(bomb);

            while (numbers.Contains(bomb))
            {
                int start = bombIndex - bombPower;
                if (start < 0)
                {
                    start = 0;
                }

                int end = bombIndex + bombPower;
                if (end > numbers.Count - 1)
                {
                    end = numbers.Count - 1;
                }

                numbers.RemoveRange(start, end - start + 1);
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
