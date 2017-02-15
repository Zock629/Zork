using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZorkCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Startup.Format();
            Startup.TopBar();
            Startup.StartingText();
            Startup.Format();
            Startup.TopBar();
            while (Variables.Play)
            {
                Console.Write(">");
                Variables.UserInput = Console.ReadLine();
                Commands.Movement();
                Startup.Format();
                Startup.TopBar();
            }
        }
    }
}
