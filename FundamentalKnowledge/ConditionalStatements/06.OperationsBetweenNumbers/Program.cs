using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int result = 0;

            if (oper == "+")
            {
                result = n1 + n2;
                int oddOrNot = result % 2;
                if (oddOrNot == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} + {n2} = {result} - odd");
                }  
            }

            else if (oper == "-")
            {
                result = n1 - n2;
                int oddOrNot = result % 2;
                if (oddOrNot == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} - {n2} = {result} - odd");
                }
            }

            else if (oper == "*")
            {
                result = n1 * n2;
                int oddOrNot = result % 2;
                if (oddOrNot == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} * {n2} = {result} - odd");
                }
            }

            else if (oper == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    double resultDub = (double)n1 / (double)n2;
                    Console.WriteLine($"{n1} / {n2} = {resultDub:f2}");
                }
            }

            else if (oper == "%")
            {
                result = n1 % n2;
                int oddOrNot = result % 2;
                if (n1 % n2 != 0)
                {
                    Console.WriteLine($"{n1} % {n2} = {oddOrNot}");
                }
            }

        }
    }
}
