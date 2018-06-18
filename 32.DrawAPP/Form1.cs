using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32.DrawAPP
{
    public partial class Form1 : Form
    {
        Point startPos, endPos;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DrawFigures(object sender, PaintEventArgs e)
        {
          

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;  //左辺を入力すると、右辺の候補が表示される。型名さえ知っていれば、Shift+Alt+F10で、候補が出てくる。usingを使うか、ネームスペースを含めて呼び出すか。
            //円を描画する
            SolidBrush brush = new SolidBrush(Color.Purple);
            //塗りつぶすためのブラシ作成。SolidBrush型で作ることができ、インスタンス作成時にコンストラクタの引数にブラシの色を指定する。
            //ここでは引数にColor.Purpleをわたして紫色のブラシを作っている。
            //e.Graphics.FillEllipse(brush, 0, 0, 200, 200);
            //円を描画するためにはイベントハンドラの引数のPaintEventArgsクラスが持つGraphicsプロパティを使う
            //このプロパティにアクセスすることで描画に使用するGraphicsクラスのインスタンスを取得できる。
            //このインスタンスの持つメソッドを使い、画面上に図形を描画する
            //円の描画にはFillEllipseメソッドを使う。引数には(図形を塗りつぶすブラシ、座標、座標、幅、高さ)を指定している。

            int width = this.endPos.X - this.startPos.X;
            int height = this.endPos.Y - this.startPos.Y;
            e.Graphics.FillEllipse(brush, this.startPos.X, this.startPos.Y, width, height);
        }

        private void MousePressed(object sender, MouseEventArgs e)  //引数「MouseEventArgs e」。
            //このeにはとてもたくさんのマウスデータが入っている。位置やホイールを何回回したか等
        {
            //円の始点座標をstartPosに保存する
            this.startPos = new Point(e.X, e.Y);
            //e情報の中のX情報とY情報それぞれをPoint型のstartPos変数に代入する。
            //startPos等は構造体でり、newで呼び出す必要はないが、座標としてわかりやすいのでこのように代入している。
            //実は「this.startPos.X = e.X;」とかで代入できる。
        }

        private void MouseDragged(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  //e.Button(マウスボタン情報)が、MouseButton.Left(左ボタンを押している状態)だったら
            {
                //終点座標を更新する
                this.endPos = new Point(e.X, e.Y);  //離した瞬間のe情報のX,Yを終点として記録する

                Invalidate();
            }
        }
    }
}
