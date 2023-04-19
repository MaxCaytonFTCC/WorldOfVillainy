using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class LoadGame
    {
        static StreamReader inputFile;

        public static void LoadRooms()
        {
            inputFile = File.OpenText("rooms.txt");
            int index = 0;
            while (index < World.rooms.Length && !inputFile.EndOfStream)
            {
                World.rooms[index] = inputFile.ReadLine();
                index++;

            }
            inputFile.Close();
        }

        public static void LoadRoomDescriptions()
        {
            inputFile = File.OpenText("rooms_desc.txt");
            int index = 0;
            while (index < World.rooms.Length && !inputFile.EndOfStream)
            {
                World.roomDescs[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();

        }

        public static void LoadWeapons()
        {
            inputFile = File.OpenText("weapons.txt");
            int index = 0;
            while (index < World.rooms.Length && !inputFile.EndOfStream)
            {
                World.weapons[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();
        }

        public static void LoadWeaponDescriptions()
        {
            inputFile = File.OpenText("weapons_desc.txt");
            int index = 0;
            while (index < World.rooms.Length && !inputFile.EndOfStream)
            {
                World.weaponDescs[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();
        }

        public static void LoadPotions()
        {
            inputFile = File.OpenText("potions.txt");
            int index = 0;
            while (index < World.rooms.Length && !inputFile.EndOfStream)
            {
                World.potions[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();
        }

        public static void LoadTreasure()
        {
            inputFile = File.OpenText("treasures.txt");
            int index = 0;
            while (index < World.rooms.Length && !inputFile.EndOfStream)
            {
                World.treasures[index] = inputFile.ReadLine();
                index++;
            }
            inputFile.Close();
        }

        public static void LoadItems()
        {
            inputFile = File.OpenText("items.txt");
            int index = 0;
            World.items.Clear();
            while (!inputFile.EndOfStream)
            {
                World.items.Add(inputFile.ReadLine());
                index++;
            }

            inputFile.Close();
        }

        public static void LoadMobs()
        {
            inputFile = File.OpenText("mobs.txt");
            int index = 0;
            World.mobs.Clear();
            while (!inputFile.EndOfStream)
            {
                World.mobs.Add(inputFile.ReadLine());
                index++;
            }

            inputFile.Close();
        }

        public static void LoadMobDescriptions()
        {
            inputFile = File.OpenText("mobs_desc.txt");
            int index = 0;
            World.mobDescs.Clear();
            while (!inputFile.EndOfStream)
            {
                World.mobDescs.Add(inputFile.ReadLine());
                index++;
            }

            inputFile.Close();
        }

    }
}
