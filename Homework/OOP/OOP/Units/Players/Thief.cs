using System;
using System.Collections.Generic;
using System.Text;
using OOP.Players;

namespace OOP.Units.Players
{
    class Thief : Human
    {
        public Thief()
        {
            Job = "시프";
            Exp = 0;
            Level = 3;

            Maxhp = 200;
            Nowhp = Maxhp;
            Maxmp = 200;
            Nowmp = Maxmp;

            Str = 4;
            Dex = 4;
            Int = 4;
            Luck = 12;
            LvlStat = 20;

            defatt = 10; //소수점은 버림//

            skill1 = "배쉬";
            skillment1 = "있는 힘껏 내리쳐 적을 공격합니다. (힘과 민에 영향을 받습니다.)";
            skill2 = "더블어택";
            skillment2 = "재빠른 속도로 두번 공격합니다. (민에 영향을 받습니다.)";
        }
    }
}
