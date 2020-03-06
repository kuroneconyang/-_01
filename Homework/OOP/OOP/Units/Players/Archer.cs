using System;
using System.Collections.Generic;
using System.Text;
using OOP.Players;
using OOP.Units.Players;

namespace OOP.Units.Players
{
    class Archer : Human
    {
        public Archer()
        {
        Job = "아쳐";

            Str = 4;
            Dex = 12;
            Int = 4;
            Luck = 4;
            LvlStat = 20;

            defatt = 10 ; //소수점은 버림//

            skill1 = "더블샷";
            skillment1 = "화살을 빠르게 두 번 발사하여 공격합니다. (민에 영향을 받습니다.)";
            skill2 = "파이널샷";
            skillment2 = "혼신의 힘을 담아 마무리 공격을 합니다. (민에 영향을 받습니다.)";
        }
    }
}
