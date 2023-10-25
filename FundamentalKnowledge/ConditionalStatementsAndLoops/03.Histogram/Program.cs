using System;

namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int p1Cnt = 0;
            int p2Cnt = 0;
            int p3Cnt = 0;
            int p4Cnt = 0;
            int p5Cnt = 0;

            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());

                if (nums < 200)
                {
                    p1Cnt += 1;
                }
                else if (nums >= 200 && nums <= 399)
                {
                    p2Cnt += 1;
                }
                else if (nums >= 400 && nums <= 599)
                {
                    p3Cnt += 1;
                }
                else if (nums >= 600 && nums <= 799)
                {
                    p4Cnt += 1;
                }
                else if (nums >= 800)
                {
                    p5Cnt += 1;
                }
            }

            double p1 = (double)p1Cnt / n * 100;
            Console.WriteLine($"{p1:f2}%");
            double p2 = (double)p2Cnt / n * 100;
            Console.WriteLine($"{p2:f2}%");
            double p3 = (double)p3Cnt / n * 100;
            Console.WriteLine($"{p3:f2}%");
            double p4 = (double)p4Cnt / n * 100;
            Console.WriteLine($"{p4:f2}%");
            double p5 = (double)p5Cnt / n * 100;
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
