using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomineeName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int juryCnt = int.Parse(Console.ReadLine());

            double totalPoints = 0 + academyPoints;

            for (int i = 0; i < juryCnt; i++)
            {
                string actorName = Console.ReadLine();
                double actorPoints = double.Parse(Console.ReadLine());
                int actorLength = actorName.Length;

                double points = (actorLength * actorPoints) / 2;
                totalPoints += points;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nomineeName} got a nominee for leading role with {totalPoints:f1}!");
                    return;
                }
            }

            double pointsNeeded = 1250.5 - totalPoints;
            Console.WriteLine($"Sorry, {nomineeName} you need {pointsNeeded:f1} more!");

            
        }
    }
}
