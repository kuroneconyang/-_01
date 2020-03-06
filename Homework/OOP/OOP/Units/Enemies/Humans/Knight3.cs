using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;

namespace OOP.Enemies.Humans
{
    class Knight3 : Human
    {
        public Knight3()
        {
            Name = "기마병사";
            Exp = 3;
            Level = 1;
            Maxhp = 100;
            Maxmp = 10;

            defatt = 7;
        }
    }
}
