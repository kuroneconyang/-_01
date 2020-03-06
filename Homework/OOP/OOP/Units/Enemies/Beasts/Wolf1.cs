using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;


namespace OOP.Enemies.Beasts
{
    class Wolf1 : Beast
    {
        public Wolf1()
        {
            Name = "새끼늑대";
            
            Exp = 4;
            Level = 1;
            Maxhp = 50;
            Maxmp = 30;
            Nowmp = Maxmp;

            Str = 2;
            Dex = 2;
            Int = 1;
            Luck = 1;

            defatt = 4;
        }
    }
}
