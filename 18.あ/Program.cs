using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.あ
{
    class Program
    {
        static void Main(string[] args)
        {

            List<float> weights = new List<float>();

            weights.Add(41.2f);
            weights.Add(42.5f);
            weights.Add(43.2f);
            weights.Add(44.6f);
            weights.Add(43.3f);
            weights.Add(43.0f);
            weights.Add(41.7f);

            //体重を小さい順に並べる
            weights.Sort();

            //Listの先頭から順に3つの要素を表示する
            for (int i = 0; i < 3 ; i++)
            {
                Console.WriteLine(weights[i]);
            }
        }
    }
}
