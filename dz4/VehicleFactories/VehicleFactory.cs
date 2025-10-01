using dz4.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.VehicleFactories
{
    abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}
