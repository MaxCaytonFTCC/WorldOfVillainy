/**
* 4/5/2023
* CSC 153
* Max Cayton
* This program provides a menu that displays content from the game World of Villainy.
*/

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameWorldLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            char keepGoing = 'y';
            string menuChoice;

            while (keepGoing == 'y')
            {
                DisplayRequested.DisplayMenu();

                // Get Input
                menuChoice = Console.ReadLine();
                Console.WriteLine("\n");

                switch(menuChoice)
                {
                    case "1":
                    case "rooms":

                        LoadGame.LoadRooms();
                        DisplayRequested.DisplayRooms();

                        break;

                    case "2":
                    case "weapons":

                        LoadGame.LoadWeapons();
                        DisplayRequested.DisplayWeapons();

                        break;

                    case "3":
                    case "potions":

                        LoadGame.LoadPotions();
                        DisplayRequested.DisplayPotions();

                        break;

                    case "4":
                    case "treasure":

                        LoadGame.LoadTreasure();
                        DisplayRequested.DisplayTreasure();

                        break;

                    case "5":
                    case "items":

                        LoadGame.LoadItems();
                        DisplayRequested.DisplayItems();

                        break;

                    case "6":
                    case "mobs":

                        LoadGame.LoadMobs();
                        DisplayRequested.DisplayMobs();

                        break;

                    case "7":
                    case "fight":

                        Combat.Battle();

                        break;

                    default:
                        Console.WriteLine("\nThanks for playing! (Press any key to exit)");
                        keepGoing = 'n';
                        break;

                }

                Console.WriteLine("\n");

            }
            

            Console.ReadKey();

        }
    }
}