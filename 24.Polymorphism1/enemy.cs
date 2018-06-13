using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Polymorphism1
{
    class Enemy
    {
        public int hp;

        public virtual void Move()  //メソッドオーバーライドをさせるために「virtual」が必要
        {

        }
    }
}
