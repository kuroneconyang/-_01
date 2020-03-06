using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OOP.Units;
using OOP.Units.Players;
using static OOP.Game.Element;
using static OOP.Game.Choo;

namespace OOP.Game
{
    class Story
    {


        public static void Login(Unit player)

        {
            bool Start = true;
            while (Start == true)
            {
                Stcolor("~w------------------------------",1,0);
                Stcolor("~w주인공의 정보를 입력해주세요",2,0);
                Stcolor("~w이름 : ",0,0);
               
                player.Name = Console.ReadLine();
                Statlog(player);
                while (Start == true)
                {
                    Stcolor("~w결정하시겠습니까?",1,500);
                    Stcolor("~w[ Y / N ] : ",0,0);
                    string re = Console.ReadLine();
                    char re1 = re.ToCharArray()[0];
                    if (re1 == 'Y' || re1 == 'y')
                    {
                        Start = false;
                        Console.WriteLine();
                        break;
                    }
                    else if (re1 == 'N' || re1 == 'n')
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Stcolor("Y 혹은 N을 입력해주세요",2,0);
                    }
                }
            }
            Thread.Sleep(1000);
        } //처음 플레이어 이름 설정//

        public static void Open(Unit player)
        {
            Stcolor("~g『 게임에 관련하여 안내를 시작합니다. 』", 2, 2000);
            Stcolor($"~g[ {player.Name} ]~w님 환영합니다. 본 게임은 ~r선택지를 고르시는 방식~w으로 플레이됩니다.",1,2000);
            Stcolor("~w현재 ~y[ 얼리억세스 ] ~w단계이며, 울창한 숲의 보스몬스터인 ~r『 웨어울프 』~w를 처치 혹은 ~r체력이 0이 될 경우~w 게임이 종료됩니다.",1,2000);
            Stcolor("~w보스를 처치하기 위한 성장은 ~g일반몬스터 사냥~w을 통해 가능하며, ~r[ 3레벨 ]~w 이 되면 직업변경을 할 수 있습니다.",1,2000);
            Stcolor("그럼, 즐거운 시간되시길 바라겠습니다.",2,3000);
        } //시작//

        public static void Epi_1(Unit player)//에피소드1// 
        {
            Stcolor(".",1,700);
            Stcolor(".", 1, 700);
            Stcolor(".", 1, 1000);
            Stcolor("~w【 눈을 떴을 때 가장 먼저 보인 것은 ~r울창한 숲~w이었다. 】", 1,1500);
            Stcolor("~w【 아무리 둘러보아도 사방에는 온통 푸른 나무들만이 가득했다. 】", 2, 1500);
            Stcolor("~w [ 아우-! ]", 2, 2000);
            Stcolor("~w【 차가운 바람이 순간적으로 등 뒤에서 불어왔다. 】", 1, 1500);
            Stcolor("~w【 적막을 깨는 ~r늑대~w의 울음소리가 나무들 틈 사이로 날카롭게 들려왔다. 】", 1, 1500);
            Stcolor("~w【 그리고, 조금씩 나는 피 비린내가 코 끝을 자극하기 시작했다. 】 ", 1, 1500);
            Stcolor("~w【 마른 침을 삼켰다. 】 ", 1, 1500);
            Stcolor("~w【 정신을 차릴 틈도 없이 본능적으로 몸을 움츠렸다. 】 ", 1, 1500);
            Stcolor("~w【 그리고, 허리춤에 있는 ~y작은 단검~w 손잡이를 잡았다. 】 ", 1, 1500);
            Stcolor("~w【 왜 이곳에 있던 것인지, 그 의문을 해결하기 위해서는 일단 ~g살아남아야~w할 것 같다. 】 ", 5, 1500);
            //싸움//
        }
    }
}

