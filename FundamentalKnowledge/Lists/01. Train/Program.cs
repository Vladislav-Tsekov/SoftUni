using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());

            var command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs.Length > 1)
                {
                    int passengers = int.Parse(cmdArgs[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int newPassangers = (int.Parse(command));
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + newPassangers > wagonCapacity)
                        {
                            continue;
                        }
                        else
                        {
                            wagons[i] += newPassangers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
