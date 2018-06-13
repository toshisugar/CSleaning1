using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.DrawApp
{
    class Figure
    {
        protected int startPosX, startPosY, endPosX, endPosY; //座標位置変数。同じ型の変数を複数戦g年するときは「,」で区切って連続で書くことができる。
        //図形を描画するメソッド
        virtual public void Draw()                          //Drawメソッド。クラスによって描くものが違うので、オーバーライドするためvirtualをつけていて空。
        {

        }
    }
}
