using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    internal class MainClass
    {
        static bool programRunning = true;
        static void Main(string[] args)
        {
            while (programRunning)
            {
                Console.Write("> ");
                string? Cmd = Console.ReadLine();
                Console.WriteLine(Cmd);
            }
        }
    }
}
