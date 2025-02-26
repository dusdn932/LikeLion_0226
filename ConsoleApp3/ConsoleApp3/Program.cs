using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        //메모리영역
        //스택(stack)
        //힙(heap)
        //정적메모리(static memory)
        //1단계 호출
        static void Loding()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
            Console.Clear();
        }
        //2단계 입력
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력은 : "+ _Attack);
        }
        //3단계 출력
        static int BaseAttack()
        {
            int attack = 10;
            return attack;
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //반복문
            string[] fruits = { "사과", "바나나", "체리" };
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            /*int result = Add(10, 20);
            Console.WriteLine($"10 + 20 = {result}");*/
        /*int Attack = 0;
            int bAttack = 0;
            Console.WriteLine("캐릭터의 공격력을 입력 : ");
            Attack = int.Parse(Console.ReadLine());
            //기본 공격력
            bAttack=BaseAttack();
            Console.WriteLine("기본공격력 : "+bAttack);
            AttackFunction(Attack+bAttack);*/
        }
        

    }
}
