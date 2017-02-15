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
            Console.SetWindowSize(81, 24);
            Console.CursorTop = 23;
            Console.SetBufferSize(81, 24);
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
        public static void StartingText()
        {
            // Starting game text
            Console.WriteLine("ZORK I: The Great Underground Empire");
            Console.WriteLine("Copywright (c) 1981, 1982, 1983 Infocom, Inc. All rights reserved.");
            Console.WriteLine("ZORK is a registered trademark of Infocom, Inc.");
            Console.WriteLine("Revision 88 / Serial number 840726");
            Console.WriteLine("");
            Console.WriteLine("West of House");
            Console.WriteLine("You are standing in an open field west of a white house, with a boarded front ");
            Console.WriteLine("door.");
            Console.WriteLine("There is a small mailbox here.");
            Console.WriteLine("");
        }
    }
}
