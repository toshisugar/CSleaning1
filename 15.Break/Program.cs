using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Break
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosX = 5;
            int missilePosX = 15;

            while (true)
            {
                if (playerPosX == missilePosX)
                {
                    break;
                }

                Console.WriteLine("missile at " + missilePosX);
                missilePosX--;

            }
            Console.WriteLine("HIT");
        }
    }
}
