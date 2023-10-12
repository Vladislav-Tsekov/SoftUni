using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double ticketPrice = 0.0;

            if (projection == "Premiere")
            {
                ticketPrice += 12.00;
            }
            else if (projection == "Normal")
            {
                ticketPrice += 7.50;
            }
            else if (projection == "Discount")
            {
                ticketPrice += 5.00;
            }

            int rowsAndColums = rows * columns;
            double pricePerSalon = rowsAndColums * ticketPrice;
            Console.WriteLine($"{pricePerSalon:f2} leva");
        }
    }
}
