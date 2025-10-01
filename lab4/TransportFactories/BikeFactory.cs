using lab4.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab4.TransportFactories
{

    internal class BikeFactory : TransportFactory
    {
        public override Transport CreateTransport()
        {
            return new Bike();
        }
    }

}