int orderCnt = int.Parse(Console.ReadLine());

double totalPrice = 0;

for (int i = 1; i <= orderCnt; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCnt = int.Parse(Console.ReadLine());

    double price = (days * capsulesCnt) * pricePerCapsule;
    totalPrice += price;
    Console.WriteLine($"The price for the coffee is: ${price:f2}");
}
Console.WriteLine($"Total: ${totalPrice:f2}");