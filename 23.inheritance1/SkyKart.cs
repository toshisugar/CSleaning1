using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.inheritance1
{
    class SkyKart
    {
        public uint weight;
        public uint speed = 0;       //メンバ変数

        //アクセルメソッド
        public void Force()
        {
            //speed++;
            Console.WriteLine("加速or減速!");
        }

        public void Flying()
        {
            Console.WriteLine($"離陸ｗｗ");
        }

        ////ブレーキメソッド
        //public void Brake()
        //{
        //    if (speed > 0)
        //    {
        //        speed--;
        //        Console.WriteLine($"減速だわ。。");
        //    }

        //}

        //速度表示メソッド
        public void Speed()
        {
            Console.WriteLine($"今のスピードは{speed}だぞ");
        }


    }
}
