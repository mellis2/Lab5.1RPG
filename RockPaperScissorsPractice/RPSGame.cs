﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissorsPractice
{
    class RPSGame
    {
        public enum Hand {Rock = 1, Paper, Scissors };
        public enum Outcome {Win, Lose, Tie}

        public Hand ComputerHand { get; set; }
        public Hand PlayerHand { get; set; }
        public char UserSelection { get; set; }

        public Hand getUserHand() 
        {
            while (!validateSelection())
            {
                Console.Clear();
                Console.WriteLine("Invalid Input");
                Screen();
                UserSelection = Convert.ToChar(Console.ReadLine());
            }

            switch (Char.ToUpper(UserSelection)) 
            {
                case 'R':
                    PlayerHand = Hand.Rock;
                    break;
                case 'P':
                    PlayerHand = Hand.Paper;
                    break;
                case 'S':
                    PlayerHand = Hand.Scissors;
                    break;
                default:
                    throw new Exception("Unexpected Error");
            }
            return PlayerHand;
        }

        public void PlayGame() 
        {
            bool gameOver = false;
            var rand = new Random();
            char response;

            while (!gameOver) 
            {
                Screen();
                UserSelection = Convert.ToChar(Console.ReadLine());
                getUserHand();
                ComputerHand = (Hand)rand.Next(1, 4);
                Console.Clear();
                Console.WriteLine("Computer's Hand: {0}", ComputerHand);
                Console.WriteLine("Player's Hand: {0}", PlayerHand);

                if (DetermineWinner() == Outcome.Win)
                {
                    Console.WriteLine("{0} beats {1}. Player wins", PlayerHand, ComputerHand);
                }
                else if (DetermineWinner() == Outcome.Lose) 
                {
                    Console.WriteLine("{0} beats {1}. Computer wins", ComputerHand, PlayerHand);
                }
                else
                    Console.WriteLine("It's a tie");

                Console.WriteLine("\nWould you like to play another game (y or n)");
                response = Char.Parse(Console.ReadLine());

                while (validateResponse(response) == false) 
                {
                    Console.WriteLine("Invalid input.  Please re-enter your selection: ");
                    response = char.Parse(Console.ReadLine());
                }

                if (response == 'N' || response == 'n') 
                {
                    gameOver = true;
                }

                Console.Clear();
                
            }
        }

        public bool validateResponse(char response) 
        {
            if (char.ToUpper(response) != 'y' && Char.ToUpper(response) != 'N')
                return false;

            return true;
        }

        public Outcome DetermineWinner()
        {
            if (PlayerHand == Hand.Scissors && ComputerHand == Hand.Paper)
            {
                return Outcome.Win;
            }
            else if (PlayerHand == Hand.Rock && ComputerHand == Hand.Scissors)
            {
                return Outcome.Win;
            }
            else if (PlayerHand == Hand.Paper && ComputerHand == Hand.Rock)
            {
                return Outcome.Win;
            }
            else if (PlayerHand == Hand.Scissors && ComputerHand == Hand.Rock)
            {
                return Outcome.Lose;
            }
            else if (PlayerHand == Hand.Rock && ComputerHand == Hand.Paper)
            {
                return Outcome.Lose;
            }
            else if (PlayerHand == Hand.Paper && ComputerHand == Hand.Scissors)
            {
                return Outcome.Lose;
            }
            return Outcome.Tie;
        }

            private bool validateSelection()
        {
            char value = Char.ToUpper(UserSelection);
            if (value != 'R' && value != 'P' && value != 'S') 
            {
                return false;
            }
            return true;
        }
        private void Screen() 
        {
            Console.WriteLine("R - Rock");
            Console.WriteLine("P - Paper");
            Console.WriteLine("S - Scissors");
            Console.WriteLine("Please Make your selection: ");
        }

    }
}
