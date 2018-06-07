using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (count < 9)
            {
                if (count++ % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(count);
            }
        }
    }
}
