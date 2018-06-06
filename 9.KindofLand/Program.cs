using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.KindofLand
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;
            int mapType = 5;


            if (mapType == 1)  //この場合、このブロック内の処理する
            {
                hp += 10;
            }
            else if (mapType == 2)  //この場、このブロック内の処理する
            {
                hp -= 5;
            }
            else if (mapType == 3)  //この場、このブロック内の処理する
            {
                hp = 0;
            }
            else  //ifにもelse ifにも該当しない場合、このブロック内の処理する
            {
                Console.WriteLine("HPのh変化なし");
            }
            Console.WriteLine("HP=" + hp);
        }
    }
}
