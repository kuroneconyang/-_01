using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;

namespace OOP.Enemies.Humans
{
    class Knight1 : Human
    {
        public Knight1()
        {
            Name = "한준서";
            Exp = 3;
            Level = 1;
            Maxhp = 100;
            Maxmp = 10;

            defatt = 1;
        }
    }
}
