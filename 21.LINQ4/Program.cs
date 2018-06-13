using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LINQ4
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var hp = Enumerable.Range(0, 20).Select(_ => r.Next(0, 50)).ToList();

            Console.WriteLine(string.Join(",",hp));
            var zeroHP = hp.Where(t => t == 0).Count();  //さっきはここでリストにしていたが、Count()で要素数を出してそれを出力したいからリストにしない
            Console.WriteLine(zeroHP);  //さっきはここでリストをstring.joinして文字列にしたが、今回は要素の数を出力するだけなので必要ない

            Console.ReadLine();
        }
    }
}
