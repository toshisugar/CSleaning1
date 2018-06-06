using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOver
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosX = 5;  //プレイヤーの位置はX=「5]
            int enemyPosX = 10;  //敵の位置は「X=10」

            //プレイヤーと敵の位置が等しい場合はゲームオーバーと表示される
            if (playerPosX == enemyPosX)
            {
                Console.WriteLine("ゲームオーバー");
            }
        }
    }
}
