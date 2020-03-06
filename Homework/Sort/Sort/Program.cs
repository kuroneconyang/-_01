using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            bool Start = true;
            while(Start == true)
            {
                    string form = null;
                    int chaform = 0;
                    int[] array = new int[0];
                    while (Start == true)
                    {
                        Console.Write("원하는 배열의 크기를 입력해주세요 : ");
                        form = Console.ReadLine();
                        if (Choose(form) == true)
                        {
                            chaform = int.Parse(form);
                            if (chaform > 0)
                            {
                                array = new int[chaform];
                                break;
                            }
                            else
                                Console.WriteLine("0보다 큰 수를 입력해주세요.");
                        }
                        else
                        {
                            Console.WriteLine("올바르지 않은 값입니다.");

                        }
                    } //여기까지 배열크기//
                    Console.WriteLine("---------------------------------");

                    for (int a = 0; a < array.Length; a++)
                    {
                        while (Start == true)
                        {
                            Console.Write("숫자를 입력해주세요. : ");
                            string inputcount = Console.ReadLine();
                            if (Choose(inputcount) == true)
                            {
                                array[a] = int.Parse(inputcount);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("올바른 숫자를 입력해주세요.");
                            }
                        }
                    }
                    Console.Write("총 입력하신 수는 ");
                    for (int c = 0; c < array.Length; c++)
                    {
                        Console.Write($"[{array[c]}] ");
                    }
                    Console.WriteLine("입니다.");


                    int[] sorta = Sort(array);
                    Console.Write("오름차순으로 정렬된 숫자는 : ");
                    for (int a = 0; a < array.Length; a++)
                    {
                        Console.Write($"[{sorta[a]}]");
                    }
                    Console.WriteLine("입니다.");

                    int[] sortb = new int[chaform];
                    int input2 = chaform;
                    Console.Write("내림차순으로 정렬된 숫자는 : ");
                    for (int b = 0; b < array.Length; b++)
                    {
                        input2--;
                        sortb[b] = sorta[input2];
                        Console.Write($"[{sortb[b]}]");
                    }
                    Console.WriteLine("입니다.");
                    Console.WriteLine();

                while (Start == true)
                    {
                    Console.WriteLine("다시 실행하시겠습니까? Y / N");
                    string re1 = Console.ReadLine();
                    char re1_ = re1.ToCharArray()[0];

                    if (re1_ == 'Y' || re1_ == 'y')
                    {
                        Start = true;
                        Console.WriteLine();
                        break;
                    }
                    else if (re1_ == 'N' || re1_ == 'n')
                    {
                        Start = false;
                        Console.WriteLine();
                        break;
                    }
                    else
                        Console.WriteLine("Y 혹은 N만 입력해주세요");
                    }
                    //Console.Write("내림차순으로 정렬된 숫자는 : ");  배열을 끝번호부터 출력하면 내림차순인데 이렇게는 안쓰는가?
                    //for (int a = input - 1; a >= 0; a--)
                    //{
                    //    Console.Write($"[{sorta[a]}]");
                    //}
                    //Console.WriteLine("입니다.");

            }
        }

        static int[] Sort(int[] array)
        {
            int[] output = new int[array.Length];
            for (int a = 0 ;a<array.Length ;a++) 
            {
                int count = 0;
                for(int b= 0; b<array.Length;b++)
                {
                    if (array[a] > array[b])
                    {
                        count++;
                    }
                }

                if (output[count] != 0 && output[count] == array[a])
                {
                    while (output[count] == array[a])
                    {
                        count++;
                    }
                    output[count] = array[a];
                }
                else
                    output[count] = array[a];
                
            }
            return output;
        }

        static bool Choose(string str)
        {
            bool input = true; //기본은 숫자//
            try
            {
                int i = int.Parse(str);
            }
            catch
            {
                input = false; //안되면 문자//
            }


            return input ;
        }
    }
}
