
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotSimulator
{
    interface iFlying
    {
        //you don't need access modifiers because everything in an interface
        // is public; you don't need the abstract keyword either
        void Fly();
        void Land();
        void TakeOff();
    }
}
