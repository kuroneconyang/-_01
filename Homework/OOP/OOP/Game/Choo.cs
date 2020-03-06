using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOP.Game
{
    class Choo
    {
        /// <summary>
        /// 한글인지 확인
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool Try(string a)
        {
            bool math = true;
            try
            {
                int i = int.Parse(a);
            }
            catch
            {
                math = false;
            }
            return math;
        }
       
        
        /// <summary>
        /// 대화,슬립
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void St(string a, int b = 1000)
        {
            Console.WriteLine(a);
            Thread.Sleep(b);
        }

        /// <summary>
        /// 색넣기
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        //public static void stcolor(string a, int b = 1000)
        //{
        //    char[] c = a.ToCharArray();
        //    for (int i = 0 ; i < c.Length ; i++)
        //    {
        //        if(i == c.Length)
        //        {
        //            break;
        //        }
        //        else if(i < c.Length)
        //        {
        //            if (c[i] == '~')
        //            {
        //                if (c[i + 1] == 'g')
        //                {
        //                    //if (c[i + 2] == 'n')
        //                    //{
        //                    //    Console.ForegroundColor = ConsoleColor.Green;
        //                    //}
        //                }

        //                else if (c[i + 1] == 'r')
        //                {
        //                    //if (c[i + 2] == 'd')
        //                    //{
        //                    //    Console.ForegroundColor = ConsoleColor.Red;
        //                    //}
        //                }

        //                else if (c[i + 1] == 'y')
        //                {
        //                    //if (c[i + 2] == 'w')
        //                    //{
        //                    //    Console.ForegroundColor = ConsoleColor.Red;
        //                    //}
        //                }

        //                else
        //                {
        //                    Console.ForegroundColor = ConsoleColor.White;
        //                }
        //            }
        //        }

        //        Console.Write(c[i]);
        //    }
        //    Console.WriteLine();
        //    Thread.Sleep(b);
        //}

        public static void Stcolor(string str, int n, int m = 500)
        {
            char[] text = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                if (text[i] == '~')
                {
                    bool a = true;

                    if(i != str.Length - 1)
                    {
                        if (text[i + 1] == 'g')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (text[i + 1] == 'r')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (text[i + 1] == 'y')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (text[i + 1] == 'w')
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (text[i + 1] == 'b')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else
                        {
                            a = false;
                        }
                        if (a == true)
                        {
                            i += 2;
                        }
                    }
                }
                else
                {
                }
                Console.Write(text[i]);

            }
            Console.ForegroundColor = ConsoleColor.White;
            if (n > 0)
            {
                for(int i = 0; i < n; i++ )
                {
                    Console.WriteLine();
                }
            }
            Thread.Sleep(m);
        } //문자,줄바꿈,쓰레드//
    }  
}
