using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4.Transports;
namespace lab4.TransportFactories
{
    abstract class TransportFactory
    {
        public abstract Transport CreateTransport();
    }
}
