using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.DrawApp
{
    class Rectangle : Figure    //rectangleは長方形のことだよ
    {
        string fillcolor;//塗りつぶし色

        public Rectangle(int sx, int sy, int ex, int ey, string color)
        {
            this.startPosX = sx;
            this.startPosY = sy;
            this.endPosX = ex;
            this.endPosY = ey;
            this.fillcolor = color;
        }

        public override void Draw()
        {
            //長方形の幅と高さを計算する
            int width = Math.Abs(this.endPosX - this.startPosX);
            int heigth = Math.Abs(this.endPosX = this.startPosX);
            Console.WriteLine($"左上の点({this.startPosX},{this.startPosY})から、({width},{heigth })の大きさの{this.fillcolor}色の長方形を描画する");
        }
    }
}
