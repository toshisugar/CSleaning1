using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            //player1のインスタンスを作る
            Player player1 = new Player("たかし", 100);

            //player1の体力をコンソールに表示
            Console.WriteLine(player1.name + "の体力は" + player1.hp);
        }
    }
}
