using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkCSharp
{
    public class Startup
    {
        public static void Format()
        {
            // Sets the consoles format
            Console.WindowWidth = 81;
            Console.WindowHeight = 24;
            Console.CursorTop = 23;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.Title = "ZORK I: The Great Empire - Coded in C#";
        }
        public static void TopBar()
        {
            // Set the score bar at the top
            Console.CursorTop = 0;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" West of House                                        Score: 0      Moves: 0     ");
            Console.CursorTop = 23;
            Console.ResetColor();
        }
    }
}
