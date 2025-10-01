
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4.Transports;
namespace lab4.TransportFactories
{
    internal class PlaneFactory : TransportFactory
    {
        public override Transport CreateTransport()
        {
            return new Plane();
        }
    }
}
