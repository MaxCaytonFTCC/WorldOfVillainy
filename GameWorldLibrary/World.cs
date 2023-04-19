using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class World
    {

        // Rooms
        public static string[] rooms = new string[5];
        public static string[] roomDescs = new string[5];

        // Weapons
        public static string[] weapons = new string[4];
        public static string[] weaponDescs = new string[4];

        // Potions
        public static string[] potions = new string[2];

        // Treasures
        public static string[] treasures = new string[3];

        // Items
        public static List<string> items = new List<string>();

        // Mobs
        public static List<string> mobs = new List<string>();
        public static List<string> mobDescs = new List<string>();

    }
}
