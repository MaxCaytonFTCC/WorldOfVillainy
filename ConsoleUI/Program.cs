/**
* 4/19/2023
* CSC 153
* Max Cayton
* This program displays content from the game World of Villainy.
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
            string input;

            // Welcome the User
            DisplayRequested.DisplayWelcomeInstructions();
            
            // Game Loop
            while (Commands.keepGoing == 'y')
            {
                // Get Input
                DisplayRequested.DisplayCommandArrow();
                input = Console.ReadLine();
                Console.WriteLine("");
                Commands.RunCommand(input.ToLower());
                Console.WriteLine("");

            }            
            Console.ReadKey();
        }

    }
}