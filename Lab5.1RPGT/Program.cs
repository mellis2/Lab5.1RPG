using System;
using System.Collections.Generic;

namespace Lab_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(new Warrior("Trogdor the Burninator", 999, 15, "Big Beefy Arm"));
            gameCharacters.Add(new Warrior("Strong Mad", 75, 33, "email"));
            gameCharacters.Add(new Wizard("The Cheat", 27, 250, 450, 3));
            gameCharacters.Add(new Wizard("Strong Bad", 34, 88, 300, 5));
            gameCharacters.Add(new Wizard("Strong Sad", 70, 98, 600, 2));

            Console.WriteLine("Welcome to the world of Homestar Runner(craft)!");

            foreach (GameCharacter g in gameCharacters)
            {
                Console.WriteLine(g.Play());
            }

        }
    }
}