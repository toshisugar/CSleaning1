using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////SkyとTurboのインスタンス作成
            SkyKart skyKart = new SkyKart();            //SkyKartクラスからSkyKartインスタンス作成 あくまでskykartは容器。名前をつけてわかりやすくてしてるだけ
            skyKart.weight = 10;
            //TurboKart turboKart = new TurboKart();      //TurboKartクラスからTurboKartインスタンス作成

            //skyKart.Force();        //SkyKartインスタンスのForceメソッド呼び出し
            //skyKart.Flying();
            //turboKart.Force();
            //turboKart.Turbo();

            //Console.ReadLine();


            string str = "konnnitiha";
            int a;
            if(int.TryParse(str, out a))
            {

            }

            Console.WriteLine(skyKart.weight);

            SkyKart aaa ;
            Test(out aaa);

            Console.WriteLine(skyKart.weight);
        }

        private static void Test(out SkyKart kart)
        {
            kart = new SkyKart();
            Console.WriteLine("");


            var p = new Person("たかし");

            p.GetName();

            p.SetName("さとし");
        }
    }

    /// <summary>
    /// 人です
    /// </summary>
    class Person
    {
        private string _name;

        /// <summary>
        /// 人のインスタンスを生成します。
        /// </summary>
        /// <param name="name">この人の名前</param>
        public Person(string name)
        {
            _name = name;
        }

        /// <summary>
        /// 名前を変更します。
        /// </summary>
        /// <param name="newName">新しい名前</param>
        public void SetName(string newName)
        {
            Console.WriteLine("名前を変更できません");
        }

        /// <summary>
        /// 名前を取得します。
        /// </summary>
        /// <returns>名前</returns>
        public string GetName()
        {
            return _name;
        }
    }
}
