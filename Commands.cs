using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkCSharp
{
    class Commands
    {
        public static void Movement()
        {
            // Movement Conversion
            if (Variables.UserInput.ToLower() == "south"){ Variables.UserInput = "s"; }
            if (Variables.UserInput.ToLower() == "north") { Variables.UserInput = "n"; }
            if (Variables.UserInput.ToLower() == "west") { Variables.UserInput = "w"; }
            if (Variables.UserInput.ToLower() == "east") { Variables.UserInput = "e"; }
            if (Variables.UserInput.ToLower() == "up") { Variables.UserInput = "u"; }
            if (Variables.UserInput.ToLower() == "down") { Variables.UserInput = "d"; }
            // Movement Commands
            if (Variables.UserInput.ToLower() == "s" & !Variables.Moved[0]) { Variables.Move = "s"; Variables.Moved[0] = true; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "n" & !Variables.Moved[0]) { Variables.Move = "n"; Variables.Moved[0] = true; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "w" & !Variables.Moved[0]) { Variables.Move = "w"; Variables.Moved[0] = true; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "e" & !Variables.Moved[0]) { Variables.Move = "e"; Variables.Moved[0] = true; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "u" & !Variables.Moved[0]) { Variables.Move = "u"; Variables.Moved[0] = true; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "d" & !Variables.Moved[0]) { Variables.Move = "d"; Variables.Moved[0] = true; Checks.LocationCheck(); }

            // Movement Reset
            Variables.Moved[0] = false;
            Variables.Moved[1] = false;
        }
    }
}
