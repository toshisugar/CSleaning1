using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAve
{
    class Program
    {
        static void Main(string[] args)
        {
            int math = 80;
            int english = 66;
            int history = 95;

            //
            float average = (math + english + history) / 3.0f;  //float型で割りたいため、3.0「f」をつける
            //intどうしの割り算の結果は必ず整数になる。
            //3.0fでなく3で割ると、小数点以下は切り捨てとなり、計算結果の値は80になる。
            
            //float a = 5 / 10; の場合、aはfloatだが、右辺がintで結果を出してaに代入するため、結果は0になる
            //float a = 5 / 10f(または5にf)とすれば、0.5を返す
            Console.WriteLine("平均は" + average + "点");
            Console.ReadLine();
        }
    }
}
