﻿

int number = int.Parse(Console.ReadLine());

while (number % 2 != 0)
{
    Console.WriteLine($"Please write an even number.");
    number = int.Parse(Console.ReadLine());
}

if (number % 2 == 0)
{
    int absNum = Math.Abs(number);
    Console.WriteLine($"The number is: {absNum}");
}