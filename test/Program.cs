using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //変数の初期化
            const int money = 15000;  //intで整数。constで書き換え無効
            int salary = 1000;
            int hour = 5;
            //constによってmoney = money + 1000; このような書き換えができなくなる。下記のようなことはできる。moneyに変化を与えたいないため。
            int sum = money + salary * hour;
            Console.WriteLine(sum);
        }
    }
}
