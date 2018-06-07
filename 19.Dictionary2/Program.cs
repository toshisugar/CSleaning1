using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Dictionary2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> tell = new Dictionary<string, string>();

            tell.Add("山田", "000 - 123 - 4563");
            tell.Add("小山田", "000 - 469 - 2488");
            tell.Add("山本", "000 - 312 - 7721");

            Console.WriteLine(tell["山田"]);
        }
    }
}
