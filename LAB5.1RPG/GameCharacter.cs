using System;
using System.Collections.Generic;
using System.Text;

namespace LAB5._1RPG
{
    class GameCharacter
    {
        private string name;
        private int strength;
        private int intelligence;

        public GameCharacter(string name, int strength, int intelligence)
        {
            this.Name = name;
            this.Strength = strength;
            this.Intelligence = intelligence;
        }

        public string Name { get => name; set => name = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }

        public virtual string Play() 
        {
            return $"{name} (strength {strength} intelligence {intelligence}) ";
                
        }


        //public override string ToString()
        //{
        //    return $"{Name} (int {Intelligence}, strength {Strength})";
        //}
    }

}
