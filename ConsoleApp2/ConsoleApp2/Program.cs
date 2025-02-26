﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//1차원 배열로 만든 빙고
             int[] iArray = new int[25];


            for (int i = 0; i < 25; i++)
            {
                iArray[i] = i + 1;
            }



            Random rand = new Random();
            //셔플
            for (int i = 0; i < 100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int iT = 0;


                iT = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = iT;
            }

            int input = 0;
            int iBingo = 0;
            int iCount = 0;

            while (true)
            {
                Console.Clear();
                
                //빙고판
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {

                        if (iArray[i * 5 + j] == 0)  //0일경우 체크
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write(iArray[i * 5 + j].ToString("D2") + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("빙고 " + iBingo);
                Console.WriteLine("숫자를 입력하세요: ");
                Console.WriteLine("숫자를 입력하세요: ");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;
                for (int i = 0; i < 25; i++)
                {
                    if (iArray[i] == input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }
                //빙고 체크 로직
                //가로체크
                for(int i = 0; i < 5; i++)
                {
                    for(int j = 0; j<5; j++)
                    {
                        if (iArray[i *5 +j] == 0)
                        {
                            ++iCount;
                        }
                        if(iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }
                //세로체크
                for (int i = 0; i<5; i++)
                {
                    for(int j = 0; j<5; j++)
                    {
                        if (iArray[i+5*j] == 0)
                        {
                            ++iCount;
                        }
                        if(iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }
                
                //대각선 오른쪽체크
                for (int i= 0; i <5; i++)
                {
                    if (iArray[i*4+4] == 0)
                    {
                        ++iCount;
                    }
                    if(iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;
                for (int i = 0; i < 5; i++)
                {
                    if (iArray[i * 6] == 0)
                    {
                        ++iCount;
                    }
                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;
                if(iBingo >= 5)
                {
                    Console.WriteLine("빙고 성공");
                    break;
                }
            }*/
            /*//2차원 배열로 만든 빙고
            int[,] board = new int[5, 5];
            bool[,] marked = new bool[5, 5];
            int bingoCount = 0;
            Random random = new Random();
            int[] numbers = new int[25];
            for (int i = 0; i < 25; i++)
            {
                numbers[i] = i + 1;
            }
            //랜덤섞기(Fissher=Yates Shuffle)
            for(int i=0; i<100; i++)
            {
                int a = random.Next(25);
                int b = random.Next(25);
                //C#방식 튜플문법으로 두변수값 교환
                (numbers[a], numbers[b]) = (numbers[b], numbers[a]);
            }
            //2차원 배열로 변환
            int index = 0;
            for(int i =0; i<5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    board[i, j] = numbers[index++];
                }
            }
            //게임시작
            while (bingoCount < 5)
            {
                Console.Clear();
                //빙고판 출력
                Console.WriteLine("현재 빙고판");

                for(int i = 0; i<5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (marked[i, j])
                            Console.Write(" X ");
                        else
                            Console.Write($"{board[i, j],2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고 개수 : {bingoCount}");
                Console.Write("숫자를 입려가세요 (1~25) : ");
                int number = int.Parse(Console.ReadLine());
                bool found = false;
                for(int i = 0; i<5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (board[i, j] == number)
                        {
                            marked[i, j] = true;
                            found = true;
                            break;
                        }
                    }
                    if (found) break;
                }
                bingoCount = 0;
                //가로체크
                for (int i = 0; i < 5; i++)
                {
                    bool rowBingo = true;
                    for (int j = 0; j < 5; j++)
                    {
                        if (!marked[i, j]) rowBingo = false;
                    }
                    if (rowBingo) bingoCount++;
                }
                //세로체크
                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;
                    for (int i = 0; i < 5; i++)
                    {
                        if (!marked[i, j]) colBingo = false;

                    }
                    if (colBingo) bingoCount++;
                }
                //대각선체크(왼쪽 위-> 오른쪽 아래)
                bool diag1Bingo = true;
                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, i]) diag1Bingo = false;
                }
                if (diag1Bingo) bingoCount++;
                //대각선 오른쪽 위->왼쪽 아래
                bool diag2Bingo = true;
                for (int i = 0; i < 5; i++)
                {
                    if (!marked[i, 4 - i]) diag2Bingo = false;
                }
                if (diag2Bingo) bingoCount++;
            }
            Console.WriteLine("빙고 5개 완성! 게임종료");*/

        }
    }
}

/*                if(int.TryParse(Console.ReadLine(),out int number))//else사용하여 예외처리가능
                {

                }*/