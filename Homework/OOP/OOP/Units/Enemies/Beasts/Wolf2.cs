using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;

namespace OOP.Enemies.Beasts
{
    class Wolf2 : Beast
    {
        public Wolf2()
        {
            Name = "양태정";

            Exp = 12;
            Level = 3;
            Maxhp = 100;
            Maxmp = 80;
            Nowmp = Maxmp;

            Str = 3;
            Dex = 3;
            Int = 1;
            Luck = 2;

            defatt = 8;
        }
    }
}
