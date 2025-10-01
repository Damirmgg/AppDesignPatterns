using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.Vehicles
{
    internal class Motorcycle : IVehicle
    {
        string MotoType;
        string Capacity;
        public Motorcycle(string motoType, string capacity)
        {
            MotoType = motoType;
            Capacity = capacity;
        }
        public void Drive()
        {
            Console.WriteLine($"Motocycle {MotoType} with {Capacity} capacity engine is driving");
        }
        public void Refuel()
        {
            Console.WriteLine($"Motorcycle {MotoType} is refueling");
        }
    }
}
