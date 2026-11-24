using System;

class Program
{
    static void Main()
    {
        UserManager manager = new UserManager();
        manager.AddUser("Анна");
        manager.AddUser("Иван");
        manager.ShowUsers();
    }
}
