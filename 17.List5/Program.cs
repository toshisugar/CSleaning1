using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.List5
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f };
            float max = 0;

            Console.WriteLine("出力フォーマットを入力してね");
            var format = Console.ReadLine();

            for (int i = 0; i < weights.Length; i++)
            {
                if ( max < weights[i] )
                {
                    max = weights[i];
                }
            }

            Console.WriteLine(string.Format(format, max));
            //Console.WriteLine($"最も重い体重は{max}です");



            //var str1 = "A" + max + "B";

            //string.Format("A{0}B", max);

            //var str2 = $"A{max}B";
        }

    }
}
