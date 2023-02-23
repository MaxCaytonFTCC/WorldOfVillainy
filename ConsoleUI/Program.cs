/**
* 2/23/2023
* CSC 153
* Max Cayton
* This program provides a menu that displays content from the game World of Villainy.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            // Rooms
            string room1 = "Cave of Awakening"; // Where the player "spawns" and selects their race
            string room2 = "Chasm of Warpaths"; // Where the player learns about and selects their class
            string room3 = "Armory"; // Where starter gear is collected
            string room4 = "Marrowbrew Co. Brewing Tent"; // Where starter potions can be bought from skeletons
            string room5 = "The \"Proving Pit\""; // Where combat is taught to the player

            // Weapons
            string weapon1 = "Initiate's Waraxe"; // Warrior Weapon
            string weapon2 = "Novice's Bone Splinter"; // Necromancer Weapon
            string weapon3 = "Thief's Rusty Knives"; // Rogue Weapon
            string weapon4 = "Flameseer's Flickering Wartorch"; // Firelord Weapon

            // Potions
            string potion1 = "Volatile Vial of Vicious Villainy"; // Damage Increase Potion
            string potion2 = "Disgusting Draught of Dauntless Defense"; // Defense Potion

            // Treasures
            string treasure1 = "Gold Lockbox";
            string treasure2 = "Suspiciously Shiny Ruby Bell";
            string treasure3 = "Fresh Blood Coinpurse";

            // Items
            string item1 = "Armor Pack";
            string item2 = "Marrowbrew Co. Business Card";
            string item3 = "Less-Than-Stellar War Rations";
            string item4 = "Warp Gem";

            // Mobs
            string mob1 = "Overconfident Sword-Swinger";
            string mob2 = "Necrotic Understudy";
            string mob3 = "Crazed Knife Juggler";
            string mob4 = "Angry Campfire";
            string mob5 = "Commander Funbane";


            // Menu
                string menuChoice;
            // Menu Loop
                char keepGoing = 'y';

            while (keepGoing == 'y')
            {

                // Display Menu
                Console.WriteLine("------MAKE A SELECTION------");
                Console.WriteLine("1. Display Rooms");
                Console.WriteLine("2. Display Weapons");
                Console.WriteLine("3. Display Potions");
                Console.WriteLine("4. Display Treasure");
                Console.WriteLine("5. Display Items");
                Console.WriteLine("6. Display Mobs");
                Console.WriteLine("7. Exit");

                // Collect Input
                Console.Write("\nEnter Your Selection: ");
                menuChoice = Console.ReadLine();
                Console.Write("\n");
                // Make Selection
                switch (menuChoice.ToLower())
                {
                    case "1":
                    case "rooms":

                        Console.WriteLine(room1);
                        Console.WriteLine(room2);
                        Console.WriteLine(room3);
                        Console.WriteLine(room4);
                        Console.WriteLine(room5);

                        break;

                    case "2":
                    case "weapons":

                        Console.WriteLine(weapon1);
                        Console.WriteLine(weapon2);
                        Console.WriteLine(weapon3);
                        Console.WriteLine(weapon4);

                        break;

                    case "3":
                    case "potions":

                        Console.WriteLine(potion1);
                        Console.WriteLine(potion2);

                        break;

                    case "4":
                    case "treasure":

                        Console.WriteLine(treasure1);
                        Console.WriteLine(treasure2);
                        Console.WriteLine(treasure3);

                        break;

                    case "5":
                    case "items":

                        Console.WriteLine(item1);
                        Console.WriteLine(item2);
                        Console.WriteLine(item3);
                        Console.WriteLine(item4);

                        break;

                    case "6":
                    case "mobs":

                        Console.WriteLine(mob1);
                        Console.WriteLine(mob2);
                        Console.WriteLine(mob3);
                        Console.WriteLine(mob4);
                        Console.WriteLine(mob5);

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