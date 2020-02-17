﻿using System;

namespace RockPaperScissorsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new RPSGame();
            char response;

            Console.WriteLine("Would you like to play a game of rock, paper, scissors (y or n)?");
            response = char.Parse(Console.ReadLine());

            while (player.validateResponse(response) == false) 
            {
                Console.WriteLine("Invalid Input.  Please re-enter your selection");
                response = char.Parse(Console.ReadLine());
            }

            if (response == 'Y' || response == 'y') 
            {
                Console.Clear();
                player.PlayGame();
            }
            Console.WriteLine("Good Bye");
        }
    }
}
