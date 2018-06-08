using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Method３
{
    class Program
    {
        static int Shop(string itemName)  //intでいいの？
        {
            Console.WriteLine("いらっしゃいませ！");
            int price = 0;

            if (itemName == "薬草")
            {
                Console.WriteLine($"{itemName}は100円です");
                price = 100;
            }

            else if (itemName == "棍棒")
            {
                Console.WriteLine($"{itemName}は1500円です");
                price = 1500;
            }
            else
            {
                Console.WriteLine("売り切れです");
                price = 0;
            }

            //引数に対応する商品の値段を返す
            return price;
        }
        static void Main(string[] args)
        {
            int money = 2500;
            Console.WriteLine($"所持金は{money}円です");  //初期化されたばかりのmoneyの値が入る
            int price = Shop("棍棒");                     //引数を指定
            money -= price;
            Console.WriteLine($"所持金は{money}円です");  //指定された引数のpriceがmoneyから差し引きされる
        }
    }
}
