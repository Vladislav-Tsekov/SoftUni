using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int flowersCnt = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (flowers == "Roses")
            {
                totalPrice = flowersCnt * 5;

                if (flowersCnt > 80)
                {
                    totalPrice -= totalPrice * 0.1;
                }
            }
            else if (flowers == "Dahlias")
            {
                totalPrice = flowersCnt * 3.80;

                if (flowersCnt > 90)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                totalPrice = flowersCnt * 2.80;

                if (flowersCnt > 80)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                totalPrice = flowersCnt * 3;

                if (flowersCnt < 120)
                {
                    totalPrice += totalPrice * 0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                totalPrice = flowersCnt * 2.50;

                if (flowersCnt < 80)
                {
                    totalPrice += totalPrice * 0.2;
                }
            }

            double result = budget - totalPrice;
            double resultNeg = totalPrice - budget;

            if (result >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCnt} {flowers} and {result:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {resultNeg:f2} leva more.");
            }
        }
    }
}
