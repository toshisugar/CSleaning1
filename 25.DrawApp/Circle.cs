using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.DrawApp
{
    class Circle : Figure
    {
        string fillColer;//塗りつぶし色
        
        public Circle(int sx, int sy, int ex, int ey,string color)//Circleの引数を指定
        {
            this.startPosX = sx;//受け取った値を代入。thisは薄くなっているとおり、別に書かなくてもよい
            this.startPosY = sy;
            this.endPosX = ex;
            this.endPosY = ey;
            this.fillColer = color;
        }

        public override void Draw()
        {
            //表示に必要な円の中心座標と半径を計算する
            int centerX = (this.startPosX + this.endPosX) / 2;
            int centerY = (this.startPosY + endPosY) / 2;
            int radius = Math.Abs(this.startPosX - this.endPosX) / 2;                   //MathクラスのAbsメソッド。絶対値を出す
            Console.WriteLine($"({centerX},{centerY},)を中心にして、半径{radius}、{this.fillColer}色の円を描く");
        }
    }
}
