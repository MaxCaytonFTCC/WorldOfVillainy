using System;
using GameWorldLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public static class DisplayRequested
    {

        public static void DisplayMenu()
        {
            // Display Menu
            Console.WriteLine("------MAKE A SELECTION------");
            Console.WriteLine("1. Display Rooms");
            Console.WriteLine("2. Display Weapons");
            Console.WriteLine("3. Display Potions");
            Console.WriteLine("4. Display Treasure");
            Console.WriteLine("5. Display Items");
            Console.WriteLine("6. Display Mobs");
            Console.WriteLine("7. Fight a Mob");
            Console.WriteLine("8. Exit");

            // Collect Input
            Console.Write("\nEnter Your Selection: ");
        }

        public static void DisplayRooms()
        {
            Console.WriteLine(World.room1);
            Console.WriteLine(World.room1Desc + "\n");
            Console.WriteLine(World.room2);
            Console.WriteLine(World.room2Desc + "\n");
            Console.WriteLine(World.room3);
            Console.WriteLine(World.room3Desc + "\n");
            Console.WriteLine(World.room4);
            Console.WriteLine(World.room4Desc + "\n");
            Console.WriteLine(World.room5);
            Console.WriteLine(World.room5Desc + "\n");

        }

        public static void DisplayWeapons()
        {

            Console.WriteLine(World.weapon1);
            Console.WriteLine(World.weapon1Desc + "\n");
            Console.WriteLine(World.weapon2);
            Console.WriteLine(World.weapon2Desc + "\n");
            Console.WriteLine(World.weapon3);
            Console.WriteLine(World.weapon3Desc + "\n");
            Console.WriteLine(World.weapon4);
            Console.WriteLine(World.weapon4Desc + "\n");

        }

        public static void DisplayPotions()
        {

            Console.WriteLine(World.potion1);
            Console.WriteLine(World.potion2);

        }

        public static void DisplayTreasure()
        {

            Console.WriteLine(World.treasure1);
            Console.WriteLine(World.treasure2);
            Console.WriteLine(World.treasure3);

        }

        public static void DisplayItems()
        {
            Console.WriteLine(World.item1);
            Console.WriteLine(World.item2);
            Console.WriteLine(World.item3);
            Console.WriteLine(World.item4);
        }

        public static void DisplayMobs()
        {

            Console.WriteLine(World.mob1);
            Console.WriteLine(World.mob1Desc + "\n");
            Console.WriteLine(World.mob2);
            Console.WriteLine(World.mob2Desc + "\n");
            Console.WriteLine(World.mob3);
            Console.WriteLine(World.mob3Desc + "\n");
            Console.WriteLine(World.mob4);
            Console.WriteLine(World.mob4Desc + "\n");
            Console.WriteLine(World.mob5);
            Console.WriteLine(World.mob5Desc + "\n");

        }

    }
}
