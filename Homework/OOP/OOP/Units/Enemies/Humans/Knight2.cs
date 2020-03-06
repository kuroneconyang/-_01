using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;

namespace OOP.Enemies.Humans
{
    class Knight2 : Human
    {
        public Knight2()
        {
            Name = "창기사";
            Exp = 3;
            Level = 1;
            Maxhp = 100;
            Maxmp = 10;

            defatt = 7;
        }
    }
}
