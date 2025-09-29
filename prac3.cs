using System;
using System.Collections.Generic;
using System.Threading;

public class Order
{
    public List<(string Name, int Count, double Price)> Items = new List<(string, int, double)>();
    public IPayment Payment;
    public IDelivery Delivery;
    public INotification Notification;
    public List<IDiscount> Discounts = new List<IDiscount>();
    
    public void AddItem(string Name, int Count, double Price)
    {
        Items.Add((Name, Count, Price));
    }
}
public class TotalPrice
{
    public double CalculateTotal(Order order)
    {
        double total = 0;
        foreach (var item in order.Items)
        {
            total += item.Count * item.Price;
        }
        foreach (var discount in order.Discounts)
        {
            discount.CalculateDiscount(total);
        }
        return total;
    }
}
public interface IPayment
{
    void ProcessPayment(double amount);
}
public class CreditCardPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}
public class PayPalPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}
public class BankTransferPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing bank transfer payment of {amount}");
    }
}

public interface IDelivery
{
    void DeliverOrder(Order order);
}
public class CourierDelivery : IDelivery
{  
    public void DeliverOrder(Order order)
    {
        Console.WriteLine("Delivery will be made with Courier");
    }
}
public class PostDelivery : IDelivery 
{
    public void DeliverOrder(Order order)
    {
        Console.WriteLine("Delivery will be made with Post");
    }
}
public class PickupPointDelivery : IDelivery
{
    public void DeliverOrder(Order order)
    {
        Console.WriteLine("Order will be picked up in storage");
    }
}
public interface INotification
{
    void SendNotification(string message);
}
public class EmailNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}
public class SMSNotification : INotification
{
    public void SendNotification(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}
public interface IDiscount
{
    double CalculateDiscount(double totalAmount);
}
public class SeasonalDiscount : IDiscount
{
    public double CalculateDiscount(double totalAmount)
    {
        return totalAmount * 0.9; 
    }
}
public class  NoDiscount : IDiscount
{
    public double CalculateDiscount(double totalAmount)
    {
        return totalAmount;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        TotalPrice totalPrice = new TotalPrice();
        order.AddItem("Phone", 1, 500);
        order.AddItem("Headphones", 10, 70);

        order.Payment = new CreditCardPayment();
        order.Delivery = new PickupPointDelivery();
        order.Notification = new EmailNotification();
        order.Discounts.Add(new SeasonalDiscount());
        double total = totalPrice.CalculateTotal(order);
        Console.WriteLine($"Overall, total: {total}");

        order.Payment.ProcessPayment(total);
        order.Delivery.DeliverOrder(order);
        order.Notification.SendNotification("Order processed greatly");
    }
}