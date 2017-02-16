using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkCSharp
{
    class Checks
    {
        public static void Look()
        {

        }

        public static void LocationCheck()
        {
            // West of House
            if (Variables.PlayerX == 0 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround & Variables.Move == "s" & !Variables.Moved[1]) { Variables.PlayerX = 1; Variables.PlayerY = -1; Variables.PlayerZ = 0; Variables.Moved[1] = true; Console.WriteLine("South of House"); }
            if (Variables.PlayerX == 0 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround & Variables.Move == "n" & !Variables.Moved[1]) { Variables.PlayerX = 1; Variables.PlayerY = 1; Variables.PlayerZ = 0; Variables.Moved[1] = true; Console.WriteLine("North of House"); }
            if (Variables.PlayerX == 0 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround & Variables.Move == "w" & !Variables.Moved[1]) { Variables.PlayerX = -1; Variables.PlayerY = 2; Variables.PlayerZ = 0; Variables.Moved[1] = true; Console.WriteLine("Forest"); }
            // South of House
            if (Variables.PlayerX == 1 & Variables.PlayerY == -1 & Variables.PlayerZ == 0 & Variables.AboveGround & Variables.Move == "w" & !Variables.Moved[1]) { Variables.PlayerX = 0; Variables.PlayerY = 0; Variables.PlayerZ = 0; Variables.Moved[1] = true; Console.WriteLine("West of House"); }
            if (Variables.PlayerX == 1 & Variables.PlayerY == -1 & Variables.PlayerZ == 0 & Variables.AboveGround & Variables.Move == "e" & !Variables.Moved[1]) { Variables.PlayerX = 3; Variables.PlayerY = 0; Variables.PlayerZ = 0; Variables.Moved[1] = true; Console.WriteLine("Behind House"); }
            if (Variables.PlayerX == 1 & Variables.PlayerY == -1 & Variables.PlayerZ == 0 & Variables.AboveGround & Variables.Move == "s" & !Variables.Moved[1]) { Variables.PlayerX = 4; Variables.PlayerY = -2; Variables.PlayerZ = 0; Variables.Moved[1] = true; Console.WriteLine("Forest"); }

            // If didn't move
            if (!Variables.Moved[1]) { Console.WriteLine("You cannot go that way"); }
        }

        public static void Text()
        {
            // West of House
            if (Variables.PlayerX == 1 & Variables.PlayerY == -1 & Variables.PlayerZ == 0 & Variables.AboveGround & !Variables.Locations[0]) { Console.WriteLine("You are facing the south side of a white house. There is no door here, and all"); Console.WriteLine("the windows are boarded."); Variables.Locations[0] = true; }
            if (Variables.PlayerX == 1 & Variables.PlayerY == 1 & Variables.PlayerZ == 0 & Variables.AboveGround & !Variables.Locations[1]) { Console.WriteLine("You are facing the north side of the white house. There is no door here, and all"); Console.WriteLine("the windows are boarded up. To the north a narrow path winds through the trees."); Variables.Locations[1] = true; }
            if (Variables.PlayerX == -1 & Variables.PlayerY == 2 & Variables.PlayerZ == 0 & Variables.AboveGround & !Variables.Locations[2]) { Console.WriteLine("This is a forest, with trees in all directions. To the east, there appears to"); Console.WriteLine("be sunlight."); Variables.Locations[2] = true; }
            // South of House
            if (Variables.PlayerX == 0 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround & !Variables.Locations[3]) { Console.WriteLine("There is a small mailbox here"); Variables.Locations[3] = true; }
            if (Variables.PlayerX == 3 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround & !Variables.Locations[4]) { Console.WriteLine("You are behind the white house. A path leads into the forest to the east. In"); Console.WriteLine("one corner of the house there is a small window which is slightly ajar."); Variables.Locations[4] = true; }
            if (Variables.PlayerX == 4 & Variables.PlayerY == -2 & Variables.PlayerZ == 0 & Variables.AboveGround & !Variables.Locations[5] & !Variables.Moved[1]) { Console.WriteLine("This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight."); Variables.Locations[5] = true; }
        }
    }
}
