using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._10000WARU2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10000;
            int count = 0;

            while (num >= 100)
            {
                num /= 2;
                count ++;
            }
            Console.WriteLine(count);
        }
    }
}

