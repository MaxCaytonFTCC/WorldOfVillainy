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
            string weapon3 = "Theif's Rusty Knives"; // Rogue Weapon
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
            string mob5 = "Instructor Funbane";

            Console.WriteLine(room1);
            Console.ReadKey();
        }
    }
}