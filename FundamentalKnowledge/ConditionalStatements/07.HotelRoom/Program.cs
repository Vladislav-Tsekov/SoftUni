using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int durationOfStay = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice += 50;
                apartPrice += 65;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice += 75.20;
                apartPrice += 68.70;
            }
            else if (month == "July" || month == "August")
            {
                studioPrice += 76;
                apartPrice += 77;
            }

           
            if (durationOfStay > 14 && month == "May" || durationOfStay > 14 && month == "October")
            {
                studioPrice = studioPrice - studioPrice * 0.3;
            }
            else if (durationOfStay > 7 && month == "May" || durationOfStay > 7 && month == "October")
            {
                studioPrice = studioPrice - studioPrice * 0.05;
            }
            else if (durationOfStay > 14 && month == "June" || durationOfStay > 14 && month == "September")
            {
                studioPrice = studioPrice - studioPrice * 0.2;
            }
            if (durationOfStay > 14)
            {
                apartPrice = apartPrice - apartPrice * 0.1;
            }

            double apartPriceOfStay = apartPrice * durationOfStay;
            double studioPriceOfStay = studioPrice * durationOfStay;

            Console.WriteLine($"Apartment: {apartPriceOfStay:f2} lv.");
            Console.WriteLine($"Studio: {studioPriceOfStay:f2} lv.");
        }
    }
}
