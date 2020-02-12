using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5._1RPG
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public MagicUsingCharacter(int magicalEnergy)
            :base("Magic Man", 80, 85) 
        { 
            
        }
        public int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }

        //public override void Play(string name, int strength, int intelligence, int magicalEnergy)
        //{
        //    Console.WriteLine($"{name} (int {intelligence}, strength {strength} {magicalEnergy }");

        //}

        public override string ToString()
        {
            return $"{Name} (int { Intelligence}, strength { Strength}){MagicalEnergy}";
        }
    }
}
