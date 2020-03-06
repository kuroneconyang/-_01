using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;

namespace OOP.Units.Players
{
    class Novice : Human
    {
        public Novice()
        {
            Job = "노비스";
            Exp = 0;
            needExp = 10;
            Level = 1;

            Maxhp = 200;
            Nowhp = Maxhp;
            Maxmp = 100;
            Nowmp = Maxmp;


            Str = 12;
            Dex = 4;
            Int = 4;
            Luck = 4;
            // 24 + 20 = 44
            LvlStat = 0;

            defatt = 70 ; //소수점은 버림//

            skill1 = "배쉬";
            skillment1 = "있는 힘껏 내리쳐 적을 공격합니다. (힘과 민에 영향을 받습니다.)";
            skill2 = "더블어택";
            skillment2 = "재빠른 속도로 두번 공격합니다. (민에 영향을 받습니다.)";
        }
    }
}
