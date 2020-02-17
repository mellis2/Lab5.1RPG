using System;
using System.Collections.Generic;

namespace LAB5._1RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World of Dev.Buildcraft!");


            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(new Wizard("Gandalf", 75, 95, 100, 95));
            Warrior warrior1 = new Warrior("Willard", 85, 75, "Battle Axe");
            gameCharacters.Add(warrior1);
            MagicUsingCharacter magicUsingCharacter1 = new MagicUsingCharacter("Magic John", 80, 85, 90);
            gameCharacters.Add(magicUsingCharacter1);

            foreach (GameCharacter chart in gameCharacters) 
            {
                Console.WriteLine(chart.Play());
            }
            //Warrior warrior1 = new Warrior("Battle Axe");
            
            //Console.WriteLine(warrior1.Play("Willy the Warrior", 80, 95, "Battle Axe"));

            ////MagicUsingCharacter magicUsingCharacter = new MagicUsingCharacter(90);
            ////Console.WriteLine(magicUsingCharacter.Play("Magic Man", 75, 92, 85));
            //Console.WriteLine(magicUsingCharacter.ToString());

            //Wizard wizard1 = new Wizard(100);
            ////Console.WriteLine(wizard1.Play("Gandalf", 80, 100, 100));
            //Console.WriteLine(wizard1.ToString());
        }
    }
}
