using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;


namespace OOP.Game
{
    class Skill
    {

        public static int skill(Unit unit, int a)
        {
            int skillatt = 0;
            string skillname = null;
            switch (a)
            {
                case 1:
                    skillname = unit.skill1;
                    break;
                case 2:
                    skillname = unit.skill2;
                    break;
            }
            switch(skillname)
            {
                case "배쉬":

                    skillatt = (int)Math.Round(unit.Att * 1.2) + ((unit.Str + unit.Dex) / 2);
                    break;

                case "더블어택":

                    skillatt = (int)Math.Round(unit.Att * 1.2) + (unit.Dex * 2);
                    break;

                case "회심의 일격":

                    skillatt = unit.Att + (unit.Nowhp / 2);
                    break;

                case "더블샷":

                    skillatt = unit.Att + (int)Math.Round(unit.Dex * 2.5);
                    break;

                case "파이널샷":
                    skillatt = (unit.Att * 2) + (unit.Dex * 3);
                    break;
            }
            return skillatt;
        }

        public static int skillmana(Unit unit, int a)
        {
            int skillmana = 0;
            string skillname = null;
            switch (a)
            {
                case 1:
                    skillname = unit.skill1;
                    break;
                case 2:
                    skillname = unit.skill2;
                    break;
            }
            switch (skillname)
            {
                case "배쉬":
                    skillmana = 40;
                    break;

                case "더블어택":
                    skillmana = 50;
                    break;

                case "회심의 일격":
                    skillmana = 200;
                    break;

                case "더블샷":
                    skillmana = 50;
                    break;

                case "파이널샷":
                    skillmana = 200;
                    break;
            }
            return skillmana;
        }
        //public int bash(Unit unit)
        //{
        //    int skillatt = (int)Math.Round(unit.Attackpower * 1.2) + ((unit.Str + unit.Dex) / 2);
        //    unit.Nowmp -= 40;

        //    return skillatt;
        //}

        //public int doubleatt(Unit unit)
        //{
        //    int skillatt = (int)Math.Round(unit.Attackpower * 1.2) + ((unit.Dex * 2);
        //    unit.Nowmp -= 40;

        //    return skillatt;
        //}
    }
}

