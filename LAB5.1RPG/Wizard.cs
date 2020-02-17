using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5._1RPG
{
    class Wizard : MagicUsingCharacter
    {
        private int spellNumber;

        public int SpellNumber { get => spellNumber; set => spellNumber = value; }

        public Wizard(string name, int strength, int intelligence, int magicEnergy, int spellNumber) : base(name, strength, intelligence, magicEnergy)

        {
            this.spellNumber = spellNumber;
        }

        public override string Play()
        {
            return base.Play() + " " + "spellNumber " + spellNumber;

        }

        //public override string ToString()
        //{
        //    return $"{Name} (int {Intelligence}, strength {Strength}) {SpellNumber}";
        //}




    }
}
