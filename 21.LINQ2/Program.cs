using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hp = { 420, 120, 600, 1200 };
            List<int> newHP;//= new List<int>();

            newHP = hp.Where(t => t >= 500).ToList();

            foreach (int n in newHP)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
