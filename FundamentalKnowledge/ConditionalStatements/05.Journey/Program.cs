using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = "";
            string accomodation = "";
            double cost = 0;

            if (budget <= 100)
            {
                location += "Bulgaria";

                if (season == "summer")
                {
                    accomodation += "Camp";
                    cost = budget * 0.3;
                }
                if (season == "winter")
                {
                    accomodation += "Hotel";
                    cost = budget * 0.7;
                }
            }

            if (budget > 100 && budget <= 1000)
            {
                location += "Balkans";

                if (season == "summer")
                {
                    accomodation += "Camp";
                    cost = budget * 0.4;
                }
                if (season == "winter")
                {
                    accomodation += "Hotel";
                    cost = budget * 0.8;
                }
            }

            if (budget > 1000)
            {
                location += "Europe";
                cost = budget * 0.9;
                accomodation += "Hotel";
            }

            Console.WriteLine($"Somewhere in {location}");
            Console.WriteLine($"{accomodation} - {cost:f2}");

        }
    }
}
