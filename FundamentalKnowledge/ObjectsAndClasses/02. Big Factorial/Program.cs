

using System.Numerics;

BigInteger input = int.Parse(Console.ReadLine());

BigInteger result = 1;

for (int i = 2; i <= input; i++)
{
    result *= i;
}

Console.WriteLine(result);
