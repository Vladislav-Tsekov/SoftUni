using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engineList = new();

            for (int i = 0; i < n; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine currentEngine = new Engine(engineData[0], int.Parse(engineData[1]));

                if (engineData.Length == 3) 
                {
                    if (int.TryParse(engineData[2], out int displacement))
                    {
                        currentEngine.Displacement = displacement;
                    }
                    else
                    {
                        currentEngine.Efficiency = engineData[2];
                    }
                }
                else if (engineData.Length == 4)
                {
                    currentEngine.Displacement = int.Parse(engineData[2]);
                    currentEngine.Efficiency = engineData[3];
                }

                engineList.Add(currentEngine);
            }

            int m = int.Parse(Console.ReadLine());

            List<Car> carList = new(); 

            for (int i = 0; i < m; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var engineMatch = engineList.Where(e => e.Model == carData[1]).First();

                Car currentCar = new Car(carData[0], engineMatch);

                if (carData.Length == 3)
                { 
                    if (int.TryParse(carData[2], out int weight))
                    {
                        currentCar.Weight = weight;
                    }
                    else
                    {
                        currentCar.Color = carData[2];
                    }
                }
                else if (carData.Length == 4)
                {
                    currentCar.Weight = int.Parse(carData[2]);
                    currentCar.Color = carData[3];
                }

                carList.Add(currentCar);
            }

            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
