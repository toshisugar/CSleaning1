using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.inheritance2
{
    class SkyKart : Kart  //Kartクラスから継承する
    {
        //離陸するメソッドのみ追加
        private void Flying()
        {
            Console.WriteLine($"離陸！！！！");
        }
    }

}
