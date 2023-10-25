using System;

namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int money = 0;

            for (int currYear = 1; currYear <= age; currYear++)
            {
                if (currYear % 2 != 0)
                {
                    money += toyPrice;
                }
                else
                {
                    int moneyGift = (currYear / 2) * 10;
                    money += moneyGift;
                    money -= 1;
                }
            }

            if (money >= washerPrice)
            {
                double moneyLeft = money - washerPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else if (washerPrice > money)
            {
                double moneyNeeded = washerPrice - money;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
