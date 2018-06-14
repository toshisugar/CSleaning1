using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.DrawApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //図形のインスタンスを作成する
            Circle c1 = new Circle(100, 200, 300, 400, "赤");
            Circle c2 = new Circle(250, 50, 350, 150, "青");
            Rectangle r1 = new Rectangle(300, 0, 400, 150, "緑");
            Line l1 = new Line(10, 20, 120, 0, "黒", 5);

            //ポリモーフィズムを利用してFigureクラスの変数に代入する
            List<Figure> figures = new List<Figure>();  //Figure型をもつfiguresというリストを作成。その次の行から、上で作成した図形インスタンスを格納していく。
            figures.Add(c1);
            figures.Add(c2);
            figures.Add(r1);
            figures.Add(l1);

            foreach (Figure f in figures)  //Figureリストの最初から最後まで、順次fに代入する
            {
                f.Draw();
            }
            Console.ReadLine();
        }
    }
}
