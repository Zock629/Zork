using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkCSharp
{
    public class Location
    {
        public static void AboveGround()
        {
            // Around House
            if (Variables.PlayerX == 0 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround){ Variables.LocationName = "West of House"; }
            if (Variables.PlayerX == 1 & Variables.PlayerY == -1 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "South of House"; }
            if (Variables.PlayerX == 3 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Behind House"; }
            if (Variables.PlayerX == 1 & Variables.PlayerY == 1 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "North of House"; }
            // Inside House
            if (Variables.PlayerX == 1 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Living Room"; }
            if (Variables.PlayerX == 2 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Kitchen"; }
            if (Variables.PlayerX == 2 & Variables.PlayerY == 0 & Variables.PlayerZ == 1 & Variables.AboveGround) { Variables.LocationName = "Attic"; }
            // Forests, Paths and Clearings
            if (Variables.PlayerX == 4 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Clearing"; }
            if (Variables.PlayerX == 4 & Variables.PlayerY == -1 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Forest"; }
            if (Variables.PlayerX == -1 & Variables.PlayerY == 2 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Forest"; }
            if (Variables.PlayerX == 1 & Variables.PlayerY == 2 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Forest Path"; }
            if (Variables.PlayerX == 1 & Variables.PlayerY == 2 & Variables.PlayerZ == 1 & Variables.AboveGround) { Variables.LocationName = "Up a Tree"; }
            if (Variables.PlayerX == 4 & Variables.PlayerY == 2 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Forest"; }
            if (Variables.PlayerX == 5 & Variables.PlayerY == 2 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Forest"; }
            if (Variables.PlayerX == 1 & Variables.PlayerY == 3 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Clearing"; }
            // Canyon
            if (Variables.PlayerX == 5 & Variables.PlayerY == 0 & Variables.PlayerZ == 0 & Variables.AboveGround) { Variables.LocationName = "Canyon View"; }
            if (Variables.PlayerX == 5 & Variables.PlayerY == 0 & Variables.PlayerZ == -1 & Variables.AboveGround) { Variables.LocationName = "Rocky Ledge"; }
            if (Variables.PlayerX == 5 & Variables.PlayerY == 0 & Variables.PlayerZ == -2 & Variables.AboveGround) { Variables.LocationName = "Canyon Bottom"; }
            if (Variables.PlayerX == 5 & Variables.PlayerY == 1 & Variables.PlayerZ == -2 & Variables.AboveGround) { Variables.LocationName = "End of Rainbow"; }
        }
    }
}
