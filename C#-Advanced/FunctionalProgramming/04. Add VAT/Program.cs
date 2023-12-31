﻿

//Create a program that reads one line of double prices separated by ", ". 
//    Print the prices with added VAT for all of them. Format them to 2 signs after the decimal point. 
//    The order of the prices must be the same. VAT is equal to 20% of the price.

double[] prices = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();

foreach (var price in prices)
{
    double currentPrice = price;
    Console.Write($"{currentPrice += currentPrice * 0.20:f2}\n");
}