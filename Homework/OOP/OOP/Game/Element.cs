using OOP.Enemies.Beasts;
using OOP.Units;
using System;
using System.Collections.Generic;
using static OOP.Game.Choo;
using static OOP.Game.Skill;
using static OOP.Players.Player;

namespace OOP.Game
{
    class   Element
    {

        public static void Statlog(Unit player) //상태창확인//
        {
            Stcolor("w~-------------------------------",2,0);
            Stcolor($"이름 : ~g{player.Name}",1,0);
            Stcolor($"직업(종족) : {player.Job}({player.Type})",1,0);
            Stcolor($"레벨 : {player.Level}",1,0);
            Stcolor($"현재경험치 : {player.Exp}",1,0);
            Stcolor($"필요경험치 : {player.needExp}",2,0);
            Stcolor($"최대체력 : {player.Maxhp}",1,0);
            Stcolor($"현재체력 : {player.Nowhp}",1,0);
            Stcolor($"최대마나 : {player.Maxmp}",1,0);
            Stcolor($"현재마나 : {player.Nowmp}",2,0);
            Stcolor($"힘(STR) : {player.Str}",1,0);
            Stcolor($"민(DEX) : {player.Dex}",1,0);
            Stcolor($"지력(INT) : {player.Int}",1,0);
            Stcolor($"운(LUCK) : {player.Luck}",1,0);
            Stcolor($"남은 능력치: {player.LvlStat}",2,0);
            Stcolor($"공격력(Att) : {player.Att}",1,0);
            Stcolor($"방어력(Def) : {player.Def}",2,0);
            Stcolor($"보유스킬(Skill) : {player.skill1} / {player.skill2}",2,0);
            Stcolor("-------------------------------",2,0);
        }

