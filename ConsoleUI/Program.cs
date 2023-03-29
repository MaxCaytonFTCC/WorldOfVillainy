/**
* 3/29/2023
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
            
            GameMenu.DisplayMenu();

            Console.ReadKey();

        }
    }
}