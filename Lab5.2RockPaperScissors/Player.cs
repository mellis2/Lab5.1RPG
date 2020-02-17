using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._2RockPaperScissors
{
    abstract class Player
    {
        public static void GenerateRoshambo() 
        {
            
            
                Random random = new Random();
                return random.Next(1, 4);

            if (random == 1)
            {
                Console.WriteLine("Rock");
            }
            else if (random == 2)
            {
                Console.WriteLine("Paper");
            }
            else if (random == 3) 
            {
                Console.WriteLine("Scissors");
            }
            
        }
    }
}
