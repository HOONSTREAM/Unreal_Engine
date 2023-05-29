﻿using System.Collections;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Csharp_practice
{

    enum Choice_symbol {
        Rock = 1,
        Scissors = 0,
        Paper=2 
    }
    class Program
    {
        static void Main(string[] args)
        {
         
            // 0 : 가위 , 1 : 바위 , 2 : 보 

            Random rand = new Random();
            int aichoice = rand.Next(0, 3); // aichoice 변수에 난수 생성 0~2 까지


            Console.WriteLine(" 0 : 가위 , 1 : 바위, 2 : 보 입니다." );
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            Console.WriteLine("내고싶은 것을 숫자로 입력하세요 :  ");
            int choice = Convert.ToInt32(Console.ReadLine()); //사용자가 낼 것을 숫자로 입력받음



            switch (choice)
            {

                case (int)Choice_symbol.Scissors:
                    Console.WriteLine("당신의 선택은 가위 입니다.");

                    break;
                case (int)Choice_symbol.Rock:
                    Console.WriteLine("당신의 선택은 바위 입니다.");
                    break;
                case (int)Choice_symbol.Paper:
                    Console.WriteLine("당신의 선택은 보 입니다.");
                    break;
            }


            Console.WriteLine("=================================");
            Console.WriteLine("=================================");
            


            switch (aichoice)
            {

                case (int)Choice_symbol.Scissors:
                    Console.WriteLine("컴퓨터의 선택은 가위 입니다.");

                    break;
                case (int)Choice_symbol.Rock:
                    Console.WriteLine("컴퓨터의 선택은 바위 입니다.");
                    break;
                case (int)Choice_symbol.Paper:
                    Console.WriteLine("컴퓨터의 선택은 보 입니다.");
                    break;

            }
            Console.WriteLine("=================================");
            Console.WriteLine("=================================");

            //컴퓨터의 난수와 사용자의 지정 수를 통해 최종 비교연산을 통한 승부 

            if (choice == (int)Choice_symbol.Scissors)
            {
                bool Draw = (aichoice == choice) ? true : false;

                if (Draw)
                    Console.WriteLine("비겼습니다.");
                else if (aichoice == (int)Choice_symbol.Rock)
                    Console.WriteLine("당신이 졌습니다.");
                else
                    Console.WriteLine("당신이 이겼습니다 ! ");

            }

            else if (choice == (int)Choice_symbol.Rock)
            {
                bool Draw = (aichoice == choice) ? true : false;

                if (Draw)
                    Console.WriteLine("비겼습니다.");
                else if (aichoice == (int)Choice_symbol.Scissors)
                    Console.WriteLine("당신이 이겼습니다 !");
                else
                    Console.WriteLine("당신이 졌습니다. ");

            }

            else
            {

                bool Draw = (aichoice == choice) ? true : false;

                if (Draw)
                    Console.WriteLine("비겼습니다.");
                else if (aichoice == (int)Choice_symbol.Scissors)
                    Console.WriteLine("당신이 졌습니다.");
                else
                    Console.WriteLine("당신이 이겼습니다. ");



            }



        }










        }
    }
