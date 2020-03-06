using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;

namespace OOP.Enemies.Humans
{
    class Knightboss : Human
    {
        public Knightboss()
        {
            Name = "한준서";
            Exp = 3;
            Level = 1;
            Maxhp = 100;
            Maxmp = 10;

            defatt = 7;
        }
    }
}
