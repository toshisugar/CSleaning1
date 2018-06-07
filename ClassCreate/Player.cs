using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate
{
    class Player
    {
        public string name;  //プレイヤーの名前。メンバ変数
        public int hp;  //プレイヤーの体力。メンバ変数

        //Playerクラスのコンストラクタ
        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }
        
        //攻撃メソッド
        public void Attack()  //メンバメソッド
        {
            Console.WriteLine(this.name + "は攻撃した");  //「this.変数名」で自分自身のインスタンスの変数=メンバ変数
                                                     //thisがついてなければローカル変数。
        }

        //防御メソッド
        public void Defense()  //メンバメソッド
        {
            Console.WriteLine(this.name + "は防御した");
        }
    }
}
