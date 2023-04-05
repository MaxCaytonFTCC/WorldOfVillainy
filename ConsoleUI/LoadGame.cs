using System;
using System.IO;
using GameWorldLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{

    public static class LoadGame
    {
        static StreamReader inputFile;

        public static void LoadRooms()
        {
            inputFile = File.OpenText("rooms.txt");
            while (!inputFile.EndOfStream)
            {
                World.room1 = inputFile.ReadLine();
                World.room1Desc = inputFile.ReadLine();

                World.room2 = inputFile.ReadLine();
                World.room2Desc = inputFile.ReadLine();

                World.room3 = inputFile.ReadLine();
                World.room3Desc = inputFile.ReadLine();

                World.room4 = inputFile.ReadLine();
                World.room4Desc = inputFile.ReadLine();

                World.room5 = inputFile.ReadLine();
                World.room5Desc = inputFile.ReadLine();
                
            }
            inputFile.Close();
        }

        public static void LoadWeapons()
        {
            inputFile = File.OpenText("weapons.txt");
            while (!inputFile.EndOfStream)
            {
                World.weapon1 = inputFile.ReadLine();
                World.weapon1Desc = inputFile.ReadLine();

                World.weapon2 = inputFile.ReadLine();
                World.weapon2Desc = inputFile.ReadLine();

                World.weapon3 = inputFile.ReadLine();
                World.weapon3Desc = inputFile.ReadLine();

                World.weapon4 = inputFile.ReadLine();
                World.weapon4Desc = inputFile.ReadLine();

            }
            inputFile.Close();
        }

        public static void LoadPotions()
        {
            inputFile = File.OpenText("potions.txt");
            while (!inputFile.EndOfStream)
            {
                World.potion1 = inputFile.ReadLine();

                World.potion2 = inputFile.ReadLine();

            }
            inputFile.Close();
        }

        public static void LoadTreasure()
        {
            inputFile = File.OpenText("treasures.txt");
            while (!inputFile.EndOfStream)
            {
                World.treasure1 = inputFile.ReadLine();

                World.treasure2 = inputFile.ReadLine();

                World.treasure3 = inputFile.ReadLine();

            }
            inputFile.Close();
        }

        public static void LoadItems()
        {
            inputFile = File.OpenText("items.txt");
            while (!inputFile.EndOfStream)
            {
                World.item1 = inputFile.ReadLine();
                World.item2 = inputFile.ReadLine();
                World.item3 = inputFile.ReadLine();
                World.item4 = inputFile.ReadLine();
            }

            inputFile.Close();
        }

        public static void LoadMobs()
        {
            inputFile = File.OpenText("mobs.txt");
            while (!inputFile.EndOfStream)
            {
                World.mob1 = inputFile.ReadLine();
                World.mob1Desc = inputFile.ReadLine();

                World.mob2 = inputFile.ReadLine();
                World.mob2Desc = inputFile.ReadLine();

                World.mob3 = inputFile.ReadLine();
                World.mob3Desc = inputFile.ReadLine();

                World.mob4 = inputFile.ReadLine();
                World.mob4Desc = inputFile.ReadLine();

                World.mob5 = inputFile.ReadLine();
                World.mob5Desc = inputFile.ReadLine();

            }

            inputFile.Close();
        }

    }
}
