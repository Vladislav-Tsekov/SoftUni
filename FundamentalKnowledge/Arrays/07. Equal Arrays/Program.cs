

//Read two arrays and determine whether they are identical or not. The arrays are identical, if all their elements are equal. If the arrays are identical, find the sum of the elements of one of them and print the following message to the console: "Arrays are identical. Sum: {sum}"

//Otherwise, find the first index where the arrays differ and print the following message to the console:  "Arrays are not identical. Found difference at {index} index."


int[] firstArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToArray();

int sum = 0;
int indexCounter = 0;

for (int i = 0; i < firstArray.Length; i++)
{
    indexCounter = i;

    if (firstArray[i] == secondArray[i])
    {
        sum += firstArray[i];
    }
    else
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {indexCounter} index");
        return;
    }
}

Console.WriteLine($"Arrays are identical. Sum: {sum}");