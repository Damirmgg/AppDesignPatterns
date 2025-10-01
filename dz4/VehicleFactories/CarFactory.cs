using dz4.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4.VehicleFactories
{
    internal class CarFactory : VehicleFactory
    {
        private string _brand;
        private string _model;
        private string _fueltype;
        public CarFactory(string brand, string model, string fueltype)
        {
            _brand = brand;
            _model = model;
            _fueltype = fueltype;
        }
        public override IVehicle CreateVehicle()
        {
            return new Car(_brand, _model, _fueltype);
        }
    }
}
