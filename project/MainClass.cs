using System;
using Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Presentation;

internal class MainClass
{
    LogIn login = new LogIn();
    SystemClass systemClass = new SystemClass();
    UserHandler userHandler = new UserHandler();
    static bool programRunning = true;
    static void Main(string[] args)
    {
        //login.SelectUser(UserHandler.);
        while (programRunning)
        {
            Console.Write("> ");
            string? Cmd = Console.ReadLine();
            Console.WriteLine(Cmd);
        }
    }
}
