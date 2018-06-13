using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free
{
    class Program
    {
        static void Main(string[] args)
        {

            //while (true)
            //{

            //for (int lines = 1; lines < 10; lines++)
            //{
            //    int result1 = 0;
            //    int rows = 1;

            //    while (true)
            //    {
            //        result1 = lines * rows;
            //        string result1str = result1.ToString();
            //        Console.Write(result1str.PadLeft(3));
            //        rows += 1;
            //        if (rows > 9)
            //        {
            //            break;
            //        }

            //        Console.Write(",");

            //    }
            //    Console.WriteLine("");

            //}
            //}

            //var g = new int[9, 9];
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int z = 1; z < 9; z++)
            //    {
            //        Console.Write(ToStringしちゃうよ(i * z) + ",");
            //    }
            //    Console.WriteLine(ToStringしちゃうよ(i * 9));



            //}




            //var g = new int[9, 9];
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int z = 1; z < 10; z++)
            //    {
            //        g[i - 1, z - 1] = i * z;
            //    }
            //}

            //Console.WriteLine("");



            //foreach (int a in g)
            //{
            //    System.Console.Write("{0}", a);



            //int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            //foreach (int i in numbers2D)
            //{
            //    System.Console.Write("{0} ", i  );
            //}









            //var nums = Enumerable.Range(1, 9);
            //foreach (var y in nums)
            //{
            //    Console.WriteLine(string.Join(",", nums.Select(t => ToStringしちゃうよ(y * t))));
            //}


            //int j = 0;
            //while(j < 10)
            //{


            //    j++;
            //}


            int a = 3;
            Test(ref a);
            Console.WriteLine(a);




        }
        static void Test(ref int val)
        {
            val = 10;
        }
    }


    

//    private static string ToStringしちゃうよ(int value)
//    {
//        return value.ToString().PadLeft(3);
//    }
}


