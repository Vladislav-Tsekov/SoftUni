using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Vehicle> vehicles = new List<Vehicle>();

            int totalCarsCnt = 0;
            int totalTrucksCnt = 0;
            double totalTrucksHP = 0;
            double totalCarHP = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string vehicleType = inputArgs[0];
                string vehicleModel = inputArgs[1];
                string vehicleColor = inputArgs[2];
                int vehicleHP = int.Parse(inputArgs[3]);

                if (vehicleType == "car")
                {
                    totalCarsCnt++;
                    totalCarHP += vehicleHP;
                }
                else if (vehicleType == "truck")
                {
                    totalTrucksCnt++;
                    totalTrucksHP += vehicleHP;
                }

                Vehicle currentVehicle = new Vehicle()
                { 
                    VehicleType = vehicleType,
                    VehicleModel = vehicleModel,
                    VehicleColor = vehicleColor,
                    VehicleHP = vehicleHP,
                };

                vehicles.Add(currentVehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles)
                {
                    if (input == vehicle.VehicleModel)
                    {
                        if (vehicle.VehicleType == "car")
                        {
                            Console.WriteLine("Type: Car");
                        }
                        else if (vehicle.VehicleType == "truck")
                        {
                            Console.WriteLine("Type: Truck");
                        }
                        Console.WriteLine("Model: " + vehicle.VehicleModel);
                        Console.WriteLine("Color: " + vehicle.VehicleColor);
                        Console.WriteLine("Horsepower: " + vehicle.VehicleHP);
                    }
                }   

            }

            double carsAvgHP = totalCarHP / totalCarsCnt;
            double trucksAvgHP = totalTrucksHP / totalTrucksCnt; 

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHP:f2}.");
        }
    }

    public class Vehicle 
    {
        public string VehicleType { get; set; }
        public string VehicleModel { get; set;}
        public string VehicleColor { get; set;}
        public int VehicleHP { get; set;}
    }
}
