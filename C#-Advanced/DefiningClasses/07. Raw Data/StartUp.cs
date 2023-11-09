using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new();

            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string[] carData = cmd.ToArray();
                
                string model = carData[0];
                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);
                int cargoWeight = int.Parse(carData[3]);
                string cargoType = carData[4];
                double tire1Pressure = double.Parse(carData[5]);
                int tire1Age = int.Parse(carData[6]);
                double tire2Pressure = double.Parse(carData[7]);
                int tire2Age = int.Parse(carData[8]);
                double tire3Pressure = double.Parse(carData[9]);
                int tire3Age = int.Parse(carData[10]);
                double tire4Pressure = double.Parse(carData[11]);
                int tire4Age = int.Parse(carData[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Car currentCar = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();
            string[] filteredCars;

            if (command == "fragile")
            {
                filteredCars = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(t => t.Pressure < 1)).Select(c => c.Model).ToArray();
            }
            else
            {
                filteredCars = cars
                    .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250).Select(c => c.Model).ToArray();    
            }

            foreach (var car in filteredCars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
