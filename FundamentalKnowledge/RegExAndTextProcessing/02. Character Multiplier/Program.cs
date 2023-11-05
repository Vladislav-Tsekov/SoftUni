

string[] input = Console.ReadLine().Split(" ");

char[] stringOne = input[0].ToCharArray();
char[] stringTwo = input[1].ToCharArray();

int minLength = stringOne.Length;
int maxLength = stringTwo.Length;
int sum = 0;

if (stringOne.Length > stringTwo.Length)
{
    minLength = stringTwo.Length;
    maxLength = stringOne.Length;
}

for (int i = 0; i < minLength; i++)
{
    sum += stringOne[i] * stringTwo[i];
}

for (int i = minLength; i < maxLength; i++)
{
    if (stringOne.Length > stringTwo.Length)
    {
        sum += stringOne[i] * 1;
    }
    else
    {
        sum += stringTwo[i] * 1;
    }
    
}

Console.WriteLine(sum);
