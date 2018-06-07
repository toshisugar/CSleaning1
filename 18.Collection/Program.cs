using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> weights = new List<float>();

            //
            weights.Add(41.2f);
            weights.Add(42.5f);
            weights.Add(44.9f);
            weights.Add(43.2f);
            weights.Add(45.1f);
            weights.Add(43.2f);
            weights.Add(42.7f);

            for (int i = 0; i < weights.Count; i++)
            {
                Console.WriteLine(weights[i]);
            }

            //要素の追加
            weights.Insert(2, 44.9f);  //変数名.Insert(挿入位置のインデックス,値); で、要素が挿入できる。

            for (int i = 0; i < weights.Count; i++)
            {
                Console.WriteLine(weights[i]);
            }
        }
    }
}
