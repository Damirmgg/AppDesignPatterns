using System;
using System.Collections.Generic;
public class Employee
{
    public string Name;
    public int ID;
    public string Role;

    public Employee(string name, int id, string role)
    {
        Name = name;
        ID = id;
        Role = role;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Сотрудник: {Name}, ID: {ID}, Должность: {Role}");
    }
}

public class Worker : Employee
{
    public double SalaryHour;
    public int Hours;

    public Worker(string name, int id, double salaryHour, int hours)
        : base(name, id, "Рабочий")
    {
        SalaryHour = salaryHour;
        Hours = hours;
    }

    public double CalculSalary()
    {
        return SalaryHour * Hours;
    }

    public void PrintWorker()
    {
        PrintInfo();
        Console.WriteLine($"Ставка: {SalaryHour} тг/час, Часы: {Hours}");
        Console.WriteLine($"Зарплата: {CalculSalary()} тг");
    }
}

public class Manager : Employee
{
    public double FixedSalary;
    public double Bonus;

    public Manager(string name, int id, double fixedSalary, double bonus)
        : base(name, id, "Менеджер")
    {
        FixedSalary = fixedSalary;
        Bonus = bonus;
    }

    public double CalculSalary()
    {
        return FixedSalary + Bonus;
    }

    public void PrintManager()
    {
        PrintInfo();
        Console.WriteLine($"Оклад: {FixedSalary} тг, Премия: {Bonus} тг");
        Console.WriteLine($"Зарплата: {CalculSalary()} тг");
    }
}

public class AccountingSystem
{
    public List<Employee> Employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
        Console.WriteLine($"Добавлен: {employee.Name}");
    }

    public void PrintAllEmployees()
    {
        Console.WriteLine("\n=== Все сотрудники ===");
        foreach (var employee in Employees)
        {
            if (employee is Worker worker)
            {
                worker.PrintWorker();
            }
            else if (employee is Manager manager)
            {
                manager.PrintManager();
            }
            Console.WriteLine("---");
        }
    }
    public void PrintTotalSalary()
    {
        double total = 0;
        foreach (var employee in Employees)
        {
            if (employee is Worker worker)
            {
                total += worker.CalculSalary();
            }
            else if (employee is Manager manager)
            {
                total += manager.CalculSalary();
            }
        }
        Console.WriteLine($"\nОбщая сумма зарплат: {total} тг");
    }
}
class olololo
{
    static void Main()
    {
        Console.WriteLine("=== Система учета сотрудников ===\n");

        AccountingSystem system = new AccountingSystem();

        
        Worker worker1 = new Worker("Нурмугамед Айцев", 1, 2000, 160);
        Worker worker2 = new Worker("Мария Милашенко", 2, 2500, 140);
        Manager manager1 = new Manager("Алексей Денисов", 3, 400000, 200000);
        Manager manager2 = new Manager("Ардак Есмугамедов", 4, 500000, 150000);

        system.AddEmployee(worker1);
        system.AddEmployee(worker2);
        system.AddEmployee(manager1);
        system.AddEmployee(manager2);
        
        Console.WriteLine("\n--- Расчет зарплат ---");
        Console.WriteLine($"{worker1.Name}: {worker1.CalculSalary()} тг");
        Console.WriteLine($"{manager1.Name}: {manager1.CalculSalary()} тг");

        system.PrintAllEmployees();

        system.PrintTotalSalary();


    }
}
