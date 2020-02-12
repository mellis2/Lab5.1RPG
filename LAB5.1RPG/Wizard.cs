using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5._1RPG
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public Wizard(int spellNumber)
            :base(100)
            {
                
            }
        //public override void Play(string name, int strength, int intelligence, string weaponType)
        //{
        //    Console.WriteLine($"{name} (int{intelligence}, strength {strength}) {spellNumber}");

        //}

        public override string ToString()
        {
            return $"{Name} (int {Intelligence}, strength {Strength}) {SpellNumber}";
        }




    }
}
