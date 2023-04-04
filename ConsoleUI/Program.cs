/**
* 4/4/2023
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
                GameMenu.DisplayMenu();

                // Get Input
                menuChoice = Console.ReadLine();
                Console.WriteLine("\n");

                switch(menuChoice)
                {
                    case "1":
                    case "rooms":

                        GameMenu.DisplayRooms();

                        break;

                    case "2":
                    case "weapons":

                        GameMenu.DisplayWeapons();

                        break;

                    case "3":
                    case "potions":

                        GameMenu.DisplayPotions();

                        break;

                    case "4":
                    case "treasure":

                        GameMenu.DisplayTreasure();

                        break;

                    case "5":
                    case "items":

                        GameMenu.DisplayItems();

                        break;

                    case "6":
                    case "mobs":

                        GameMenu.DisplayMobs();

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