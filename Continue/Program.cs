using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    continue;  //もしiが3で割って余り0だったら(つまり)3の倍数だったら、この行以降の処理をスキップする。
                }
                if (i == 8)
                {
                    break; //もしiが8だったらループ処理を抜ける
                }
                Console.WriteLine(i);
            }
        }
    }
}