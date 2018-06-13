using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Type1
{
    class Player
    {
        private string name;  //メンバ変数には、おかしな値を入れられないようにprivateしてある
        private int hp;  //CWLしても出力されずにエラーが出る。
        //↑publicとかprivateとか入る。今はprivateで制限している。ここを書き換えるとメイン関数にも変更が必要になる

        public Player(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        //変数に値を代入する
        public void SetHp(int hp)
        {
            this.hp = hp;
            if (this.hp < 0)
            {
                this.hp = 0;
            }
        }
        //hp変数の値を取得する
        public int GetHp()  //GetHpメソッド。これはアクセサと呼ぶ。publicにしてあるため外部のクラスからアクセス可能
        {
            return this.hp;
        }

        //SetNameとGetNameでメソッドを作成し、8文字以下の文字列が渡されたときだけname変数に代入する
        public void SetName(string name)
        {
            if (name != null)
            {
                int len = name.Length;  //string型の文字列の長さ取得

                if(len <= 8)
                {
                    this.name = name;
                }
            }
        }
        //name変数の値を取得する
        public string GetName()
        {
            return this.name;
        }

        

        //攻撃メソッド
        public void Attack()  //publicなので呼び出せる
        {
            Console.WriteLine(this.name + "は攻撃した");
        }
        //防御メソッド
        public void Defense()
        {
            Console.WriteLine(this.name + "は防御した");
        }
    }
}
