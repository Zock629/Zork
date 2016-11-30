using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Port of the first Zork game to C#
// Author - Zock629
// Date Made - 29/11/2016
// Last Edited - 30/11/2016 - 10:43PM



// ----- TODO LIST -----
// Add all the other above ground locations.
// Add the inside of the houes.
// Add user interaction.
// Add variables for all locations to make if statments to disable description on travel
// after the place has already been visited.
// Start work on the underground.
// Start work on the maze.
// Add inventory
// Add the container in the house
// Add weight limit to inventory
// Add score calculation
// Add enemies
// Add thief
// Test the game

namespace Zork
{
    class Program
    {
        static int Moves = 0;
        static string LocationName = ("");
        static void Main(string[] args)
        {
            bool Play = true;
            int Location = 0;
            int ReturnValue = 0;
            int CaseSwitch = 0;
            var UserInput = ("");
            bool SouthHouse = false;
            Random r = new Random();

            // Sets the consoles format
            Console.WindowWidth = 81;
            Console.WindowHeight = 24;
            Console.CursorTop = 23;
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.Title = "ZORK I: The Great Empire - Coded in C#";

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
            // Location 1 = West of House
            LocationName = " West of House ";
            Location = 1;

            // Set the score bar at the top
            Console.CursorTop = 0;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" West of House                                        Score: 0      Moves: 0     ");
            Console.CursorTop = 23;
            Console.ResetColor();

