using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Missile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosX = 5;
            int missilePosX = 15;

            //プレイヤーの位置とミサイルの位置が等しくなければ
            //ミサイルの移動を繰り返す
            while (playerPosX != missilePosX)
            {
                Console.WriteLine("missile at" + missilePosX);
                missilePosX--;
            }
            Console.WriteLine("HIT");
        }
    }
}
