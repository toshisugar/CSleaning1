using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.over500
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while ( true )
            {
                if (num > 500)
                {
                    break;
                }
                Console.WriteLine(num);
                num++;
            }
            Console.WriteLine("END");
        }
    }
}
