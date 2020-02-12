using System;

namespace LAB5._1RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World of Dev.Buildcraft!");

            GameCharacter gameCharacter1 = new GameCharacter("Frodo The Game Character", 90, 75);
            gameCharacter1.Play("Frodo The Game Character", 90, 75);
            //Console.WriteLine(gameCharacter1.ToString());
            Warrior warrior1 = new Warrior("Battle Axe");
            Console.WriteLine(warrior1.ToString());
            //Console.WriteLine(warrior1.Play("Willy the Warrior", 80, 95, "Battle Axe"));
            
            MagicUsingCharacter magicUsingCharacter = new MagicUsingCharacter(90);
            //Console.WriteLine(magicUsingCharacter.Play("Magic Man", 75, 92, 85));
            Console.WriteLine(magicUsingCharacter.ToString());

            Wizard wizard1 = new Wizard(100);
            //Console.WriteLine(wizard1.Play("Gandalf", 80, 100, 100));
            Console.WriteLine(wizard1.ToString());
        }
    }
}
