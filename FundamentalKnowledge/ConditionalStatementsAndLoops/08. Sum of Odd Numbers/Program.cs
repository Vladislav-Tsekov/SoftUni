namespace _08._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int oddNumbersCnt = 0;

            for (int i = 1; i >= oddNumbersCnt; i++)
            {
                if (oddNumbersCnt == number)
                {
                    Console.WriteLine($"Sum: {sum}");
                    return;
                }
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                    oddNumbersCnt++;
                }
            }
        }
    }
}