using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;

namespace OOP.Enemies.Beasts
{
    class Wolf3 : Beast
    {
        public Wolf3()
        {
            Name = "강한늑대";

            Exp = 7;
            Level = 2;
            Maxhp = 70;
            Maxmp = 40;
            Nowmp = Maxmp;

            Str = 3;
            Dex = 2;
            Int = 1;
            Luck = 2;

            defatt = 7;
        }
    }
}
