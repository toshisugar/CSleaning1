using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Method2
{
    class Program
    {
        static void Shop(string itemName)  //ここで宣言したitemNameはShopメソッドの中でだけ使える。
        {
            Console.WriteLine("いらっしゃいませ！");
            if (itemName == "薬草")
            {
                Console.WriteLine($"{itemName } は100円です");
            }

            else if (itemName == "棍棒")
            {
                Console.WriteLine($"{itemName }は150円です");
            }

            else
            {
                Console.WriteLine("売り切れです");
            }


        }
        static void Main(string[] args)
        {
            Shop("棍棒");  //ここに入れたものによって処理がかわる。
        }
    }
}
