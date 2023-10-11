


internal class Program
{
    private static void Main(string[] args)
    {
        string input = Console.ReadLine();

        char[] output = input.ToCharArray();

        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.Write(output[i]);
        }

    }
}