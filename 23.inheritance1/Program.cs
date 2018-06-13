using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _22.Type2;

namespace _23.inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            //SkyKart
            SkyKart skykart = new SkyKart();     //飛空カートのインスタンスを作る
            //skykart.Force();                    //アクセルを踏む
            //skykart.Brake();                    //離陸する

            //skykart.Speed();                    //スピードメソッド(現在のスピードを出す)実行
            

            //TurboKart
            TurboKart turbokart = new TurboKart();
            turbokart.Force();
            turbokart.Turbo();


            Console.WriteLine("戻ったぞ");      //処理がここまで達したこと確認
            Console.ReadLine();
        }

    }
}
