using dz4.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.VehicleFactories
{
    internal class TruckFactory : VehicleFactory
    {
        private string _weigth;
        private string _countosey;
        public TruckFactory(string weigth, string countosey)
        {
            _weigth = weigth;
            _countosey = countosey;
        }

        public override IVehicle CreateVehicle()
        {
            return new Truck(_weigth, _countosey);
        }
    }
}
