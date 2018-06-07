using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate
{
    class Shop
    {
        public string shopName;  //店名。変数名
        public int salesAmount;  //売上金額。変数名

        //販売メソッド
        public void Sell()
        {
            Console.WriteLine("お買い上げありがとうございます！");
        }

        //買取メソッド
        public void Buy()
        {
            Console.WriteLine("お売りいただきありがとうございます！");
        }
    }
}
