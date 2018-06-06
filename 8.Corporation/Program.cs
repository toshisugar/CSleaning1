using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Corporation
{
    class Program
    {
        static void Main(string[] args)
        {
            //2つの条件を同時にチェックする方法

            int player1PosX = 2;
            int player2PosX = 6;

            //プレイヤー1の位置が「2」かつプレイヤー2の位置が「6」の場合に仕掛けを解除
            if (player1PosX == 2 && player2PosX == 6)
            {
                Console.WriteLine("仕掛け解除");
            }
        }
    }
}
