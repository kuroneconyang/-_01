using System;
using System.Collections.Generic;
using System.Text;
using OOP.Units;
using OOP.Units.Players;
using static OOP.Game.Choo;

namespace OOP.Players
{
    class Player : Unit
    {

        public static void levelup(Unit player)
        { 
            if(player.Exp >= player.needExp)
            {

                player.Level++;
                player.LvlStat += 4;
                player.Maxhp += 20;
                player.Maxmp += 20;
                player.Nowhp = player.Maxhp;
                player.Nowmp = player.Maxmp;
                player.Exp = player.Exp - player.needExp;
                player.chanexp();
                Stcolor("레벨이 올랐다!",1);
                Stcolor($"~g{player.Name}~w의 레벨이 {player.Level-1}에서 ~y{player.Level}~w이(가) 되었다.",1);
                Stcolor($"~g{player.Name}의 경험치가 ~y{player.Exp}~w이 되었다.",2,1000);
            }

            else
            {
                Stcolor($"~g{player.Name}의 경험치가 ~y{player.Exp}~w이 되었다.", 2, 1000);
            }
        } 

        public static void classup(ref Unit player)
        {
            //if(player.chanjob == 0)
            //{
                if (player.Level >= 3)
                {
                    string sel = null;
                    string sel2 = null;
                    bool chanClass = true;
                    bool choClass = true;
                    Stcolor("~w레벨이 ~r[ 3 ] ~w이 되어 직업을 ~r변경~w할 수 있습니다.",2,0);
                    Stcolor("~w※ 변경시 분배 가능한 능력치가 8만큼 증가합니다.", 1, 0);
                    while (chanClass == true)
                    {
                        string job = null;
                        while (choClass == true)
                        {
                            Stcolor("~w1번 : 워리어",1,0);
                            Stcolor("~w2번 : 아쳐",1,0);
                            Stcolor("~w3번 : 시프",1,0);
                            Stcolor("~w4번 : 노비스(변경안함)",1,0);
                            Stcolor("~w원하시는 직업을 선택해주세요. : ",0,0);
                            sel = Console.ReadLine();
                            switch (sel)
                            {
                                case "1":
                                    choClass = false;
                                    job = "워리어";
                                    break;
                                case "2":
                                    choClass = false;
                                    job = "아쳐";
                                    break;
                                case "3":
                                    choClass = false;
                                    job = "시프";
                                    job = "";
                                    break;
                                case "4":
                                    choClass = false;
                                    job = "노비스";
                                    break;
                                default:
                                    Stcolor("올바른 값을 골라주세요.",2);
                                    break;
                            }
                        }
                        Stcolor($"~g[ {job} ] ~w을(를) 선택하셨습니다. 결정하시겠습니까?",1);
                        Stcolor("~w※ 한 번 결정하시면 변경이 ~r불가능~w합니다. 능력치가 초기화됩니다.",1);
                        Stcolor("[ Y / N ] : ", 0, 0);
                            sel2 = Console.ReadLine().ToUpper();
                        if (sel2 == "Y")
                        {
                            Stcolor("~w직업이 변경되었습니다.",2,1000);
                            switch(sel)
                            {
                                case "1" :
                                    Warrior warrior = new Warrior();
                                    player.Job = warrior.Job;
                                    player.defatt = warrior.defatt;
                                    player.Str = warrior.Str;
                                    player.Dex = warrior.Dex;
                                    player.Int = warrior.Int;
                                    player.Luck = warrior.Luck;
                                    player.skill1 = warrior.skill1;
                                    player.skill2 = warrior.skill2;
                                    player.skillment1 = warrior.skillment1;
                                    player.skillment2 = warrior.skillment2;
                                    break;
                                case "2":
                                    Archer archer = new Archer();
                                    Console.ReadLine();
                                    player = archer;
                                    Console.ReadLine();
                                    //player.Job = archer.Job;
                                    //player.defatt = archer.defatt;
                                    //player.Str = archer.Str;
                                    //player.Dex = archer.Dex;
                                    //player.Int = archer.Int;
                                    //player.Luck = archer.Luck;
                                    //player.skill1 = archer.skill1;
                                    //player.skill2 = archer.skill2;
                                    //player.skillment1 = archer.skillment1;
                                    //player.skillment2 = archer.skillment2;
                                    break;
                                case "3":
                                    player = new Thief();

                                    //Thief thief = new Thief();
                                    //player.Job = thief.Job;
                                    //player.Str = thief.Str;
                                    //player.Dex = thief.Dex;
                                    //player.Int = thief.Int;
                                    //player.Luck = thief.Luck;
                                    //player.skill1 = thief.skill1;
                                    //player.skill2 = thief.skill2;
                                    //player.skillment1 = thief.skillment1;
                                    //player.skillment2 = thief.skillment2;
                                    break;
                                case "4":
                                    player.LvlStat += 8;
                                    break;
                            }
                            break;
                        }
                        else if (sel2 == "N" || sel2 == "n")
                        {
                            choClass = true;
                        }
                        else
                        {
                            Stcolor("~w올바른 값을 골라주세요.",2);
                        }
                    }

                }
            //}
            //player.chanjob = 1;
        }
    }
}
