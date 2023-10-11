using System;

namespace _04._Back_in_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minsAfter30 = minutes + 30;

            if (minsAfter30 >= 60)
            {
                hours++;
                minsAfter30 -= 60;
            }
            if (hours == 24)
            {
                hours = 0;
            }
            
            Console.WriteLine($"{hours}:{minsAfter30:d2}");
        }
    }
}
