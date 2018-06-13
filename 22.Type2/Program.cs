using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Type2
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("たかし", 500);
            //playerのHPプロパティに代入
            player.Hp -= 2000;
            Console.WriteLine($"HPは{player.Hp}");
        }
    }
}
