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
            bool Play = true;
            Startup.Format();
            Startup.TopBar();
            while (Play)
            {
                Console.Write(">");
                Console.ReadLine();
                Startup.TopBar();
                Startup.Format();
            }
        }
    }
}
