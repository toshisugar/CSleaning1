using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.inheritance1
{
    class TurboKart
    {
        //継承を使わずにクラスを作るよ

        //
        public int speed;

        public void Force()
        {
            Console.WriteLine($"加速するぞ！or減速だわ。。");
        }
        
        public void Turbo()
        {
            Console.WriteLine($"ブースト！！！！！！！！");
        }
    }
}
