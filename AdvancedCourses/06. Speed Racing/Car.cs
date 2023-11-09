

namespace DefiningClasses;

public class Car
{
    private string model; //VERIFICATION?
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; }
    public double TravelledDistance { get; set; }

    public Car() { }
    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumption;
    }

    public void IsFuelSufficientOrNot(string model, double kmAmount)
    {
        double consumption = FuelConsumptionPerKilometer * kmAmount;

        if (FuelAmount >= consumption)
        {
            FuelAmount -= consumption;
            TravelledDistance += kmAmount;
        }
        else
        {
            Console.WriteLine($"Insufficient fuel for the drive");
        }
    }


}