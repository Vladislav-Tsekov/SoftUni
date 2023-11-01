

using System.Runtime.CompilerServices;

int n = int.Parse(Console.ReadLine());

List<Car> cars = new();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string model = input[0];
    double fuelAmount = double.Parse(input[1]);
    double fuelConsumption = double.Parse(input[2]); //per km

    Car currentCar = new Car(model, fuelAmount, fuelConsumption);
    cars.Add(currentCar);
}

string command = string.Empty;
while ((command = Console.ReadLine()) != "End")
{
    string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string model = input[1];
    double distanceToTravel = double.Parse(input[2]);
    Car driveCar = cars.Where(c => c.Model == model).First();
    driveCar.Drive(distanceToTravel);
}

foreach (var car in cars)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.DistanceTravelled}");
}

public class Car 
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumption { get; set; } //per kilometer
    public double DistanceTravelled { get; set; }

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumption = fuelConsumption;
    }

    public void Drive(double distanceToTravel) 
    {
        bool canMove = FuelAmount >= FuelConsumption * distanceToTravel;
        if (canMove)
        {
            FuelAmount -= FuelConsumption * distanceToTravel;
            DistanceTravelled += distanceToTravel;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}