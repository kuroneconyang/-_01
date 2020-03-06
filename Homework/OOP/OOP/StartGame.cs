using System;
using System.Collections.Generic;
using OOP.Units;
using OOP.Units.Players;
using OOP.Enemies.Beasts;
using OOP.Enemies.Humans;
using System.Threading;
using static OOP.Game.Choo;
using static OOP.Game.Element;
using static OOP.Game.Story;

namespace OOP
{
    class StartGame
    {
        public static void Gamestart()
        {
            Unit player = new Novice();
            player.chanDef();
            player.chanPower();
            Unit enemy = new Unit();
            Login(player);
            //Open(player);
            //Epi_1(player);
            Field(player, enemy, "1");
        }
    }
}
