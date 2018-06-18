using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26.WindowsAPP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HelloButtonClickd(object sender, EventArgs e)  //これがイベントハンドララベルの表示を書き換えるプログラムを記述している
        {
            this.helloLabel.Text = "Hello,World";                  //LabelのNameプロパティをhelloLabelに変更しているため、それを入力すればラベルにアクセスできる。
            // コントロール（ラベルとかボタン）は、すべてオブジェクトになっている。
            // デザイナでコントロールを配置すると、自動的に、そのコントロールの変数が定義されて、newされるコードが追加される。
            // Nameプロパティを変更すると、デザイナが気を利かせて、そのコントロールの変数名も変更してくれるので、その名前でコントロールにアクセスできるようになる。
            // （Form1.Designer.cs ファイルを見てみるべし）
        }//helloLabelに.Textとつけることで、Textプロパティに文字列を代入している。

        private void helloLabel_AutoSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
