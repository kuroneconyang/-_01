using System;
using System.Collections.Generic;
using System.Text;
using OOP.Players;


namespace OOP.Units.Players
{
    class Warrior : Human
    {
        public Warrior()
        {
            Job = "워리어";
            Str = 12;
            Dex = 4;
            Int = 4;
            Luck = 4;
            LvlStat = 20;

            defatt = 10 ; //소수점은 버림//
        }
    }
}
