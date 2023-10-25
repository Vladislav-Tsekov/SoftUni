using System;

namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            int wonTournaments = 0;

            for (int loops = 0; loops < tournaments; loops++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    totalPoints += 2000;
                    wonTournaments++;
                }
                else if (stage == "F")
                {
                    totalPoints += 1200;
                }
                else if (stage == "SF")
                {
                    totalPoints += 720;
                }
            }

            double averagePoints = (double)totalPoints / tournaments;
            averagePoints = Math.Floor(averagePoints);
            double toursWonPrcnt = (double)wonTournaments / tournaments * 100;

            Console.WriteLine($"Final points: {totalPoints + startingPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{toursWonPrcnt:f2}%");
        }
    }
}
