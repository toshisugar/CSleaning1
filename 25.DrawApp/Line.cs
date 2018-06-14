using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.DrawApp
{
    class Line : Figure
    {
        string penColor;//ペンの色
        int penSize;    //ペンの太さ
        
        public Line(int sx, int sy, int ex, int ey, string color, int size)
        {
            this.startPosX = sx;
            this.startPosY = sy;
            this.endPosX = ex;
            this.endPosY = ey;
            this.penColor = color;
            this.penSize = size;
        }

        public override void Draw()
        {
            Console.WriteLine($"({this.startPosX},{this.endPosX})から({this.startPosY},{this.endPosY})に太さ{this.penSize}で{this.penColor}色の線を引く");
        }
    }
}
