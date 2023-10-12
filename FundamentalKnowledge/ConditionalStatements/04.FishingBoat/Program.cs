using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double boatCost = 0;

            if (season == "Spring")
            {
                boatCost = 3000;

                if (fishermen <= 6)
                {
                    boatCost -= boatCost * 0.1;
                }
                else if (fishermen > 6 && fishermen <= 11)
                {
                    boatCost -= boatCost * 0.15;
                }
                else if (fishermen > 12)
                {
                    boatCost -= boatCost * 0.25;
                }
            }

            else if (season == "Summer")
            {
                boatCost = 4200;

                if (fishermen <= 6)
                {
                    boatCost -= boatCost * 0.1;
                }
                else if (fishermen > 6 && fishermen <= 11)
                {
                    boatCost -= boatCost * 0.15;
                }
                else if (fishermen > 12)
                {
                    boatCost -= boatCost * 0.25;
                }
            }

            else if (season == "Autumn")
            {
                boatCost = 4200;

                if (fishermen <= 6)
                {
                    boatCost -= boatCost * 0.1;
                }
                else if (fishermen > 6 && fishermen <= 11)
                {
                    boatCost -= boatCost * 0.15;
                }
                else if (fishermen > 12)
                {
                    boatCost -= boatCost * 0.25;
                }
            }

            else if (season == "Winter")
            {
                boatCost = 2600;

                if (fishermen <= 6)
                {
                    boatCost -= boatCost * 0.1;
                }
                else if (fishermen > 6 && fishermen <= 11)
                {
                    boatCost -= boatCost * 0.15;
                }
                else if (fishermen > 12)
                {
                    boatCost -= boatCost * 0.25;
                }
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                boatCost -= boatCost * 0.05;
            }

            if (budget - boatCost >= 0)
            {
                double moneyLeft = budget - boatCost;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }

            else
            {
                double moneyNeeded = boatCost - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }

        }
    }
}
