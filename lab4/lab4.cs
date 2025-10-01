using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab4.Transports;
using lab4.TransportFactories;
namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Transport Type: 1 - Car, 2 - Bike, 3 - Motocycle, 4 - Plane ");
            int input = Convert.ToInt32(Console.ReadLine());
            TransportFactory factory = null;
            Transport transport = null;
            if(input == 1)
            {
                factory = new CarFactory();
            }
            else if(input == 2)
            {   
                factory = new BikeFactory();
            }
            else if(input == 3)
            {
                factory = new MotocycleFactory();
            }
            else if(input == 4)
            {
                factory = new PlaneFactory();
            }
            transport = factory.CreateTransport();
            transport.Move();
            transport.FuelUp();
            Console.ReadLine(); 
        }
    }
}
