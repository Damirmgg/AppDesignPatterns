using dz4.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.VehicleFactories
{
    internal class BusFactory : VehicleFactory
    {
        private int _SeatCount;
        public BusFactory(int seatCount)
        {
            _SeatCount = seatCount;
        }
        public override IVehicle CreateVehicle()
        {
            return new Bus(_SeatCount);
        }
    }
}
