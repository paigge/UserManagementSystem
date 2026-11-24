using System;
using System.Collections.Generic;

class UserManager
{
    private List<string> _users = new List<string>();

    public void AddUser(string name)
    {
        _users.Add(name);
    }

    public void ShowUsers()
    {
        foreach (string user in _users)
        {
            Console.WriteLine(user);
        }
    }
}