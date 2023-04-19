using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class DisplayRequested
    {
        public static void DisplayWelcomeInstructions()
        {
            Console.WriteLine("Welcome to World Of Villainy!\n");
            Console.WriteLine("Type North or South to move, or Weapons, Items, Treasures, Potions,\nor Mobs to display information about your surroundings, or type Fight to fight a mob!\n");
            Console.WriteLine("You can also type Exit to quit the game at any time.\n");

            // Display Starting Room            
            LoadGame.LoadRooms();
            LoadGame.LoadRoomDescriptions();
            DisplayRooms(0);
            Console.WriteLine("");
        }

        public static void DisplayRooms(int index)
        {
            Console.WriteLine("Current Room: "+World.rooms[index]);
            Console.WriteLine("Room Description: " + World.roomDescs[index]);
        }

        public static void DisplayWeapons()
        {
            for (int i = 0; i < World.weapons.Length; i++)
            {
                Console.WriteLine(World.weapons[i]);
                Console.WriteLine("Weapon Description: "+World.weaponDescs[i]+"\n");
            }
        }

        public static void DisplayPotions()
        {
            foreach (string potion in World.potions)
            {
                Console.WriteLine(potion);
            }
        }

        public static void DisplayTreasure()
        {
            foreach (string treasure in World.treasures)
            {
                Console.WriteLine(treasure);
            }
        }

        public static void DisplayItems()
        {
            foreach (string item in World.items)
            {
                Console.WriteLine(item);
            }
        }

        public static void DisplayMobs()
        {
            for (int i = 0; i < World.mobs.Count; i++)
            {
                Console.WriteLine(World.mobs[i]);
                Console.WriteLine("Mob Description: "+World.mobDescs[i]+"\n");
            }
        }

        public static void DisplayCommandArrow()
        {
            Console.Write("=> ");
        }

        public static void DisplayInputError()
        {
            Console.WriteLine("Invalid input. Please Try Again");
        }

        public static void DisplayMovementError()
        {
            Console.WriteLine("You cannot move that way. Try another direction.");
        }

    }
}