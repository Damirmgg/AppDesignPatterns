using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.Vehicles
{
    internal class Car : IVehicle
    {
        public string Brand;
        public string Model;
        public string FuelType;
        public Car(string brand, string model, string fuelType)
        {
            Brand = brand;
            Model = model;
            FuelType = fuelType;
        }
        public void Drive()
        {
            Console.WriteLine($"Car {Brand} {Model} driving on {FuelType}");
        }
        public void Refuel()
        {
            Console.WriteLine($"{Brand} {Model} is refueling with {FuelType}");
        }
    }
}
