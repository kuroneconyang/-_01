using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Units
{
    class Unit
    {
        public int chanjob = 0;
        public int totalmob = 0; //잡은몹//
        public int nuHp = 0; //입은데미지//
        public int nuDamage = 0; //준데미지//
        public int nuSDamage = 0; //스킬로준데미지//
        public int esc = 0; //도주여부//
        public int death = 0; //죽음//


        public string Name;
        public string Job;
        public string Type;

        public int Exp;//현재경험치
        public int needExp; //필요경험치
        public int Level;

        public int Maxhp;
        public int Nowhp;
        public int Maxmp;
        public int Nowmp;

        public int Str;
        public int Dex;
        public int Int;
        public int Luck;
        public int LvlStat = 0;

        public int Def = 2;
        public void chanDef() //방어력//
        {
            int def = (Level / 2);
            Def += def;
        }
        
        public int defatt;//기본공격력//
        public int Att;//공격력//

        public void chanexp()
        {
            int need = 10 * (Level * Level + 3) / 2;
            needExp = need;
        }

        public void chanPower()
        {
            int att = Level + (Str + Dex + Int + Luck) / 5;
            Att = defatt + att;
        }
        public int Chan()//회피력//
        {
            Random rnd = new Random();
            int Chance = rnd.Next(100);
            return Chance;
        }

        public int CritAttack(int a) //크리//
        {
            int att = 0;
            Random rnd = new Random();
            int Chance = rnd.Next(100);
            if (Chance < 15)
            {
                att = a * 2;
            }
            else
            {
                att = a;
            }
            if(att < 1)
            {
                att = 0;
            }
            return att;
        }
        public string skill1;
        public string skillment1;
        public string skill2;
        public string skillment2;
    }
}
