using System;
using System.Security.Cryptography.X509Certificates;


//1 - SRP


public class Order
{
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}
class CalculatePrice{
    public double CalculateTotalPrice(Order order)
    {
        return order.Quantity * order.Price * 0.9;
    }
}
class PaymentService {
    public void ProcessPayment(string paymentDetails)
    {
        Console.WriteLine("Payment processed using: " + paymentDetails);
    } 
}
class EmailService
{   
    public void SendConfirmationEmail(string email)
    {
        Console.WriteLine("Confirmation email sent to: " + email);
    }
}



//2 - OCP


public class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }

}
interface ISalaryCalculator
{
    double CalculateSalary(Employee employee);
}
public class Permanent : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.BaseSalary * 1.2;
    }
}
public class Contract : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.BaseSalary * 1.1;
    }
}
public class Intern : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.BaseSalary * 0.8;
    }
}
public class SalaryManagement
{
    private readonly ISalaryCalculator Calculator;
    public SalaryManagement(ISalaryCalculator calculator)
    {
        Calculator = calculator;
    }
    public double GetSalary(Employee employee)
    {
        return Calculator.CalculateSalary(employee);
    }
}




//3 - ISP



public interface IPrinter
{
    void Print(string content);
}
public interface IScanner
{
    void Scan(string content);
}
public interface IFax
{
    void Fax(string content);
}
public class AllInOnePrinter : IPrinter, IScanner, IFax
{
    public void Print(string content)
    {
        Console.WriteLine("Printing: " + content);
    }
    public void Scan(string content)
    {
        Console.WriteLine("Scanning: " + content);
    }
    public void Fax(string content)
    {
        Console.WriteLine("Faxing: " + content);
    }
}
public class BasicPrinter : IPrinter
{ 
    public void Print(string content)
    {
        Console.WriteLine("Printing: " + content);
    }
}
public class Photocopier : IPrinter, IScanner
{
    public void Print(string content)
    {
        Console.WriteLine("Printing:" + content);
    }
    public void Scan(string content)
    {
        Console.WriteLine("Scanning:" + content);
    }
}
public class FaxMachine : IFax
{
    public void Fax(string content)
    {
        Console.WriteLine("Faxing: " + content);
    }
}


//4 - DIP



public interface ISender
{
    void Send(string message);
}
public class EmailSender : ISender
{
    public void Send(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}
public class SmsSender : ISender
{
    public void Send(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }
}


public class NotificationService
{
    private readonly ISender Sender;
    public NotificationService(ISender sender)
    {
        Sender = sender;
    }
    public void SendNotification(string message)
    {
        Sender.Send(message);
    }
}