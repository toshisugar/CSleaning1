using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.inheritance2
{
    class Kart
    {
        public int weight;
        public int speed;

        public Kart()
        {
            weight = 50;
        }

        public void Force()
        {
            Console.WriteLine($"加速 or 減速");  //減速機能を追加
        }

    }
}
