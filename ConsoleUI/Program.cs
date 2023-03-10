/**
* 3/10/2023
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

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {

            // Read Variable Values From .txt File
            StreamReader inputFile;

            inputFile = File.OpenText("gamedata.txt");

            // Rooms
            string room1 = inputFile.ReadLine();
            string room1Desc = inputFile.ReadLine();
            string room2 = inputFile.ReadLine();
            string room2Desc = inputFile.ReadLine();
            string room3 = inputFile.ReadLine();
            string room3Desc = inputFile.ReadLine();
            string room4 = inputFile.ReadLine();
            string room4Desc = inputFile.ReadLine();
            string room5 = inputFile.ReadLine();
            string room5Desc = inputFile.ReadLine();

            // Weapons
            string weapon1 = inputFile.ReadLine();
            string weapon1Desc = inputFile.ReadLine();
            string weapon2 = inputFile.ReadLine();
            string weapon2Desc = inputFile.ReadLine();
            string weapon3 = inputFile.ReadLine();
            string weapon3Desc = inputFile.ReadLine();
            string weapon4 = inputFile.ReadLine();
            string weapon4Desc = inputFile.ReadLine();

            // Potions
            string potion1 = inputFile.ReadLine();
            string potion2 = inputFile.ReadLine();

            // Treasures
            string treasure1 = inputFile.ReadLine();
            string treasure2 = inputFile.ReadLine();
            string treasure3 = inputFile.ReadLine();

            // Items
            string item1 = inputFile.ReadLine();
            string item2 = inputFile.ReadLine();
            string item3 = inputFile.ReadLine();
            string item4 = inputFile.ReadLine();

            // Mobs
            string mob1 = inputFile.ReadLine();
            string mob1Desc = inputFile.ReadLine();
            string mob2 = inputFile.ReadLine();
            string mob2Desc = inputFile.ReadLine();
            string mob3 = inputFile.ReadLine();
            string mob3Desc = inputFile.ReadLine();
            string mob4 = inputFile.ReadLine();
            string mob4Desc = inputFile.ReadLine();
            string mob5 = inputFile.ReadLine();
            string mob5Desc = inputFile.ReadLine();

            inputFile.Close();

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
                        Console.WriteLine(room1Desc + "\n");
                        Console.WriteLine(room2);
                        Console.WriteLine(room2Desc + "\n");
                        Console.WriteLine(room3);
                        Console.WriteLine(room3Desc + "\n");
                        Console.WriteLine(room4);
                        Console.WriteLine(room4Desc + "\n");
                        Console.WriteLine(room5);
                        Console.WriteLine(room5Desc + "\n");

                        break;

                    case "2":

                    case "weapons":

                        Console.WriteLine(weapon1);
                        Console.WriteLine(weapon1Desc + "\n");
                        Console.WriteLine(weapon2);
                        Console.WriteLine(weapon2Desc + "\n");
                        Console.WriteLine(weapon3);
                        Console.WriteLine(weapon3Desc + "\n");
                        Console.WriteLine(weapon4);
                        Console.WriteLine(weapon4Desc + "\n");

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
                        Console.WriteLine(mob1Desc + "\n");
                        Console.WriteLine(mob2);
                        Console.WriteLine(mob2Desc + "\n");
                        Console.WriteLine(mob3);
                        Console.WriteLine(mob3Desc + "\n");
                        Console.WriteLine(mob4);
                        Console.WriteLine(mob4Desc + "\n");
                        Console.WriteLine(mob5);
                        Console.WriteLine(mob5Desc + "\n");

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