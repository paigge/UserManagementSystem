using System;
using System.Collections.Generic;

class UserManager
{
    private List<string> _users = new List<string>();
    private int _removedCount;

    public void AddUser(string name)
    {
        _users.Add(name);
    }

    public void RemoveUser(string name)
    {
        _users.Remove(name);
        _removedCount++;
    }

    public void ShowUsers()
    {
        foreach (string user in _users)
        {
            Console.WriteLine(user);
        }
    }
}