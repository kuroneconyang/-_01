using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("신나는 별짜기 시간!");
            Console.WriteLine("만들고싶은 모양을 선택해주세요");
            Console.WriteLine("1번 : 아래가 큰 삼각형");
            Console.WriteLine("2번 : 위가 큰 삼각형");
            Console.WriteLine("3번 : 나비넥타이모양");
            int Choo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");

            if (Choo == 1)
            {
                Console.WriteLine("삼각형의 가장 아래 크기를 정해주세요");
                Console.WriteLine("단! 홀수만");
                Console.Write("크기 : ");
                int Aone = Convert.ToInt32(Console.ReadLine());

                if (Aone % 2 == 0)
                {
                    Console.WriteLine("짝수 노노해");
                }
                else
                    for (int Alow = 0; Alow < Aone; Alow += 2)
                    {
                        for (int Aspa = 0; Aspa < (Aone - Alow) / 2; Aspa++)
                        {
                            Console.Write(" ");
                        }
                        for (int Atri = 0; Atri < Alow + 1; Atri++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                }
            }

            else if (Choo == 2)
            {
                Console.WriteLine("삼각형의 가장 위의 크기를 정해주세요");
                Console.WriteLine("단! 홀수만");
                Console.Write("크기 : ");
                int Bone = Convert.ToInt32(Console.ReadLine());

                if (Bone % 2 == 0)
                {
                    Console.WriteLine("짝수 노노해");
                }
                else
                    for (int Blow = Bone; Blow > 0; Blow -= 2)
                {
                    for (int Bspa = 0; Bspa < (Bone - Blow) / 2; Bspa++)
                    {
                        Console.Write(" ");
                    }
                    for (int Btri = 0; Btri < Blow; Btri++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            else if (Choo == 3)
            {
                Console.WriteLine("넥타이 가운데의 크기를 정해주세요");
                Console.Write("크기 : ");
                int Cone = Convert.ToInt32(Console.ReadLine());

                for (int Clow = 0; Clow < Cone; Clow++)
                {
                    for (int Ctri = 0; Ctri < Clow + 1; Ctri++)
                    {
                        Console.Write("*");
                    }
                    for (int Cspa = 0; Cspa < (Cone - Clow - 1) * 2; Cspa++)
                    {
                        Console.Write(" ");
                    }
                    for (int Ctri = 0; Ctri < Clow + 1; Ctri++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int Crevlow = Cone - 1; Crevlow > 0; Crevlow--)
                {
                    for (int Crevtri = 0; Crevtri < Crevlow; Crevtri++)
                    {
                        Console.Write("*");
                    }
                    for (int Cspa = 0; Cspa < (Cone - Crevlow) * 2; Cspa++)
                    {
                        Console.Write(" ");
                    }
                    for (int Crevtri = 0; Crevtri < Crevlow; Crevtri++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("이상한거 고르지마요...");
        }
    }
}
