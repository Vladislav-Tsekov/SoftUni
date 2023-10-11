
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

if (y > 10)
{
    int result = x * y;
    Console.WriteLine($"{x} X {y} = {result}");
    return;
}

for (int i = y; y <= 10; y++)
{
    int result = x * y;
    Console.WriteLine($"{x} X {y} = {result}");
}