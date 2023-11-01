namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = "";

            List<Box> boxes = new List<Box>();

            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string serialNumber = cmdArgs[0];
                string itemName = cmdArgs[1];
                int itemQuantity = int.Parse(cmdArgs[2]);
                double itemPrice = double.Parse(cmdArgs[3]);

                Item item = new Item 
                {
                    Name = itemName,
                    Price = itemPrice,
                };

                Box box = new Box
                {
                    SerialNumber = serialNumber,
                    Item = item,
                    ItemQuantity = itemQuantity,
                    PricePerBox = itemQuantity * itemPrice
                };

                boxes.Add(box);

            }

            foreach (var box in boxes.OrderByDescending(x => x.PricePerBox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
            
        }
    }

    public class Item 
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Box 
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PricePerBox { get; set; }
    }
}