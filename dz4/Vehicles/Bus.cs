using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.Vehicles
{
    internal class Bus : IVehicle
    {
        public int SeatCount;
        public Bus(int seatCount)
        {
            SeatCount = seatCount;
        }
        public void Drive()
        {
            Console.WriteLine($"Bus with {SeatCount} seats is driving");
        }
        public void Refuel()
        {
            Console.WriteLine($"Bus is refueling");
        }
    }
}
