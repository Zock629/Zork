using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkCSharp
{
    class TopBar
    {
        public static void Top()
        {
            Console.CursorTop = 0;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;

            Variables.TBLen = 52;
            Variables.TBLen -= Variables.LocationName.Length;

            Variables.Sp = "{0," + Variables.TBLen + "} {1, 27}";
            Variables.Spaces = string.Format(Variables.Sp, " ", "Score: 0      Moves: 0     ");
            Console.WriteLine(" " + Variables.LocationName + Variables.Spaces);

            Console.CursorTop = 23;
            Console.ResetColor();
        }
    }
}
