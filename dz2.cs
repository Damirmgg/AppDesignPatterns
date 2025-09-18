//DRY

//1
class Program
{
    static void Main(string[] args)
    {

    }
}
public void Log(string type, string message)
{
    Console.WriteLine($"{type}: {message}");
}
Log("Error", "Unluck");
Log("Info", "Hello");
Log("Warning", "Careful");


//2
public static class Data
{
    public string ConnectionString = "Server=myServer;Database=myDB;User Id=myUser;Password=myPass;";
}
public class DatabaseService { }
{
    Public void Connect()
    {
        string ConnectionString = Data.ConnectionString;
    }
}
public class LoggingService
{
    public void Log(string message)
    {
        string ConnectionString = Data.ConnectionString;
    }
}


//KISS

//3
public void ProcessNumbers(int[] numbers)
{
    if(numbers != null && numbers.Length > 0)
    {
        foreach(var number in numbers)
        {
            if(number > 0)
                Console.WriteLine(number);
        }
    }
}

//4
public void PrintPositiveNumbers(int[] numbers)
{
    if(numbers == null || numbers.Length == 0)
    {
        Array.Sort(numbers);
        foreach (var number in numbers)
        {
            if (number > 0)
                Console.WriteLine(number);
        }
    }
    
}


//5
public int Divide(int a, int b)
{
    if (b == 0)
        return 0;
    return a / b;
}



//YAGNI

//6
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}
public class UserService {
    public void SaveToDatabase()
    {
        // Код для сохранения пользователя в базу данных
    }
}

public class EmailService {
    public void SendEmail()
    {
        // Код для отправки электронного письма пользователю
    }
}
public class AddressService {
    public void PrintAddressLabel()
    {
        // Код для печати адресного ярлыка
    }
}

//7
public class FileReader
{
    public string ReadFile(string filePath)
    {
        return "file content";
    }
}


//8

public class ReportGenerator
{
    public void GeneratePdfReport()

    {
        // Генерация PDF отчета
    }
}