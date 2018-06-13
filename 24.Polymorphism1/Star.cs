using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Polymorphism1
{
    class Star : Enemy
    {
        //EnemyクラスのMoveメソッドをオーバーライドする
        public override void Move()
        {
            Console.WriteLine($"回転しながら移動");
        }
    }
}
