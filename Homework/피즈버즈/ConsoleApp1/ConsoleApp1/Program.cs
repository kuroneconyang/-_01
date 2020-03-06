using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("나와라! 피즈버즈!");
            Console.WriteLine("범위 : 1~100");
            Console.WriteLine("조건 1 : 3의 배수는 피즈?");
            Console.WriteLine("조건 2 : 5의 배수는 버즈!");
            Console.WriteLine("조건 3 : 3과 5의 공배수는 피즈버즈?!");

            for (int Count = 1; Count < 101; Count++)
            {
                if (Count % 3 == 0 && Count % 5 == 0)
                {
                    Console.WriteLine("{0} 피즈버즈?!", Count);
                }
                else if (Count % 3 == 0)
                {
                    Console.WriteLine("{0} 피즈?", Count);
                }
                else if (Count % 5 == 0)
                {
                    Console.WriteLine("{0} 버즈!", Count);
                }
                else
                    Console.WriteLine("{0}", Count);
            }
        }
    }
}
