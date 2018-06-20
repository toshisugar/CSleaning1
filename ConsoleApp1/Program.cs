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
            var instance = new GenericsSample();           //コンストラクタ。インスタンス作成
            var method = instance.GetStringList();              //変数にメソッドを代入して使えるように。コンストラクタ｡クラス名
            Console.WriteLine(string.Join("",method));    //リストを出力することはできないから、リストの要素を結合して出力。
            Console.ReadLine();
        }
    }
}
