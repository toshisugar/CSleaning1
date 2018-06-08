using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            // Linqであそぼう
            var data1 = Enumerable.Range(0, 10).Select(_ => r.Next(0, 100)).ToList();  //
            Console.WriteLine("元データ");
            Output(data1);

            Console.WriteLine("２倍する");
            Output(data1.Select(a => a * 2));

            Console.WriteLine("2乗する");
            Output(data1.Select(a => a * a));

            Console.WriteLine("50未満を返す");
            Output(data1.Where(t => t < 50));

            Console.WriteLine("偶数だけを2倍して");
            Output(data1.Where(t => t % 2 == 0).Select(t => t * 2));

            Console.WriteLine("偶数だけを2倍して、全ての値を奇数にする");
            Output(data1.Where(t => t % 2 == 0).Select(t => t * 2).Select(t => t + 1));



            //Console.WriteLine("偶数だけを抽出して、最大値を求める");

            //Console.WriteLine(data1.Where(t => t % 2 == 0).Max());



            //int Add(int n)
            //{
            //    return n + 5;  //引数に5を足して返す
            //}

            ////上記をラムダ式に書くと
            //Func<int, int> ramda1 = n => n + 5;  //引数 >= 戻り値の計算式。引数が複数のときは(引数)にする



            //int Add(int a, int b)
            //{
            //    return a + b;
            //}


            ////上記をラムダ式に書くと
            //(a, b) => a + b  //引数が2こあるため、()の中に入れて、「,」で分ける。また、引数が1でなく0の場合も、同じく()の中に入れる。

            //bool IsPositive(int n)
            //{
            //    return n >= 0;
            //}

            Console.ReadLine();
        }

        private static void Output(IEnumerable<int> source)
        {
            var strList = source.Select(t => t.ToString().PadLeft(3));
            Console.WriteLine(string.Join(",", strList));
        }
    }
}
