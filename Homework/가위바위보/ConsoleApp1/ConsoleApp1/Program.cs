using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rnd = new Random();
            int you = Rnd.Next(1, 4);

            Console.WriteLine("가위 바위 보!");
            String me = Convert.ToString(Console.ReadLine());
            string your = Convert.ToString(you == 1 ? "가위" : you == 2 ? "바위" : "보");

            Console.WriteLine("나는 {0}",me);
            Console.WriteLine("컴퓨터는 {0}", your);
            Console.WriteLine("----------");
            if (me == your)
            {
                Console.WriteLine("비겼다!");
            }
            else if (me == "가위" && your == "보" || me=="바위" && your=="가위" || me=="보" && your=="바위")
            {
                Console.WriteLine("이겼다!");
            }
           else
            {
                Console.WriteLine("졌다!");
            }

        }
    }
}
