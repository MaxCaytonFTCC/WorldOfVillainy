using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class GameMenu
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
            StreamReader inputFile;

            // Rooms
            string room1, room2, room3, room4, room5;
            string room1Desc, room2Desc, room3Desc, room4Desc, room5Desc;

            inputFile = File.OpenText("rooms.txt");
            while (!inputFile.EndOfStream)
            {
                room1 = inputFile.ReadLine();
                room1Desc = inputFile.ReadLine();
                Console.WriteLine(room1);
                Console.WriteLine(room1Desc + "\n");
                room2 = inputFile.ReadLine();
                room2Desc = inputFile.ReadLine();
                Console.WriteLine(room2);
                Console.WriteLine(room2Desc + "\n");
                room3 = inputFile.ReadLine();
                room3Desc = inputFile.ReadLine();
                Console.WriteLine(room3);
                Console.WriteLine(room3Desc + "\n");
                room4 = inputFile.ReadLine();
                room4Desc = inputFile.ReadLine();
                Console.WriteLine(room4);
                Console.WriteLine(room4Desc + "\n");
                room5 = inputFile.ReadLine();
                room5Desc = inputFile.ReadLine();
                Console.WriteLine(room5);
                Console.WriteLine(room5Desc + "\n");
            }
            inputFile.Close();

        }

        public static void DisplayWeapons()
        {

            StreamReader inputFile;

            // Weapons
            string weapon1, weapon2, weapon3, weapon4;
            string weapon1Desc, weapon2Desc, weapon3Desc, weapon4Desc;

            inputFile = File.OpenText("weapons.txt");
            while (!inputFile.EndOfStream)
            {
                weapon1 = inputFile.ReadLine();
                weapon1Desc = inputFile.ReadLine();
                Console.WriteLine(weapon1);
                Console.WriteLine(weapon1Desc + "\n");
                weapon2 = inputFile.ReadLine();
                weapon2Desc = inputFile.ReadLine();
                Console.WriteLine(weapon2);
                Console.WriteLine(weapon2Desc + "\n");
                weapon3 = inputFile.ReadLine();
                weapon3Desc = inputFile.ReadLine();
                Console.WriteLine(weapon3);
                Console.WriteLine(weapon3Desc + "\n");
                weapon4 = inputFile.ReadLine();
                weapon4Desc = inputFile.ReadLine();
                Console.WriteLine(weapon4);
                Console.WriteLine(weapon4Desc + "\n");
            }
            inputFile.Close();

        }

        public static void DisplayPotions()
        {
            StreamReader inputFile;

            // Potions
            string potion1, potion2;

            inputFile = File.OpenText("potions.txt");
            while (!inputFile.EndOfStream)
            {
                potion1 = inputFile.ReadLine();
                Console.WriteLine(potion1);
                potion2 = inputFile.ReadLine();
                Console.WriteLine(potion2);
            }
            inputFile.Close();

        }

        public static void DisplayTreasure()
        {
            StreamReader inputFile;

            // Treasures
            string treasure1, treasure2, treasure3;

            inputFile = File.OpenText("treasures.txt");
            while (!inputFile.EndOfStream)
            {
                treasure1 = inputFile.ReadLine();
                Console.WriteLine(treasure1);
                treasure2 = inputFile.ReadLine();
                Console.WriteLine(treasure2);
                treasure3 = inputFile.ReadLine();
                Console.WriteLine(treasure3);
            }
            inputFile.Close();

        }

        public static void DisplayItems()
        {
            StreamReader inputFile;

            // Items
            string item1, item2, item3, item4;

            inputFile = File.OpenText("items.txt");
            while (!inputFile.EndOfStream)
            {
                item1 = inputFile.ReadLine();
                Console.WriteLine(item1);
                item2 = inputFile.ReadLine();
                Console.WriteLine(item2);
                item3 = inputFile.ReadLine();
                Console.WriteLine(item3);
                item4 = inputFile.ReadLine();
                Console.WriteLine(item4);
            }

            inputFile.Close();

        }

        public static void DisplayMobs()
        {
            StreamReader inputFile;

            // Mobs
            string mob1, mob2, mob3, mob4, mob5;
            string mob1Desc, mob2Desc, mob3Desc, mob4Desc, mob5Desc;

            inputFile = File.OpenText("mobs.txt");
            while (!inputFile.EndOfStream)
            {
                mob1 = inputFile.ReadLine();
                mob1Desc = inputFile.ReadLine();
                Console.WriteLine(mob1);
                Console.WriteLine(mob1Desc + "\n");
                mob2 = inputFile.ReadLine();
                mob2Desc = inputFile.ReadLine();
                Console.WriteLine(mob2);
                Console.WriteLine(mob2Desc + "\n");
                mob3 = inputFile.ReadLine();
                mob3Desc = inputFile.ReadLine();
                Console.WriteLine(mob3);
                Console.WriteLine(mob3Desc + "\n");
                mob4 = inputFile.ReadLine();
                mob4Desc = inputFile.ReadLine();
                Console.WriteLine(mob4);
                Console.WriteLine(mob4Desc + "\n");
                mob5 = inputFile.ReadLine();
                mob5Desc = inputFile.ReadLine();
                Console.WriteLine(mob5);
                Console.WriteLine(mob5Desc + "\n");
            }

            inputFile.Close();

        }

    }
}
