
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int[] myArr = new int[3] {num1, num2, num3};

Array.Sort(myArr);
Array.Reverse(myArr);

foreach (int val in myArr)
{ 
    Console.WriteLine(val);
}
