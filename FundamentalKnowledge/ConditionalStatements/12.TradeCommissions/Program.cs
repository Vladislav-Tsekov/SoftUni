using System;
using System.Runtime.InteropServices;

namespace _12.TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;

            switch (city)
            {
                case "Sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        comission = 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = 0.08;
                    }
                    else if (sales > 10000)
                    {
                        comission = 0.12;
                    }
                    break;

                case "Varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        comission = 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = 0.1;
                    }
                    else if (sales > 10000)
                    {
                        comission = 0.13;
                    }
                    break;

                case "Plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        comission = 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        comission = 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        comission = 0.12;
                    }
                    else if (sales > 10000)
                    {
                        comission = 0.145;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    return;
            }
            if (sales > 0)
            {
                double result = sales * comission;
                Console.WriteLine($"{result:f2}");
            }
            else if (sales < 0)
            {
                Console.WriteLine("error");
            }

        }
    }
}
