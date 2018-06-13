using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Polymorphism1
{
    class Meteor : Enemy
    {
        //EnemyクラスのMoveメソッドをオーバライドする
        public override void Move()
        {
            Console.WriteLine($"まっすぐに移動");
        }
    }
}
