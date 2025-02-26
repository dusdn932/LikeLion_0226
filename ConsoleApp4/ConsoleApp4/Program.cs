using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static int sum1(int a, int b)
        {
            return a + b;
        }
        static int change(string words)
        {
            return words.Length;
        }
        static int max(int a, int b, int c)
        {
            int max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=======1번문제========");
            int[] num1 = new int[5]{ 10, 20, 30, 40, 50 };
            for(int i=0; i <num1.Length; i++)
            {
                Console.WriteLine(num1[i]);
            }
            Console.WriteLine("=======2번문제========");

            int[] num2 = new int[5];
            int result = 0;
            for (int i = 0; i < num2.Length; i++)
            {
                num2[i] = int.Parse(Console.ReadLine());
                result += num2[i];
            }
            Console.WriteLine("배열 모든 수의 합 :" + result);

            Console.WriteLine("=======3번문제========");
            int[] num3 = new int[5] { 3, 8, 15, 6, 2 };
            int max1 = 0;
            for (int i = 0; i < num3.Length; i++)
            {
                if (max1 < num3[i]) max1 = num3[i];
            }
            Console.WriteLine("배열 3, 8, 15, 6, 2 중 최댓값 :" + max1);
            Console.WriteLine("=======4번문제========");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("=======5번문제========");
            int inum = 1;
            while (inum <= 10)
            {
                if (inum % 2 == 0) Console.WriteLine(inum);
                inum++;
            }
            Console.WriteLine("=======6번문제========");
            int[] nums = { 1, 2, 3, 4, 5 };
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("=======7번문제========");
            int result1 = 0;
            result1 = sum1(3, 5);
            Console.WriteLine("3과 5의 합 : " + result1);


            Console.WriteLine("=======8번문제========");
            string word = Console.ReadLine();
            Console.WriteLine("글자 수 : " + change(word));



            Console.WriteLine("=======9번문제========");
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine(a +" "+ b+ " " + c + "중에서 가장 큰 수는 " + max(a, b, c));

        }
        
    }
}
