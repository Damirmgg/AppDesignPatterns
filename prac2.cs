using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class Program
    {
    static void Main(string[] args)
    {
        UserManager users = new UserManager();
        User user1 = new User("Splinter", "Siomantro@gmail.com", "Admin");
        User user2 = new User("Leonardo", "Pyppto@gmail.com", "User");
        User user3 = new User("Donatello", "qwerty@gmail.com", "User");
        User user4 = new User("Raphaelo", "Pipupo@gmail.com", "User");
        User user5 = new User("Michelangelo", "Dioptrio@gmail.com", "User");

        users.AddUser(user1);
        users.AddUser(user2);
        users.AddUser(user3);
        users.AddUser(user4);
        users.AddUser(user5);
        
        foreach (var user in users.users)
        {
            Console.WriteLine($"User {user.Name} with email: {user.Email} has role:{user.Type} ");
        }

        users.UpdateUser(user2, user2.Name, user2.Email, user2.Type = "Admin");
        users.RemoveUser(user1);

        Console.WriteLine("\n -- Update --\n");

        foreach (var user in users.users)
        {
            Console.WriteLine($"User {user.Name} with email: {user.Email} has role:{user.Type} ");
        }
    }
}

class User
{
    public string Name;
    public string Email;
    public string Type;
    public User(string name, string email,string type){
        Name = name;
        Email = email;
        Type = type;
    }
}
class UserManager
{
    public List<User> users = new List<User>();
    public void AddUser(User user)
    {
        users.Add(user);
    }
    public void RemoveUser(User user)
    {
        users.Remove(user);
    }
    public void UpdateUser(User user, string name, string email, string type)
    {
        user.Name = name;
        user.Email = email;
        user.Type = type;
    }
}