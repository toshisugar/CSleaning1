using System;

namespace _22.Type1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player player1 = new Player("たかし", 35);
            //Player player2 = new Player("ひろし", 100);

            //player2 = player1;
            //Console.WriteLine(player2.hp);
            //player1.hp = 0;
            //Console.WriteLine(player2.hp);

            //以下クラスのｱｸｾｽををpublicからprivateに変更した場合
            Player player = new Player("たかしたかしたかし", 500);
            // player.Attack();  //publicなので呼び出せる
            //playerの体力を2000減らしてnewHP変数に代入する
            int newHP = player.GetHp() - 2000;
            //newHPをplayerの体力に代入する
            player.SetHp(newHP);  //SetHpメソッド。これもアクセサ。引数nweHPを受け取り、
            //メンバ変数のhp(this.hp)に代入する。おかしな値にならないように、クラス作成のところで0に調整できるようにしてある
            Console.WriteLine($"HPは{player.GetHp()}");

            string NewNAME = player.GetName();
            player.SetName(NewNAME);

            Console.WriteLine($"名前は{player.GetName()}です");  //謎。回答どおりにやっても9文字出力される。

            Console.ReadLine();
        }
    }
}
