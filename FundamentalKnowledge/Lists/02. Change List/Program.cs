using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string cmd = "";

            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];

                if (cmdArgs[0] == "Delete")
                {
                    int number = int.Parse(cmdArgs[1]);
                    numbers.Remove(number);
                }
                else if (cmdArgs[0] == "Insert")
                {
                    //Insert {element} {position} 
                    int element = int.Parse(cmdArgs[1]);
                    int position = int.Parse(cmdArgs[2]);
                    numbers.Insert(position, element);
                }              
            }

            Console.WriteLine(String.Join(" ", numbers));



        }
    }
}
