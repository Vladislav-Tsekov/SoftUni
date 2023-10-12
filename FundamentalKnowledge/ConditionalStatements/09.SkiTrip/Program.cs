using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int daysAtHotel = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double totalPrice = 0;

            if (roomType == "room for one person")
            {
                totalPrice = (daysAtHotel - 1) * 18; 
            }

            else if (roomType == "apartment")
            {
                totalPrice = (daysAtHotel - 1) * 25;

                if (daysAtHotel < 10)
                {
                    totalPrice -= totalPrice * 0.3;
                }
                else if (daysAtHotel >= 10 && daysAtHotel <= 15)
                {
                    totalPrice -= totalPrice * 0.35;
                }
                else
                {
                    totalPrice -= totalPrice * 0.5;
                }
            }

            else if (roomType == "president apartment")
            {
                totalPrice = (daysAtHotel - 1) * 35;

                if (daysAtHotel < 10)
                {
                    totalPrice -= totalPrice * 0.1;
                }
                else if (daysAtHotel >= 10 && daysAtHotel <= 15)
                {
                    totalPrice -= totalPrice * 0.15;
                }
                else
                {
                    totalPrice -= totalPrice * 0.2;
                }
            }

            if (feedback == "positive")
            {
                totalPrice += totalPrice * 0.25;
            }
            else if (feedback == "negative")
            {
                totalPrice -= totalPrice * 0.1;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
