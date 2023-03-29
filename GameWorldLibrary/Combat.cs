using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public class Combat
    {
        public static void Battle()
        {
            string damage = "1D12";
            int playerHP = 120, mobHP = 120;
            string[] damageNum = damage.Split('D');
            Random rand = new Random();

            // Combat Sequence
            int attackTurn = 0; // Determine which entity's turn it is. 0 for player, 1 for mob

            Console.WriteLine("----COMBAT BEGINS----\n");
            Console.WriteLine("Player HP: "+playerHP+", Mob HP: "+mobHP+"\n");

            while (playerHP > 0 && mobHP > 0) 
            {                
                // Roll the dice to get total damage done
                int totalDamage = 0;

                for (int i = 0; i < int.Parse(damageNum[0]); i++)
                {                    
                    totalDamage += rand.Next(1, int.Parse(damageNum[1]) + 1);                    
                }

                // Subtract damage from correct adversary
                if (attackTurn == 0)
                {                  
                    mobHP -= totalDamage;
                    Console.Write("The Player Attacks! The Mob takes " + totalDamage.ToString() + " damage!");

                    if (mobHP > 0)
                    {
                        Console.Write(" Mob HP: " + mobHP.ToString() + "\n\n");
                    }
                    else if (mobHP <= 0)
                    {
                        Console.Write(" The Mob has died! Overkill: " + Math.Abs(mobHP).ToString() + "\n\n");
                    }

                    attackTurn = 1;                    
                }
                else
                {
                    playerHP -= totalDamage;
                    Console.Write("The Mob Attacks! The Player takes " + totalDamage.ToString() + " damage!");

                    if (playerHP > 0)
                    {
                        Console.Write(" Player HP: "+playerHP.ToString() + "\n\n");
                    }
                    else if (playerHP <= 0)
                    {
                        Console.Write(" The Player has died! Overkill: "+Math.Abs(playerHP).ToString() + "\n\n");
                    }

                    attackTurn = 0;                    
                }                

            }
            
            Console.WriteLine("----COMBAT ENDS----\n");
        }
    }
}