using dz4.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.VehicleFactories
{
    internal class MotorcycleFactory : VehicleFactory
    {
        private string _mototype;
        private string _capacity;
        public MotorcycleFactory(string mototype, string capacity)
        {
            _mototype = mototype;
            _capacity = capacity;
        }
        public override IVehicle CreateVehicle()
        {
            return new Motorcycle(_mototype, _capacity);
        }
    }
}
