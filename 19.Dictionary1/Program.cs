using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Dictionary1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary型の変数を作る
            Dictionary<string, float> weights = new Dictionary<string, float>();

            weights.Add("2016/12/10", 41.2f);
            weights.Add("2016/12/11", 42.5f);
            weights.Add("2016/12/12", 43.2f);
            weights.Add("2016/12/13", 44.6f);
            weights.Add("2016/12/14", 43.3f);
            weights.Add("2016/12/15", 43.0f);
            weights.Add("2016/12/16", 41.7f);


            //2016/12/13の体重を表示する
            Console.WriteLine(weights["2016/12/13"]);  //
        }
    }
}
