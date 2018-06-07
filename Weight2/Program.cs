using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weight2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] weights = { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f };

            //配列の値をすべて表示する
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(weights[i]);
            }
        }
    }
}
