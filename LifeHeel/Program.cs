using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeHeel
{
    class Program
    {
        static void Main(string[] args)
        {
            int life = 1;

            //ライフを「3」だけ増やす
            //life = life + 3;
            //上記は周りくどいため、別の書き方をする。
            life += 3;
            Console.WriteLine(life);
        }
    }
}
