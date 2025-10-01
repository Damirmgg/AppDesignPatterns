using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.Vehicles
{
    internal class Truck : IVehicle
    {
        string Gruzopodiemnost;
        string CountOsey;
        public Truck(string gruzopodiemnost, string countOsey)
        {
            Gruzopodiemnost = gruzopodiemnost;
            CountOsey = countOsey;
        }
        public void Drive()
        {
            Console.WriteLine($"Truck with weigth {Gruzopodiemnost} is driving");
        }
        public void Refuel()
        {
            Console.WriteLine($"Truck is refueling");
        }
    }
}
