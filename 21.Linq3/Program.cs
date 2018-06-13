using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            var hp = Enumerable.Range(0, 10).Select(_ => r.Next(200, 2000)).ToList();  //10個の数字をランダムで生成するよ

            Output(hp);  //HPの内容を表示

            var newHP = hp.Select(a => a - 100).ToList();  //HPのリストの中身それぞれを100マイナスし、リストにしたものをnewHPに代入する

            Output(newHP);  //上で処理した内容を出力する

            Console.ReadLine();  //処理終わってもコンソールが閉じないようにする

        }
        private static void Output(IEnumerable<int> source)  //Outputという静的インスタンス作成(sourceは引数)
        {
            var strList = source.Select(t => t.ToString().PadLeft(3));  //引数を、stringにして射影、strListに代入
            Console.WriteLine(string.Join(",", strList));  //strListのそれぞれの要素の間に「,」を付して結合(join)する
            //なぜこれが必要なのか。リストをそのままCWLしても、「これ、リストですｗｗ」としかでない。リストを文字列として出力はされない。
            //一方、数字は便宜上オーバーロードしてくれるため、そのまま出力してくれる。
        }
        //}
    }
}
