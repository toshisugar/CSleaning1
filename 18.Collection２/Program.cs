using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Collection２
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> weights = new List<float>();

            weights.Add(41.2f);
            weights.Add(42.5f);
            weights.Add(3.2f);
            weights.Add(44.9f);
            weights.Add(43.2f);
            weights.Add(45.1f);
            weights.Add(43.2f);
            weights.Add(42.7f);

            //リストの先頭から3番目の要素を削除する
            weights.RemoveAt(2);  //削除するやつ

            for (int i = 0; i < weights.Count; i++)
            {
                Console.WriteLine(weights[i]);
            }
        }
    }
}
