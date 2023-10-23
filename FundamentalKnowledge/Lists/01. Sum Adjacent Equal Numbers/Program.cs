
//Input - 8 2 2 4 8 16
//Output - 16 8 16

using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        List<double> numbers = Console.ReadLine()
    .Split(" ")
    .Select(double.Parse)
    .ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            
            
            if (numbers.Count <= i + 1)
            {
                break;
            }
            
            if (numbers[i] == numbers[i+1])
            {
                double sum = numbers[i] + numbers[i+1];
                numbers.Remove(numbers[i + 1]);
                numbers.Remove(numbers[i]);
                numbers.Insert(i, sum);
                i = -1;
                continue;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));

    }
}