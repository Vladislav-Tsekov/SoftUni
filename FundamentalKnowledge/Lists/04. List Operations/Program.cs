using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string input = "";
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                string direction = cmdArgs[1];

                if (action == "Add")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Add(number);
                }
                else if (action == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, number);
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (action == "Shift" && direction == "left")
                {
                    int count = int.Parse(cmdArgs[2]);

                    for (int i = 1; i <= count; i++)
                    {
                        int firstNumber = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstNumber);
                    }
                }
                else if (action == "Shift" && direction == "right")
                {
                    int count = int.Parse(cmdArgs[2]);

                    for (int i = 1; i <= count; i++)
                    {
                        int lastNumber = numbers[numbers.Count - 1];
                        numbers.RemoveAt(numbers.Count - 1);
                        numbers.Insert(0, lastNumber);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