            while (Play)
            {
                // Awaiting user input
                Console.Write(">");
                Console.WindowWidth = 81;
                Console.WindowHeight = 24;
                Console.BufferWidth = Console.WindowWidth;
                Console.BufferHeight = Console.WindowHeight;
                UserInput = Console.ReadLine();
                Top();
                if (UserInput.ToLower() == "e" || UserInput.ToLower() == "east" ||  UserInput.ToLower() == "n" || UserInput.ToLower() == "north" ||  UserInput.ToLower() == "w" || UserInput.ToLower() == "west" || UserInput.ToLower() == "s" || UserInput.ToLower() == "south" || UserInput.ToLower() == "look" || UserInput.ToLower() == "hello" || UserInput == "")
                {

                    // OUTSIDE ----- OUTSIDE ----- OUTSIDE ----- OUTSIDE ----- OUTSIDE \\

                    if (UserInput == "")
                    {
                        Console.WriteLine("I beg your pardon.");
                        Console.WriteLine("");
                        Top();
                    }

                    if (UserInput.ToLower() == "look" && Location == 1)
                    {
                        Console.WriteLine("West of House");
                        Console.WriteLine("You are standing in an open field west of a white house, with a boarded front");
                        Console.WriteLine("door.");
                        Console.WriteLine("There is a small mailbox here.");
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }

                    if (UserInput.ToLower() == "look" && Location == 2)
                    {
                        Console.WriteLine("South of House");
                        Console.WriteLine("You are facing the south side of a white house. There is no door here, and all");
                        Console.WriteLine("the windows are boarded.");
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }

                    if (UserInput.ToLower() == "look" && Location == 5)
                    {
                        Console.WriteLine("Forest");
                        Console.WriteLine("This is a forest, with trees in all directions. To the east, there appears to");
                        Console.WriteLine("be sunlight.");
                        Console.WriteLine("You hear in the distance the chirping of a song bird");
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }

                    // South of House
                    if (UserInput.ToLower() == "s" && Location == 4 || UserInput.ToLower() == "south" && Location == 4 || UserInput.ToLower() == "s" && Location == 1 || UserInput.ToLower() == "south" && Location == 1)
                    {
                        Location = 2;
                        LocationName = " South of House";
                        Console.WriteLine("South of House");
                        if (!SouthHouse)
                        {
                            Console.WriteLine("You are facing the south side of a white house. There is no door here, and all");
                            Console.WriteLine("the windows are boarded.");
                            SouthHouse = true;
                        }
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }

                    // West of House
                    if (UserInput.ToLower() == "w" && Location == 2 || UserInput.ToLower() == "west" && Location == 2 || UserInput.ToLower() == "w" && Location == 3 || UserInput.ToLower() == "west" && Location == 3)
                    {
                        Location = 1;
                        LocationName = " West of House ";
                        Console.WriteLine("West of House");
                        Console.WriteLine("There is a small mailbox here");
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }

                    // Forest 1
                    if (UserInput.ToLower() == "w" && Location == 1 || UserInput.ToLower() == "west" && Location == 1 || UserInput.ToLower() == "w" && Location == 6 || UserInput.ToLower() == "west" && Location == 6)
                    {
                        Location = 5;
                        LocationName = " Forest        ";
                        Console.WriteLine("Forest");
                        Console.WriteLine("This is a forest, with trees in all directions. To the east, there appears to");
                        Console.WriteLine("be sunlight.");
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }

                    // North of House
                    if (UserInput.ToLower() == "n" && Location == 4 || UserInput.ToLower() == "north" && Location == 4 || UserInput.ToLower() == "n" && Location == 1 || UserInput.ToLower() == "north" && Location == 1 || UserInput.ToLower() == "s" && Location == 6 || UserInput.ToLower() == "south" && Location == 6)
                    {
                        Location = 3;
                        LocationName = " North of House";
                        Console.WriteLine("North of House");
                        Console.WriteLine("You are facing the north side of the white house. There is no door here, and all");
                        Console.WriteLine("the windows are boarded up. To the north a narrow path winds through the trees.");
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }

                    // Behind House
                    if (UserInput.ToLower() == "e" && Location == 3 || UserInput.ToLower() == "east" && Location == 3)
                    {
                        Location = 4;
                        LocationName = " Behind House  ";
                        Console.WriteLine("Behind House");
                        Console.WriteLine("You are behind the white house. A path leads into the forest to the east. In");
                        Console.WriteLine("one corner of the house there is a small window which is slightly ajar.");
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }

                    //Forest Path
                    if (UserInput.ToLower() == "n" && Location == 3 || UserInput.ToLower() == "north" && Location == 3 || UserInput.ToLower() == "e" && Location == 5 || UserInput.ToLower() == "east" && Location == 5)
                    {
                        Location = 6;
                        LocationName = " Forest Path   ";
                        Console.WriteLine("Forest Path");
                        Console.WriteLine("This is a path winding through a dimly lit forest. The path heads north-south");
                        Console.WriteLine("here. One particularly large tree with some low branches stands at the edge of");
                        Console.WriteLine("the path.");
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }

                    if (UserInput.ToLower() == "hello")
                    {
                        ReturnValue = r.Next(1, 5);
                        CaseSwitch = ReturnValue;
                        switch (CaseSwitch)
                        {
                            case 1:
                                Console.WriteLine("Hello.");
                                break;
                            case 2:
                                Console.WriteLine("Good Day.");
                                break;
                            case 3:
                                Console.WriteLine("Nice weather we've been having lately.");
                                break;
                            case 4:
                                Console.WriteLine("Goodbye");
                                break;
                        }
                        Console.WriteLine("");
                        UserInput = "";
                        Moves = Moves + 1;
                        Top();
                    }
                }
                else
                {
                    Console.WriteLine("I don't know the word \"" + UserInput + "\".");
                    Console.WriteLine("");
                    UserInput = "";
                    Top();
                }
            }
        }

        public static void Top()
        {
            if (Moves >= 100)
            {
                // Sets the score bar at the top
                Console.CursorTop = 0;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(LocationName + "                                       Score: 0      Moves: " + Moves + "     ");
                Console.CursorTop = 23;
                Console.ResetColor();
            }
            else
            {
                if (Moves >= 10)
                {
                    // Sets the score bar at the top
                    Console.CursorTop = 0;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(LocationName + "                                       Score: 0      Moves: " + Moves + "    ");
                    Console.CursorTop = 23;
                    Console.ResetColor();
                }
                else
                {
                    // Sets the score bar at the top
                    Console.CursorTop = 0;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(LocationName + "                                       Score: 0      Moves: " + Moves + "     ");
                    Console.CursorTop = 23;
                    Console.ResetColor();
                }
            }
        }
    }
}
