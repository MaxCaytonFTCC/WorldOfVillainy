using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Commands
    {
        public static char keepGoing = 'y';
        public static int roomIndex = 0;
        
        public static void RunCommand(string input)
        {
            switch (input)
            {
                case "north":
                case "n":

                    LoadGame.LoadRooms();
                    if (roomIndex < (World.rooms.Length - 1))
                    {
                        roomIndex++;                        
                        DisplayRequested.DisplayRooms(roomIndex);
                    }
                    else
                    {
                        DisplayRequested.DisplayMovementError();
                    }

                    break;

                case "south":
                case "s":

                    LoadGame.LoadRooms();
                    LoadGame.LoadRoomDescriptions();
                    if (roomIndex > 0)
                    {
                        roomIndex--;
                        DisplayRequested.DisplayRooms(roomIndex);
                    }

                    else
                    {
                        DisplayRequested.DisplayMovementError();
                    }

                    break;

                case "weapons":
                case "weapon":

                    LoadGame.LoadWeapons();
                    LoadGame.LoadWeaponDescriptions();
                    DisplayRequested.DisplayWeapons();

                    break;


                case "potions":
                case "potion":

                    LoadGame.LoadPotions();
                    DisplayRequested.DisplayPotions();

                    break;


                case "treasures":
                case "treasure":

                    LoadGame.LoadTreasure();
                    DisplayRequested.DisplayTreasure();

                    break;


                case "items":
                case "item":

                    LoadGame.LoadItems();
                    DisplayRequested.DisplayItems();

                    break;


                case "mobs":
                case "mob":

                    LoadGame.LoadMobs();
                    LoadGame.LoadMobDescriptions();
                    DisplayRequested.DisplayMobs();

                    break;


                case "fight":

                    Combat.Battle();

                    break;

                case "exit":
                case "quit":

                    keepGoing = 'n';
                    Console.WriteLine("\nThanks for playing! (Press any key to exit)");
                    
                    break;

                default:
                    DisplayRequested.DisplayInputError();
                    break;

            }


        }
    }
}
