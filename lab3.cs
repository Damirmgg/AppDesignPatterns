using System;
using System.Collections.Generic;
//1 - SRP
public class Invoice
{
    public int Id { get; set; }
    public List<Item> Items { get; set; }
    public double TaxRate { get; set; }
}
public class  InvoiceCalculator
{
    public double CalculateTotal(Invoice invoice)
    {
        double subTotal = 0;
        foreach (var item in invoice.Items)
        {
            subTotal += item.Price;
        }
        return subTotal + (subTotal * invoice.TaxRate);
    }
}
public class InvoiceRepository
{
    public void SaveToDatabase()
    {
        // Логика для сохранения счета-фактуры в базу данных
    }
}

//2 - OCP
public enum CustomerType
{
    Regular,
    Silver,
    Gold
}
public interface  IDiscount
{
    double CalculateDiscount(double amount);
}
public class RegularDiscount : IDiscount
{
    public double CalculateDiscount(double amount)
    {
        return amount; 
    }
}
public class SilverDiscount : IDiscount
{
    public double CalculateDiscount(double amount)
    {
        return amount * 0.9;
    }
}
public class  GoldDiscount : IDiscount
{
  public double CalculateDiscount(double amount)
    {
        return amount * 0.8;
    }
}
public class DiscountCalculator
{
    private readonly IDiscount Discount;
    public DiscountCalculator(IDiscount discount)
    {
        Discount = discount;
    }
    public double ApplyDiscount(double amount)
    {
        return Discount.CalculateDiscount(amount);
    }
}

//3 - ISP


public interface IWorker
{
    void Work();
}
public interface IHumanWorker
{
    void Eat();
    void Sleep();
}
public class HumanWorker : IWorker, IHumanWorker
{
    public void Work()
    {
        // Логика работы
    }
    public void Eat()
    {
        // Логика питания
    }
    public void Sleep()
    {
        // Логика сна
    }
}
public class RobotWorker : IWorker
{
    public void Work()
    {
        // Логика работы
    }
}


//4 - DIP


public interface INotification
{
    void Send(string message);
}
public class EmailService : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Отправка Email: {message}");
    }
}
public class Notification
{
    private readonly INotification _Notification;
    public Notification(INotification notification)
    {
        _Notification = notification;
    }
    void Send(string message)
    {
        _Notification.Send(message);
    }
}