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
            if (Variables.UserInput.ToLower() == "south"){ Variables.Move = "s"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "s") { Variables.Move = "s"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "north") { Variables.Move = "n"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "s") { Variables.Move = "n"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "west") { Variables.Move = "w"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "w") { Variables.Move = "w"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "east") { Variables.Move = "e"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "e") { Variables.Move = "e"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "up") { Variables.Move = "u"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "u") { Variables.Move = "u"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "down") { Variables.Move = "d"; Checks.LocationCheck(); }
            if (Variables.UserInput.ToLower() == "d") { Variables.Move = "d"; Checks.LocationCheck(); }
        }
    }
}
