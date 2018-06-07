using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Weight3
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] weights = new float[] { 41.2f, 42.5f, 44.9f, 43.2f, 45.1f, 43.2f, 42.7f, 41.5f, 41.4f, 41.9f };

            for (int i = 0; i < weights.Length; i++)
            {
                Console.WriteLine(weights[i]);
            }

            foreach (float w in weights)
            {
                Console.WriteLine(w);
            }
        }
    }
}
