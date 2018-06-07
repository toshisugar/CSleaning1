using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 1;

            switch(caseSwitch)
            {
                
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                case 3:
                    Console.WriteLine("Default case");
                    break;
            }
        }
    }
}
