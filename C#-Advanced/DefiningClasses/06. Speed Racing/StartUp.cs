using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses;

public class StartUp
{
    public static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (double i = 0; i < n; i++)
        {
            string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Car currentCar = new Car(carData[0], double.Parse(carData[1]), double.Parse(carData[2]));
            cars.Add(currentCar);
        }

        string cmd = string.Empty;

        while ((cmd = Console.ReadLine()) != "End")
        {
            string[] cmdArgs = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = cmdArgs[1];
            double kmAmount = double.Parse(cmdArgs[2]);

            Car driveCar = cars.Where(car => car.Model == model).FirstOrDefault();
            driveCar.IsFuelSufficientOrNot(model, kmAmount);
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
        }
    }
}