        public static void Statplayer(Unit player) //능력치투자//
        {
            bool start = true;
            Statlog(player);
            while (start == true)
            {
                Stcolor("1번 : 능력치분배",1,0);
                Stcolor("2번 : 스킬확인",1,0);
                Stcolor("3번 : 뒤로",1,0);
                Stcolor("무엇을 하시겠습니까? : ", 0, 0);
                string sel = Console.ReadLine();
                Console.WriteLine();
                if (sel == "1")
                {
                    while (start == true)
                    {
                        string sel1 = null;
                        while (start == true)
                        {
                            bool choice1 = true;
                            while (choice1 == true)
                            {

                                Console.WriteLine("1번 : 힘(Str)");
                                Console.WriteLine("2번 : 민(Dex)");
                                Console.WriteLine("3번 : 지(Int)");
                                Console.WriteLine("4번 : 운(Luck)");
                                Console.WriteLine("5번 : 뒤로");
                                Console.Write("어떤 능력치를 올리겠습니까? : ");
                                sel1 = Console.ReadLine();
                                Console.WriteLine();
                                switch (sel1)
                                {
                                    case "1":
                                        Console.WriteLine("힘(Str)을(를) 올리시겠습니까? : [ Y / N ]");
                                        choice1 = false;
                                        break;

                                    case "2":
                                        Console.WriteLine("민(Dex)을(를) 올리시겠습니까? : [ Y / N ]");
                                        choice1 = false;
                                        break;

                                    case "3":
                                        Console.WriteLine("지(Int)을(를) 올리시겠습니까? : [ Y / N ]");
                                        choice1 = false;
                                        break;

                                    case "4":
                                        Console.WriteLine("운(Luck)을(를) 올리시겠습니까? : [ Y / N ]");
                                        choice1 = false;
                                        break;
                                    case "5":
                                        choice1 = false;
                                        break;
                                    default:
                                        Console.WriteLine("올바른 값을 입력해주세요.");
                                        break;
                                }
                            }

                            if (sel1 == "5")
                            {
                                start = false;
                                break;
                            }
                            string sel2 = Console.ReadLine();
                            Console.WriteLine();
                            if (sel2 == "Y" || sel2 == "y")
                            {
                                break;
                            }
                            else if (sel2 == "N" || sel2 == "n")
                            {
                            }
                            else
                            {
                                Console.WriteLine("올바른 값을 입력해주세요.");

                            }
                            Console.WriteLine();
                        }


                        while (start == true)
                        {
                            Console.WriteLine($"남은 능력치 : {player.LvlStat}");
                            Console.Write("얼마나 올리시겠습니까? : ");
                            string count = Console.ReadLine();
                            Console.WriteLine();
                            if (Try(count) == true)
                            {
                                while (start == true)
                                {
                                    int countre = int.Parse(count);
                                    Console.WriteLine($"{countre}맞으십니까? : [ Y / N ]");
                                    string choo = Console.ReadLine();
                                    Console.WriteLine();
                                    if (choo == "y" || choo == "Y")
                                    {
                                        if (player.LvlStat >= countre)
                                        {
                                            Console.WriteLine("적용되었습니다.");
                                            Console.WriteLine();
                                            player.LvlStat -= countre;
                                            switch (sel1)
                                            {
                                                case "1":
                                                    player.Str += countre;
                                                    break;
                                                case "2":
                                                    player.Dex += countre;
                                                    break;
                                                case "3":
                                                    player.Int += countre;
                                                    break;
                                                case "4":
                                                    player.Luck += countre;
                                                    break;
                                            }

                                            player.chanDef();
                                            player.chanPower();
                                            start = false;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("분배 가능한 능력치가 부족합니다.");
                                            Console.WriteLine();
                                            start = false;
                                            break;
                                        }
                                    }
                                    else if (choo == "n" || choo == "N")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("올바른 값을 입력해주세요.");
                                        Console.WriteLine();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("숫자를 입력해주세요.");
                                Console.WriteLine();
                            }
                        }
                    }
                }
                else if (sel == "2")
                {
                    bool choice2 = true;
                    while (choice2 == true)
                    {
                        Stcolor($"1번 : ~y[{player.skill1}]~w / 2번 : ~y[{player.skill2}]",1,0);
                        Stcolor("어떤 스킬을 확인하시겠습니까? : ",0,0);
                        string skillsel = Console.ReadLine();
                        Console.WriteLine();
                        switch (skillsel)
                        {
                            case "1":
                                Stcolor($"~y[{player.skill1}]",1,0);
                                Stcolor(player.skillment1,1,0);
                                Stcolor("아무키나 누르시면 돌아갑니다.",1,0);
                                Console.ReadLine();
                                Console.WriteLine();
                                choice2 = false;
                                break;
                            case "2":
                                Stcolor($"~y[{player.skill2}]", 1, 0);
                                Stcolor(player.skillment2, 1, 0);
                                Stcolor("아무키나 누르시면 돌아갑니다.", 1, 0);
                                Console.ReadLine();
                                Console.WriteLine();
                                choice2 = false;
                                break;
                            default:
                                Stcolor("올바른 값을 입력해주세요.",2,0);
                                break;
                        }
                    }
                }

                else if (sel == "3")
                {
                    break;
                }
            }

        }

        public static void Battleform(Unit player)
        {
            Stcolor($"남은 HP : ~r{player.Nowhp}~w / ~y{player.Maxhp}",1,0);
            Stcolor($"남은 MP : ~r{player.Nowmp}~w / ~y{player.Maxmp}", 2, 0);
            Stcolor("------------------------- ",2,0);
            Stcolor("1번 : 몬스터를 처치한다.(전투를 통하여 성장가능)",1,0);
            Stcolor("2번 : 휴식을 취한다.(체력 + 100,마나 + 200. 전투 한 번에 한 번만 가능)",1,0);
            Stcolor("3번 : 스테이터스.(현재 나의 상태창을 불러옵니다)",1,0);
            Stcolor("4번 : 보스를 만나러간다.(보스처치시 다음 스토리 진행(현재는 처치시 종료됩니다.)",2,0);
            Stcolor("------------------------- ",2,0);
            Stcolor("어떡하시겠습니까 ? : ",0,0);
        }

        public static void BattleAtt(Unit player, Unit enemy)
        {
            bool selatt = true;
            while(selatt == true)
            {
                Stcolor($"~g{player.Name}({player.Type})~w의 체력 : ~r{player.Nowhp} / ~y{player.Maxhp}", 1, 0);
                Stcolor($"~g{player.Name}({player.Type})~w의 마나 : ~b{player.Nowmp} / ~y{player.Maxmp}", 1, 0);
                Stcolor($"~r{enemy.Name}({enemy.Type})~w의 체력 : ~r{enemy.Nowhp} / ~y{enemy.Maxhp}", 1, 0);
                Stcolor($"~r{enemy.Name}({enemy.Type})~w의 마나 : ~b{enemy.Nowmp} / ~y{enemy.Maxmp}", 2, 0);
                Stcolor("---------------------", 2, 0);
                Stcolor("1번 : 일반공격 (일반공격으로 ~r데미지~w를 입힙니다.)", 1, 0);
                Stcolor("2번 : 스킬공격 (~b마나를 소모~w하여 강력한 ~r데미지~w를 입힙니다.)", 1, 0);
                Stcolor("3번 : 방어 (~y방어력을 두배~w로 올립니다. ~r회피와 치명타~w가 발생하지않으며, ~y30% 확률로 반격~w합니다.)", 1, 0);
                Stcolor("4번 : 도주 (30%확률로 ~r전투에서 도망~w칩니다. 도주에 ~r실패~w하면 방어력을 ~r무시한 데미지~w가 들어옵니다.)", 2, 0);
                Stcolor("---------------------", 2, 0);
                Stcolor("어떡하시겠습니까? : ", 0, 0);
                string selList = Console.ReadLine();
                Console.WriteLine();
                if (selList == "1")
                {
                    int mepower = 0;
                    int mecrit = 0;
                    mepower = player.Att - enemy.Def;
                    mecrit = player.CritAttack(player.Att) - enemy.Def;

                    if (mepower < 0)
                    {
                        mepower = 0;
                    }
                    if (mecrit < 0)
                    {
                        mecrit = 0;
                    }
                    Stcolor($"~g{player.Name}~w이(가) ~r일반공격~w을(를) 사용했다!", 2, 500);
                    if (enemy.Chan() < 15)
                    {
                        Stcolor($"~g{enemy.Name}~w은(는) 공격을 회피했다!", 1, 0);
                        Stcolor("---------------------", 2, 500);

                    } //15%확률로 회피성공//
                    else
                    {
                        if (mecrit == mepower)
                        {
                            Stcolor($"{enemy.Name}은(는) {mepower}만큼의 데미지를 받았다!", 1, 500);
                            enemy.Nowhp -= mepower;
                            player.nuDamage += mepower;
                        }
                        else
                        {
                            Stcolor("효과가 굉장했다!", 1, 500);
                            Stcolor($"{enemy.Name}은(는) {mecrit}만큼의 데미지를 받았다!", 2, 500);
                            enemy.Nowhp -= mecrit;
                            player.nuDamage += mecrit;
                        }
                    } //회피실패
                    
                    if (enemy.Nowhp < 1)
                    {
                        enemy.Nowhp = 0;
                        Stcolor($"{enemy.Name}의 남은 체력은 {enemy.Nowhp}이(가) 되었다.", 1, 0);
                        Stcolor("---------------------", 2, 500);
                        break;
                    }//적 처치시 반격안함//
                    else
                    {
                        int youpower = 0;
                        int youcrit = 0;
                        youpower = enemy.Att - player.Def;
                        youcrit = enemy.CritAttack(enemy.Att) - player.Def;
                        if (youpower < 0)
                        {
                            youpower = 0;
                        }
                        if (youcrit < 0)
                        {
                            youcrit = 0;
                        }
                        Stcolor($"{enemy.Name}은(는) 반격했다.", 2, 500);

                        if (player.Chan() < 15)
                        {
                            Stcolor($"~g{player.Name}은(는) 공격을 회피했다!", 1,0);
                            Stcolor("---------------------", 2, 500);
                        }
                        else
                        {
                            if (youcrit == youpower)
                            {
                                
                                Stcolor($"~g{player.Name}~w은(는) ~r{youpower}~w만큼의 데미지를 받았다!", 1, 500);
                                player.Nowhp -= youpower;
                                player.nuHp += youpower;
                            }
                            else
                            {
                                Stcolor("효과가 굉장했다!", 1, 500);
                                Stcolor($"~g{player.Name}~w은(는) ~r{youcrit}~w만큼의 데미지를 받았다!", 1, 500);
                                player.Nowhp -= youcrit;
                                player.nuHp += youcrit;
                            }
                            Stcolor("---------------------", 2, 500);
                            if (player.Nowhp < 1)
                            {
                                break;
                            }
                        }
                    }//적 처치못할시 반격//
                } //일반공격//
                else if (selList == "2") //스킬공격//
                {
                    string act = null;
                    int chanact = 0;
                    int mepower = 0;
                    int mecrit = 0;
                    bool roop = true;
                    while (roop == true)
                    {
                        Stcolor($"보유스킬 : [ {player.skill1} ]  / [ {player.skill2} ]",1,0);
                        Stcolor($"1번 : {player.skill1} / ~b소모마나 : {skillmana(player, 1)}",1,0);
                        Stcolor($"2번 : {player.skill2} / ~b소모마나 : {skillmana(player, 2)}",1,0);
                        Stcolor($"3번 : 뒤로",1,0);
                        Console.Write("어떻게 하시겠습니까? : ");
                        act = Console.ReadLine();
                        if (Try(act) == true && act == "1" || act == "2")
                        {
                            chanact = int.Parse(act);
                            if (player.Nowmp >= skillmana(player, chanact))
                            {
                                switch (act)
                                {
                                    case "1":
                                        Stcolor($"~y{player.skill1}~w을(를) 사용합니다.",2);
                                        player.Nowmp -= skillmana(player, chanact);
                                        roop = false;
                                        break;
                                    case "2":
                                        Stcolor($"~y{player.skill2}~w을(를) 사용합니다.",2);
                                        player.Nowmp -= skillmana(player, chanact);
                                        roop = false;
                                        break;
                                }
                            }
                            else
                            {
                                Stcolor("스킬 사용에 필요한 ~b마나가 부족합니다.",2);
                            }
                        }
                        else if (act == "3")
                        {
                            Stcolor("뒤로 돌아갑니다.",2);
                            break;
                        }
                        else
                        {
                            Stcolor("올바른 값을 선택해주세요.",2);
                        }
                    }

                    switch (act)
                    {
                        case "1":
                        case "2":
                            mepower = skill(player, chanact) - enemy.Def;
                            mecrit = player.CritAttack(skill(player, chanact)) - enemy.Def;
                            if (mepower < 0)
                            {
                                mepower = 0;
                            }
                            if (mecrit < 0)
                            {
                                mecrit = 0;
                            }
                            switch (act)
                            {
                                case "1":
                                    Stcolor($"~g{player.Name}의 ~y{player.skill1} ~w공격!",2,500);
                                    break;
                                case "2":
                                    Stcolor($"~g{player.Name}의 ~y{player.skill2} ~w공격!",2,500);
                                    break;
                            }
                            Console.WriteLine();
                            if (enemy.Chan() < 15)
                            {
                                Stcolor($"~g{enemy.Name}~w은(는) 공격을 회피했다!", 1,0);
                                Stcolor("---------------------", 2, 500);
                            } //15%확률로 회피성공//
                            else
                            {
                                if (mecrit == mepower)
                                {
                                    Stcolor($"~r{enemy.Name}~w은(는) ~r{mepower}~w만큼의 데미지를 받았다!", 2, 500);
                                    enemy.Nowhp -= mepower;
                                    player.nuSDamage += mepower;
                                }
                                else
                                {
                                    Stcolor("효과가 굉장했다!", 1, 500);
                                    Stcolor($"{enemy.Name}~w은(는) ~r{mecrit}~w만큼의 데미지를 받았다!", 2, 500);
                                    enemy.Nowhp -= mecrit;
                                    player.nuSDamage += mecrit;
                                }

                            } //회피실패


                            if (enemy.Nowhp < 1)
                            {
                                enemy.Nowhp = 0;
                                Stcolor($"~r{enemy.Name}~w의 남은 체력은 ~r{enemy.Nowhp}~w이(가) 되었다.", 1, 0);
                                Stcolor("---------------------", 2, 500);
                                break;
                            }//적 처치시 반격안함//
                            else
                            {
                                int youpower = 0;
                                int youcrit = 0;
                                youpower = enemy.Att - player.Def;
                                youcrit = enemy.CritAttack(enemy.Att) - player.Def;
                                if (youpower < 0)
                                {
                                    youpower = 0;
                                }
                                if (youcrit < 0)
                                {
                                    youcrit = 0;
                                }
                                Stcolor($"~r{enemy.Name}~w은(는) ~y반격~w했다.", 2, 500);

                                if (player.Chan() < 15)
                                {
                                    Stcolor($"~g{player.Name}~w은(는) 공격을 ~y회피~w했다!", 1,0);
                                    Stcolor("---------------------", 2, 500);
                                }
                                else
                                {
                                    if (youcrit == youpower)
                                    {
                                        Stcolor($"~g{player.Name}~w은(는) ~r{youpower}~w만큼의 데미지를 받았다!", 1, 500);
                                        player.Nowhp -= youpower;
                                        player.nuHp += youpower;
                                    }
                                    else
                                    {
                                        Stcolor("효과가 굉장했다!", 1, 500);
                                        Stcolor($"~g{player.Name}~w은(는) ~r{youcrit}~w만큼의 데미지를 받았다!", 1, 500);
                                        player.Nowhp -= youcrit;
                                        player.nuHp += youcrit;
                                    }
                                    Stcolor("---------------------", 2, 500);

                                    if (player.Nowhp < 1)
                                    {
                                        break;
                                    }
                                }
                            } //적 처치시 실패시 반격//
                            break;
                    }
                }
                else if (selList == "3")
                {
                    int counter = 0;
                    int power = enemy.Att - (player.Def * 2);
                    if (power < 0)
                    {
                        power = 0;
                    }
                    Stcolor($"~g{player.Name}~w이(가) 방어을(를) 사용했다!", 1, 500);
                    Stcolor($"~g{player.Name}~w은(는) ~r{power}~w만큼의 데미지를 받았다!", 1, 0);
                    Stcolor("---------------------", 2, 500);
                    player.Nowhp -= power;
                    player.nuHp += power;

                    if (player.Nowhp < 1)
                    {
                        break;
                    }
                    if (player.Chan() < 30)
                    {
                        Stcolor($"~g{player.Name}~w이(가) 반격을 시도했다!", 1);
                        if (enemy.Chan() < 10)
                        {
                            Stcolor($"~g{enemy.Name}~w은(는) 공격을 회피했다.", 1,0);
                            Stcolor("---------------------", 2, 500);
                        }
                        else
                        {
                            counter = player.Att - enemy.Def;
                            if (counter < 0)
                            {
                                counter = 0;
                            }
                            enemy.Nowhp -= counter;
                            player.nuDamage += counter;
                            Stcolor($"~g{enemy.Name}~w은(는) ~r{counter}~w만큼의 데미지를 받았다!", 1);
                            if (enemy.Nowhp < 1)
                            {
                                enemy.Nowhp = 0;
                                Stcolor($"{enemy.Name}의 남은 체력은 {enemy.Nowhp}이(가) 되었다.", 1, 0);
                                Stcolor("---------------------", 2, 500);
                                break;
                            }//적 처치시 반격안함//

                        }
                    }
                }
                else if (selList == "4")
                {
                    if(enemy.esc == 2)
                    {
                        Stcolor($"보스몬스터로부터는 도망칠 수 없습니다.",1,0);
                        Stcolor("---------------------", 2, 500);
                    }
                    else
                    {
                        Stcolor($"~g{player.Name}~w이(가) 도주을(를) 사용했다!", 2, 500);
                        if (player.Chan() < 30)
                        {
                            Stcolor("도주에 실패했다.", 1);
                            Stcolor($"{player.Name}은(는) {enemy.Att}만큼의 데미지를 받았다!", 1,0);
                            Stcolor("---------------------", 2, 500);
                            player.Nowhp -= enemy.Att;
                            player.nuHp += enemy.Att;
                        }
                        else
                        {
                            player.esc = 1;
                            Stcolor($"{player.Name}은(는) 도주에 성공했다!", 1, 0);
                            Stcolor("---------------------", 2, 500);
                            break;
                        }
                    }
                }
                else
                {
                    Stcolor("올바른 선택을 해주세요", 1, 0);
                    Stcolor("---------------------", 2);
                }
                
            }
        }

        public static void Battle(Unit player, Unit enemy)//전투로직// 
        {
            Stcolor($"~r{enemy.Name}~w을(를) 만났다.",2);
            enemy.chanDef();
            enemy.chanPower();
            Stcolor("[ 전투시작! ]",2,0);
            Stcolor("---------------------",2);
            for (enemy.Nowhp = enemy.Maxhp; enemy.Nowhp > 0;)
            {
                BattleAtt(player, enemy);
                if (player.esc == 1)
                {
                    break;
                }

                if (player.Nowhp < 1)
                {
                    break;
                }
            }
        }

        public static void Field(Unit player, Unit enemy, string a)
        {
            int bosscount = 0;
            bool start = true;
            int count = 0;
            if (a == "1")
            {
                while (start == true)
                {
                    Stcolor("현재 필드 : ~g울창한 숲", 2, 0);
                    Battleform(player);
                    string select = Console.ReadLine();
                    if (select == "1")
                    {
                        Wolf1 wolf1 = new Wolf1();
                        Wolf2 wolf2 = new Wolf2();
                        Wolf3 wolf3 = new Wolf3();

                        List<Unit> enemies = new List<Unit>();

                        enemies.Add(wolf1);
                        enemies.Add(wolf2);
                        enemies.Add(wolf3);

                        Random rnd = new Random();

                        int meet = rnd.Next(enemies.Count);

                        enemy = enemies[meet];

                        Battle(player, enemy);
                        if (player.Nowhp < 1)
                        {
                            Stcolor($"~g{player.Name}~w의 체력이 0이(가) 되습니ㄷ다.", 3);
                            Stcolor("~r[ G.A.M.E.O.V.E.R ]~w", 3);
                            start = false;
                            break;
                        }
                        if (player.esc == 1)
                        {
                            player.esc = 0;
                            count = 0;
                        }
                        else
                        {
                            Stcolor($"~r{enemy.Name}~w이(가) 쓰려졌다!", 1);
                            Stcolor($"~g{player.Name}~w은(는) ~y{enemy.Exp}~w의 경험치를 얻었다.", 2);
                            player.Exp = player.Exp + enemy.Exp+50;
                            levelup(player);
                            Stcolor("---------------------", 2);
                            classup(ref player);
                            count = 0;
                            player.totalmob++;
                        }
                    }
                    else if (select == "2")
                    {
                        if (count == 0)
                        {
                            player.Nowhp = player.Nowhp + 100;
                            player.Nowmp = player.Nowmp + 200;

                            if (player.Nowhp > player.Maxhp)
                            {
                                player.Nowhp = player.Maxhp;
                            }

                            if (player.Nowmp > player.Maxmp)
                            {
                                player.Nowmp = player.Maxmp;
                            }
                            count++;
                            Stcolor("휴식으로 체력과 마나를 회복했습니다..", 2);
                        }
                        else
                        {
                            Stcolor("충분히 휴식한 것 같다.", 2);
                        }
                    }
                    else if (select == "3")
                    {
                        Statplayer(player);
                    }
                    else if (select == "4")
                    {
                        if(bosscount == 0)
                        {
                            Wolfboss wolfboss = new Wolfboss();
                            Battle(player, wolfboss);
                            if (player.Nowhp < 1)
                            {
                                Stcolor($"~g{player.Name}~w님의 체력이 0이(가) 되었습니다.", 3);
                                Stcolor("~r[ G.A.M.E.O.V.E.R ]", 3);
                                start = false;
                                break;
                            }
                            else
                            {
                                Stcolor($"클리어를 축하드립니다!", 3, 1500);
                                bosscount++;
                                Stcolor($"플레이어 : ~g{player.Name}", 2, 1000);
                                Stcolor($"잡은 몬스터 수 : {player.totalmob}", 2, 1000);
                                Stcolor($"입힌 일반공격 피해량 : {player.nuDamage}", 2, 1000);
                                Stcolor($"입힌 스킬공격 피해량 : {player.nuSDamage}", 2, 1000);
                                Stcolor($"입힌 총 피해량 : " + player.nuDamage + player.nuSDamage, 2, 1000);
                                Stcolor("플레이 해주셔서 감사합니다.", 2, 1000);
                                break;
                            }
                        }
                        else
                        {
                            Stcolor($"『 웨어울프 』가 있던 장소다.", 2);
                            Stcolor($"웨어울프가 사라진 지금은 전투의 흔적만 남아있다.", 2);
                        }
                        count = 0;
                    }
                    else
                    {
                        Stcolor("올바른 선택지를 골라주세요.", 2);
                    }
                }
            }
            

        }
    }
}
