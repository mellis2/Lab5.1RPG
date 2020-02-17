using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5._1RPG
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicEnergy) : base(name, strength, intelligence)
            
        {
            this.magicalEnergy = magicEnergy;
        }
        public int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }

        public override string Play()
        {
            return base.Play() + " " + "Magical Energy " + magicalEnergy;

        }

        //public override string ToString()
        //{
        //    return $"{Name} (int { Intelligence}, strength { Strength}){MagicalEnergy}";
        //}
    }
}
