using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowMove
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1PosY = -1;

            //プレイヤーが地上(高さ0以上の位置)にいる場合は走る
            //そうでなければ水中にいるとみなして泳ぐ
            if ( player1PosY >= 0)
            {
                Console.WriteLine("走る！");  //条件に一致したらこちらの処理
            }
            else
            {
                Console.WriteLine("泳ぐ！");  //条件に一致しなかったらこちらの処理
            }
        }
    }
}
