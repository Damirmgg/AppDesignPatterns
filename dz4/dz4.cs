using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dz4.VehicleFactories;
using dz4.Vehicles;
namespace dz4
{
    internal class Program
    {
static void Main(string[] args)
        {
            VehicleFactory factory = null;
            Console.WriteLine(">>> Which type vehicle u wanna create?");
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "car":
                    Console.WriteLine("Brand:");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Model:");
                    string model = Console.ReadLine();
                    Console.WriteLine("Fuel Type:");
                    string fuelType = Console.ReadLine();
                    factory = new CarFactory(brand, model, fuelType);
                    break;
                case "motorcycle":
                    Console.WriteLine("Motorcycle type: ");
                    string mototype = Console.ReadLine();
                    Console.WriteLine("Motorcycle engine capacity:");
                    string capacity = Console.ReadLine();
                    factory = new MotorcycleFactory(mototype, capacity);
                    break;
                case "truck":
                    Console.WriteLine("How much weigth truck can take:");
                    string weigth = Console.ReadLine();
                    Console.WriteLine("Os' count:");
                    string countosey = Console.ReadLine();
                    factory = new TruckFactory(weigth, countosey);
                    break;
                case "bus":
                    Console.WriteLine("How many seats in the bus:");
                    string seatcount = Console.ReadLine();
                    break;
            }
            IVehicle vehicle = factory.CreateVehicle();
            vehicle.Drive();
            vehicle.Refuel();
        }
    }
}
