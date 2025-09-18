using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Threading;
//DRY
//1
public class OrderService
{
    public void PrintOrder(string type, string productName, int quantity, double price)
    {
        double totalPrice = quantity * price;
        Console.WriteLine($"Order for {productName} {type}. Total: {totalPrice}");
    }
}// -type(created, updated)



//2
public class Vehicle
{
    string Type;
    public Vehicle(string type)
    {
        Type = type;
    }
    public void Start()
    {
        Console.WriteLine($"{Type} is starting");
    }
    public void Stop()
    {
        Console.WriteLine($"{Type} is stopping");
    }
}

public class Car : Vehicle
{
    public Car() : base("Car")
    {

    }
}

public class Truck : Vehicle
{
    public Truck() : base("Truck")
    {

    }
}

//KISS

//3
public class AdditionOperation
{
    private int _a;
    private int _b;
    public AdditionOperation(int a, int b)
    {
        _a = a;
        _b = b;
    }
    public void Execute()
    {
        Console.WriteLine(_a + _b);
    }
}


//4
public class Singleton
{

    public void DoSomething()
    {
        Console.WriteLine("Doing something...");
    }
}
public class Client
{
    public void Execute()
    {
        Singleton service = new Singleton();
        service.DoSomething();
    }
}

//5


public class Circle
{
    private double _radius;
    public Circle(double radius)
    {
        _radius = radius;
    }
    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}


public class Square
{
    private double _side;
    public Square(double side)
    {
        _side = side;
    }
    public double Calculate()
    {
        return _side * _side;
    }
}

//6


public class MathOperations
{
    public int Add(int a, int b)
    {
        return a+b;
    }
}