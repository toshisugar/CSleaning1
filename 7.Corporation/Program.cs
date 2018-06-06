using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Corporation
{
    class Program
    {
        static void Main(string[] args)
        {
            //2つの条件が同時に満たされた場合だけ仕掛けを解除する処理を書いていく

            int player1PosX = 2;  //プレイヤー1の位置
            int player2PosX = 6;  //プレイやー2の位置

            //プレイヤー1の位置が「2」かつプレイヤー2の位置が「6」の場合に仕掛けを解除
            if (player1PosX == 2)
            {
                if (player2PosX == 6)
                {
                    Console.WriteLine("仕掛け解除");
                }
            }

        }
    }
}
