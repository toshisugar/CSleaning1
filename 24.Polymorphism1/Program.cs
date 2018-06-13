using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Polymorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
            //UFO ufo;
            //Star[] stars = new Star[2];         //箱が2個あるStar配列を作成し、starsに代入(stars[0]とstars[1]ができる
            //Meteor[] meteors = new Meteor[2];   //上と同じ

            ////インスタンスを生成する
            //ufo = new UFO();
            //stars[0] = new Star();　　//配列の1要素stars[0]に、Starインスタンスを代入
            //stars[1] = new Star();
            //meteors[0] = new Meteor();
            //meteors[1] = new Meteor();

            ////敵を移動する
            //ufo.Move();                                  //ufo(UFOインスタンスが代入されている)のMoveメソッドを呼び出し
            //for (int i = 0; i < stars.Length; i++)        //iが0からstarsリストの長さ(つまり2)より小さいとき実行し、iに1足す
            //{
            //    stars[i].Move();                         //stars[要素番号](Starインスタンスが代入されている)インスタンスのMoveメソッドを呼び出し
            //}
            //for (int i = 0; i < meteors.Length; i++)
            //{
            //    meteors[i].Move();
            //}

            Enemy[] enemies = new Enemy[5];  //Enemyクラス(型)の配列を作成、配列の大きさは5。クラスは型なので、その型のインスタンスしか受け付けない。
                                           //しかし、ポリモーフィズムがあるため、継承したインスタンスは入るし、それぞれのメソッドも使用できる。

            //インスタンスをEnemyクラスの変数に代入する。わざわざそれぞれの変数を作成する必要がない。Enemyクラスから呼び出して使える！
            enemies[0] = new UFO();
            enemies[1] = new Star();
            enemies[2] = new Star();
            enemies[3] = new Meteor();
            enemies[4] = new Meteor();

            //移動する
            for (int i = 0; i < enemies.Length; i++)//enemiesのリストの限り繰り返し
            {
                enemies[i].Move();//enemiesの要素0から4までMoveメソッドを使う
            }


        }
    }
}
