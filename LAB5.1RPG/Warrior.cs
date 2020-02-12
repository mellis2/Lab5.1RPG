using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5._1RPG
{
    class Warrior : GameCharacter
    {
        private string weaponType;

        public Warrior(string weaponType) 
            :base("Willy the Warrior", 80, 95)
        { 
        
        }

        public string WeaponType { get => weaponType; set => weaponType = value; }

        //public override void Play(string name, int strength, int intelligence, string weaponType)
        //{
        //    Console.WriteLine($"{name} (int {intelligence}, strength {strength} {weaponType}");

        //}

        public override string ToString()
        {
            return $"{Name} (int {Intelligence}, strength {Strength}) {WeaponType}";
        }
    }
}
