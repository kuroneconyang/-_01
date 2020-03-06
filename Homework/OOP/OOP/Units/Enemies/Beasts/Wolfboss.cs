using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;

namespace OOP.Enemies.Beasts
{
    class Wolfboss : Beast
    {
        public Wolfboss()
        {
            Name = "웨어울프";

            esc = 2;
            Exp = 100;
            Level = 7;
            Maxhp = 500;
            Maxmp = 300;
            Nowmp = Maxmp;

            Str = 6;
            Dex = 6;
            Int = 3;
            Luck = 6;

            defatt = 10;
        }


    }
}
