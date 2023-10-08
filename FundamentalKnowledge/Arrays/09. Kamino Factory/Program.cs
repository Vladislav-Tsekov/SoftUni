
int dnaLength = int.Parse(Console.ReadLine());

int[] dnaArray = { dnaLength };
int dnaSequence = 1;
int maxSequence = 0;
int sample = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "Clone them!")
    {
        break;
    }

    sample++;

    int[] dna = input
    .Split("!", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

    foreach (var item in dna)
    {
        if (item == 1)
        {
            dnaSequence++;
        }
        if (dnaSequence > maxSequence)
        {
            maxSequence = dnaSequence;
        }
        else if (item == 0)
        {
            break;
        }
    }
}

Console.WriteLine($"{dnaSequence}, {maxSequence}, {sample}, {bestSample}");





