using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Windows.f
using static System.Net.Mime.MediaTypeNames;
using System.Reflection.Emit;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        FileData system = new FileData("data.json");
        string userId = Prompt.ShowDialog("Enter User ID:", "Login");
        string password = Prompt.ShowDialog("Enter Password:", "Login");
        if (system.Login(userId, password))
        {
            Console.WriteLine("Login successful");
        }
        else (Console.WriteLine("Login Failed"));
    }

   
    
}
