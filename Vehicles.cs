using System;
using System.Collections.Generic;
public class Vehicle
{
    public string Brand;
    public string Model;
    public int Year;

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void StartEngine()
    {
        Console.WriteLine($"{Brand} {Model} - двигатель запущен");
    }

    public void StopEngine()
    {
        Console.WriteLine($"{Brand} {Model} - двигатель остановлен");
    }
}

public class Car : Vehicle
{
    public int Doors;
    public string TransType;

    public Car(string brand, string model, int year, int doors, string transType)
        : base(brand, model, year)
    {
        Doors = doors;
        TransType = transType;
    }

    public void CarPrint()
    {
        Console.WriteLine($"Автомобиль: {Brand} {Model}, дверей: {Doors}, коробка: {TransType}");
    }
}

public class Motorcycle : Vehicle
{
    public string BodyType;
    public bool Box;

    public Motorcycle(string brand, string model, int year, string bodyType, bool box)
        : base(brand, model, year)
    {
        BodyType = bodyType;
        Box = box;
    }

    public void BikePrint()
    {
        string boxInfo;
        if (Box)
            boxInfo = "есть";
        else
            boxInfo = "нет";
        Console.WriteLine($"Мотоцикл: {Brand} {Model}, Кузов: {BodyType}, Бокс: {boxInfo}");
    }
}

//garage
public class Garage
{
    public string Name;
    public List<Vehicle> Vehicles = new List<Vehicle>();

    public Garage(string name)
    {
        Name = name;
    }

    public void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
        Console.WriteLine($"Добавили {vehicle.Brand} {vehicle.Model} в гараж '{Name}'");
    }

    public void RemoveVehicle(Vehicle vehicle)
    {
        if (Vehicles.Remove(vehicle))
        {
            Console.WriteLine($"Удалили {vehicle.Brand} {vehicle.Model} из гаража '{Name}'");
        }
    }
    public void GaragePrint()
    {
        Console.WriteLine($"\n--- Гараж '{Name}' ---");
        foreach (var vehicle in Vehicles)
        {
            if (vehicle is Car car)
            {
                car.CarPrint();
            }
            else if (vehicle is Motorcycle bike)
            {
                bike.BikePrint();
            }
            else
            {
                Console.WriteLine($"Транспорт: {vehicle.Brand} {vehicle.Model}, Год: {vehicle.Year}");
            }
        }
    }
}
public class Fleet
{
    public string Autopark;
    public List<Garage> Garages = new List<Garage>();

    public Fleet(string autopark)
    {
        Autopark = autopark;
    }
    public void AddGarage(Garage garage)
    {
        Garages.Add(garage);
        Console.WriteLine($"Добавили гараж '{garage.Name}' в автопарк");
    }

    public void RemoveGarage(Garage garage)
    {
        if (Garages.Remove(garage))
        {
            Console.WriteLine($"Удалили гараж '{garage.Name}' из автопарка");
        }
    }

    public void FleetPrint()
    {
        Console.WriteLine($"\n=== Весь автопарк ===");
        foreach (var garage in Garages)
        {
            garage.GaragePrint();
        }
    }
}

//test
class lolo
{
    static void Main()
    {
        Car car1 = new Car("Toyota", "Avalon", 2012, 4, "Автомат");
        Car car2 = new Car("Lada", "Vesta", 2022, 4, "Механика");
        Motorcycle bike1 = new Motorcycle("Yamaha", "MT-07", 2021, "Спорт", true);
        Motorcycle bike2 = new Motorcycle("Honda", "CBR", 2023, "Спорт", false);

        //test metodov
        car1.StartEngine();
        bike1.StartEngine();
        Console.WriteLine();


        Garage g1 = new Garage("Главный гараж");
        Garage g2 = new Garage("Запасной гараж");


        g1.AddVehicle(car1);
        g1.AddVehicle(bike1);
        g2.AddVehicle(car2);
        g2.AddVehicle(bike2);


        g1.GaragePrint();
        g2.GaragePrint();


        Fleet fleet = new Fleet("");


        fleet.AddGarage(g1);
        fleet.AddGarage(g2);


        fleet.FleetPrint();

        //test udaleniya
        Console.WriteLine("\n--- Тест удаления ---");
        g1.RemoveVehicle(bike1);
        fleet.RemoveGarage(g2);


        fleet.FleetPrint();
    }
}