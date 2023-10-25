using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string goingOrNot = Console.ReadLine();
                string[] presence = goingOrNot.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = presence[0];

                if (presence.Length == 3)
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    names.Add(name);
                }
                else
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                        continue;
                    }
                    Console.WriteLine($"{name} is not in the list!");
                }
            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            


        }
    }
}
