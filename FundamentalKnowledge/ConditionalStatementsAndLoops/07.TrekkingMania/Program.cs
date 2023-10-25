using System;

namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hikingGroups = int.Parse(Console.ReadLine());

            int musalaCnt = 0;
            int monblanCnt = 0;
            int kilimandjaroCnt = 0;
            int k2Cnt = 0;
            int everestCnt = 0;
            int totalPeople = 0;

            for (int loop = 0; loop < hikingGroups; loop++)
            {
                int peopleCnt = int.Parse(Console.ReadLine());
                totalPeople += peopleCnt;

                if (peopleCnt <= 5)
                {
                    musalaCnt += peopleCnt;
                }
                else if (peopleCnt <= 12 && peopleCnt >= 6)
                {
                    monblanCnt += peopleCnt;
                }
                else if (peopleCnt <= 25 && peopleCnt >= 13)
                {
                    kilimandjaroCnt += peopleCnt;
                }
                else if (peopleCnt <= 40 && peopleCnt >= 26)
                {
                    k2Cnt += peopleCnt;
                }
                else if (peopleCnt > 40)
                {
                    everestCnt += peopleCnt;
                }
            }

            double pplAtMusala = (double)musalaCnt / totalPeople * 100;
            double pplAtMonblan = (double)monblanCnt / totalPeople * 100;
            double pplAtKilimandjaro = (double)kilimandjaroCnt / totalPeople * 100;
            double pplAtK2 = (double)k2Cnt / totalPeople * 100;
            double pplAtEverest = (double)everestCnt / totalPeople * 100;

            Console.WriteLine($"{pplAtMusala:f2}%");
            Console.WriteLine($"{pplAtMonblan:f2}%");
            Console.WriteLine($"{pplAtKilimandjaro:f2}%");
            Console.WriteLine($"{pplAtK2:f2}%");
            Console.WriteLine($"{pplAtEverest:f2}%");

        }
    }
}
