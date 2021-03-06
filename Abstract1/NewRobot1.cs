﻿using System;
using System.Collections.Generic;
using System.Text;
​
namespace RobotSimulator
{
    class Robot1 : Robot
    {
        public Robot(string name) : base(name)
        {
            speed = 10;
            energy = 100;
            GenerateLocation(out x, out y, out z);
        }
​
        public override void Act()
        {
            if (energy < 1.0)
            {
                Charge(.1);
            }
            //pretend I'm deciding if he moves or compacts
            else if (true)
            {
                Move();
            }
            else
            {
                Zap();
            }
        }
        //Method to dig​
        public void Dig()
        {
            int dig = random.Next(0, 4);

//            if (dir == 0)
//            {
//                y -= speed;
//            }
//            else if (dir == 1)
//            {
//                x += speed;
//            }
//            else if (dir == 2)
//            {
//                y += speed;
//            }
//            else
//            {
//                x -= speed;
//            }
//​
//            int altChange = random.Next(0, 3);
//            if (altChange == 1)
//            {
//                z++;
//            }
//            else if (altChange == 2)
//            {
//                if (z > 0)
//                {
//                    z--;
//                }
//            }
            energy -= .8;
        }

        public void Sweep() 
        {
            int sweep = random.Next(0, 5);
            energy -= .5;
        }
​
        public void Zap()
        {
            //compact
            energy -= 2;
        }
    }
}