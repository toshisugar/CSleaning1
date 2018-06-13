using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Type2
{
    class Player
    {
        private string name;
        private int hp;


        //以下、publicなコンストラクタとメンバメソッドを定義
        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        //HPプロパティ
        public int Hp  //public プロパティの型名　プロパティ名　　プロパティ名は基本的に大文字で始める
        {
            set  //setブロック。メンバ変数に値を代入するときの処理を書く。メンバ変数に代入する値は、
            {   //プロパティ内では「value」変数に保持される。
                this.hp = value;  //変数名　=　value；
                if (this.hp < 0)  //hpを確認し
                {
                    this.hp = 0;  //0以下だったら0に修正し
                }
            }
            get  //プロパティ
            {
                return this.hp;  //return　変数名；  //その値をthis.hpに返す
            }
        }
        public void Attack()
        {
            Console.WriteLine($"{this.name}は攻撃した");
        }

        public void Defense()
        {
            Console.WriteLine($"{this.name}は防御した");
        }
    }
}
