namespace _07._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cmd = "";

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while ((cmd = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = cmd.Split("/", StringSplitOptions.RemoveEmptyEntries);
                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                int weightOrHp = int.Parse(cmdArgs[3]);

                if (type == "Car")
                {
                    Car car = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = weightOrHp,
                    };

                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weightOrHp,
                    };

                    trucks.Add(truck);
                }
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (var car in cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (var truck in trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    public class Truck 
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    public class Catalogue 
    
    {
        public Car Cars { get; set; }
        public Truck Trucks { get; set; }
    }
}