
//Create a program to read an array and condense them by summing all adjacent couples of elements until a single integer remains.
//For example, let us say we have 3 elements - {2, 10, 3}.
//We sum the first two and the second two elements and get {2 + 10, 10 + 3} = { 12, 13},
//then we sum all adjacent elements again. This results in {12 + 13} = { 25}.

int[] numbers = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();



int totalSum = 0;

for (int i = 0; i < numbers.Length - 1; i++)
{
    for (int j = 0; j < numbers.Length - 1 - i; j++)
    {
        numbers[j] = numbers[j] + numbers[j + 1];
    }

}

Console.WriteLine(numbers[0]);

