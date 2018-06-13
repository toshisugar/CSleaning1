
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Polymorphism1
{
    class UFO : Enemy
    {
        //Enemyクラスのメソッドをオーバーライドする
        public override void Move()
        {
                Console.WriteLine($"ジグザグに移動");
        }

    }
}
