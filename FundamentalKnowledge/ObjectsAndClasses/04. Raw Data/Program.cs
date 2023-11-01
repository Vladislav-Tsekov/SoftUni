int n = int.Parse(Console.ReadLine());

List<Car> cars = new List<Car>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string carModel = input[0];
    int engineSpeed = int.Parse(input[1]);
    int enginePower = int.Parse(input[2]);
    int cargoWeight = int.Parse(input[3]);
    string cargoType = input[4];

    Engine currentEngine = new(engineSpeed, enginePower);
    Cargo currentCargo = new(cargoWeight, cargoType);
    Car currentCar = new(carModel, currentEngine, currentCargo);
    cars.Add(currentCar);
}

string command = Console.ReadLine();
if (command == "fragile")
{
    var fragileCars = cars.Where(car => car.Cargo.Type == "fragile" && car.Cargo.Weight < 1000);
    foreach (var car in fragileCars)
    {
        Console.WriteLine($"{car.Model}");
    }
}
else if (command == "flamable")
{
    //print all of the cars whose Cargo Type is "flamable" and have Engine Power > 250
    var flamableCars = cars.Where(car => car.Cargo.Type == "flamable" && car.Engine.Power > 250);
    foreach (var car in flamableCars)
    {
        Console.WriteLine($"{car.Model}");
    }
}


public class Car 
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
    public Car(string model, Engine engine, Cargo cargo)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;
    }
}
public class Engine 
{
    public int Speed { get; set; }
    public int Power { get; set; }
    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }
}

public class Cargo 
{
    public int Weight { get; set; }
    public string Type { get; set; }
    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }
}