using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZorkCSharp
{
    class Variables
    {
        public static int PlayerX = 0;
        public static int PlayerY = 0;
        public static int PlayerZ = 0;
        public static int TBLen = 0;
        public static bool AboveGround = true;
        public static bool[] Moved = new bool[2];
        public static bool[] Locations = new bool[20];
        public static string Sp = "";
        public static string Spaces;
        public static string Move = "";
        public static string LocationName = "";
        public static string PlayerLoction = "";
        public static bool Play = true;
        public static string UserInput = "";
    }
}
