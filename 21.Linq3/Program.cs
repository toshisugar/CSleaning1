using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();

            var hp = Enumerable.Range(0, 10).Select(_ => r.Next(200, 2000)).ToList();  //

            Console.Write(hp);

            var newHP = hp.Select(a => a - 100).ToList();

            Console.WriteLine(newHP);

            Console.ReadLine();

        }
    }
}
