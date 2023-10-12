using System;

namespace _06.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= -100 && num <= 100 && num != 0)
            {
                Console.WriteLine("Yes");
            }
            else if (num == 0)
            {
                Console.WriteLine("No");
            }
            else if (num < -100)
            {
                Console.WriteLine("No");
            }
            else if (num > 100)
            {
                Console.WriteLine("No");
            }
        }
    }
}
