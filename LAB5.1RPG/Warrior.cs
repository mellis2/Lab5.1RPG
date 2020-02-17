using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5._1RPG
{
    class Warrior : GameCharacter
    {
        private string weaponType;

        public Warrior(string name, int strength, int intelligence, string weaponType) : base(name, strength, intelligence)
        {
            this.weaponType = weaponType;
        }

        public string WeaponType { get => weaponType; set => weaponType = value; }

        public override string Play()
        {
            return base.Play() + weaponType;

        }

        //public override string ToString()
        //{
        //    return $"{Name} (int {Intelligence}, strength {Strength}) {WeaponType}";
        //}
    }
}
