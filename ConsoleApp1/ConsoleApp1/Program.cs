using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //배열
            //0번부터 시작

            /*int[] num = new int[3];//3개의 메모리 생성
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;

            Console.WriteLine(num[0]);
            Console.WriteLine(num[1]);
            Console.WriteLine(num[2]);
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine(num[i]);
            }*/

            /*int[] numbers = { 1, 2, 3 };//간단한 선언과 초기화
            int[] numbers2 = new int[3]; //크기만 지정
            int[] numbers3 = new int[] { 1, 2, 3 }; //초기화와 함께 선언

            for(int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            string[] fruits = { "사과", "바나나", "오렌지" };
            for(int i = 0; i<fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }*/


            //3명의 국어, 영어, 수학 점수
            //총점과 평균 출력
            /*string[] name = new string[3];
            int[] iKor = new int[3];
            int[] iEng = new int[3];
            int[] iMath = new int[3];
            int[] sum = new int[3];
            float[] avg = new float[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("학생 이름 : ");
                name[i] = Console.ReadLine();
                Console.Write("국어 : ");
                iKor[i] = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                iEng[i] = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                iMath[i] = int.Parse(Console.ReadLine());


                sum[i] += iKor[i] + iEng[i] + iMath[i];
                avg[i] = sum[i] / 3;
            }
            for(int i=0; i<3; i++)
            {
                Console.WriteLine(name[i]);
                Console.WriteLine($"국어 : {iKor[i]} 영어 : {iEng[i]} 수학 : {iMath[i]}");
                Console.WriteLine("총점 :" + sum[i]);
                Console.WriteLine("평균 :" + avg[i].ToString("F2"));
            }*/
            //1차원 배열
            /*int[] scores = new int[3];
            scores[0] = 90;
            scores[1] = 85;
            scores[2] = 88;
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"점수 {i + 1}:{scores[i]}");
            }*/
            //포멧

            /*double value = 123.456789;
            Console.WriteLine(value.ToString("F2"));
            Console.WriteLine($"소수점 둘째자리 : {value:F2}");
            Console.WriteLine(String.Format("소수점 둘째 자리 : {0:F2}", value));
            //소수점 없이 정수 출력
            Console.WriteLine(value.ToString("F0"));*/

            //천자리마다 쉼표
            /*double value = 124423512351.12314;
            Console.WriteLine(value.ToString("N2"));*/

            //2차원 배열
            /*int[,] matrix = new int[2, 3]{{ 1, 2, 3 }, { 4, 5, 6 }};
            for (int i = 0; i < 2; i++)
            {
                for (int j= 0; j<3; j++)
                {
                    Console.WriteLine($"{matrix[i, j]}");
                }
            }*/
            /*int[][] matrix = new int[2][];
            matrix[0] = new int[3];
            matrix[1] = new int[3];

            matrix[0][0] = 1;
            matrix[0][1] = 2;
            matrix[0][2] = 3;
            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;

            for(int i = 0; i<matrix.Length; i++)
            {
                for(int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }Console.WriteLine();
            }*/

            /*Console.WriteLine("가변 배열");
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5 };
            jaggedArray[2] = new int[] { 6};
            for(int i=0; i<jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }*/
            /*Console.WriteLine("var 키워드 사용");
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"배열 타입 : {numbers.GetType()}");*/

        }
    }
}
