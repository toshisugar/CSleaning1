using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LINQ5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////-1,-10,-5,-40,-15の要素を持つ配列　すべてを10増やしselect　結果0以上となる要素の個数を求めるcount
            //var r = new Random();
            //var num = Enumerable.Range(0, 10).Select(_ => r.Next(-20, 0)).ToList();

            ////var num1 = num.Select(t => t.ToString().PadLeft(3));  //numの3文字に満たない要素の先頭にスペースをつけて3文字にする
            ////↑でセレクトせずにToStringとPadLeftしてた。逆にどういう処理になってたんだろう。。
            //Console.WriteLine("元データ");
            //Console.WriteLine(string.Join(",", num.Select(t => t.ToString().PadLeft(3))));
            ////先にjoinされてしまって、各要素ごとにPadLeftしてくれない→先にjoinされたわけじゃなく、selectしてなかったためそもそもToStringとPadLeftがされてなかった
            ////ひとつにまとめられた。よって間のnum1の存在が必要なくなった

            ////Console.WriteLine(string.Join(",", num.Select(t => t + 10).ToString().PadLeft(3)));
            ////★↑このどこにToString().PadLeft(3)を入れればいいんだろう。10,Tostring().PadLeft(3)にすると10が計算される前に文字列になる。。
            ////今の場所だとリストに戻る
            //Console.WriteLine(string.Join(",", num.Select(t => (t + 10).ToString().PadLeft(3))));
            ////↑でできた！

            //Console.WriteLine($"ランダムで生成した数字のうち、10を足したら0以上になる数字は{string.Join(",", num.Count(t => (t + 10) >= 0))}個である。");
            ////var num = 
            ////int num_new = Console.WriteLine();

            Action b = Console.WriteLine;

            Func<int> a = Temp;
            var aaaa = Temp();

            Console.WriteLine();

            var res = Calculate(1, 2, Plus);

            Console.ReadLine();

            int t = Calculate(3, 4, (hidari, migi) => hidari + migi);
            t = Plus(3, 4);


        }

        static int Temp()
        {
            return 3;
        }

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Plus2(int a, int c)
        {
            return a + c;
        }

        static int Plus4(int a, string c)
        {
            return a + int.Parse(c);
        }

        static int Plus3(int a, int c, int d)
        {
            return a + c;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static int Increment(int a, int b)
        {
            return a + 1;
        }

        static string Func1(int a, int b)
        {
            return (a + b).ToString();
        }

        static void Sub(string[] args)
        {

        }

        private static int Calculate(int a, int b,Enzanshi temp)  //Calculate(引数aはint,引数bはint。各値の型をEnzanshiで定義した通りにする。
        {
            Console.WriteLine($"今から{a}と{b}を使って何らかの計算をします");
            // すごいいろいろな処理

            int res = temp(a, b);

            Console.WriteLine($"結果は{res}でした");
            // すごいいろいろな処理
            return res;
        }


    }

    delegate int Enzanshi(int a, int b);  //Enzanshiを定義した.intふたつを受け取って、intを返すという定義

    delegate T2 MyFunc<T1,T2,T3>(T1 a, T2 b);//Func<?,?,?>を自分で定義してみた。<>内で型を決める、T1 aは、T1が引数aに対応するということを示している。


    public class Temp2
    {
        void Func1() { }

        private void Func2() { }

        internal void Func3() { }

        protected void Func4() { }

        internal protected void Func5() { }

        private protected void Func6() { }

        public void Func7() { }

    }
}
