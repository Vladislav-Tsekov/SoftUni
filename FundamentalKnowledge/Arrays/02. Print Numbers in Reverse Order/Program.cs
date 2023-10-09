


int n = int.Parse(Console.ReadLine());

int[] sequence = new int[n];

for (int i = 0; i < sequence.Length; i++)
{
    int number = int.Parse(Console.ReadLine());
    sequence[i] = number;
}

for (int j = sequence.Length - 1; j >= 0; j--)
{
    Console.Write(sequence[j] + " ");
}