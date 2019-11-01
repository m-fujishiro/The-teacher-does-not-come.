using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 大井先生が来ないっ_
{
    class Program
    {
       static int student = 0;
        static int HP=100;
        static void Main(string[] args)
        {
            string[] Sight = new string[3];
            Sight[0] = @"
   (　ﾟдﾟ)
＿(＿つ/￣￣￣/＿
　　＼/　　　/
　　　 ￣￣￣
";

            Sight[1] = @"
   ( ﾟдﾟ )
＿(＿つ/￣￣￣/＿
　　＼/　　　/
　　　 ￣￣￣
";
            Sight[2] = @"
   ((●)ω(●))
＿(＿つ /￣￣￣/＿
　　＼/         /
　　　 ￣￣￣
";
            Random rd = new Random();
            rd.Next(1);//とりあえず空打ち
            var str="来てほしいときはwキーで手を上げよう。手を挙げた状態でqキーやeキーを押すと手を振ることができるよ。\n下ろすときはsキーを押してね！\nとりあえずなんかキー押さないと進まないです…。後で余裕があったらなおします…。";

            //            Console.WriteLine(Sight);
            bool came = false;
            int score = 0;
            while (!came)
            {
                int i = rd.Next(2);
                if (rd.Next(100) == 50) i = 2;

                Console.WriteLine(str);
                //               Console.WriteLine("HP : "+HP);
                Student();
                if (HP < 0) break;
                Console.Write("\n君は");
                switch (student) {
                    case 0: Console.WriteLine("休憩している！");break;
                    case 1: Console.WriteLine("手を挙げている！");break;
                    case 2: Console.WriteLine("手を振っている！");break;
                }

                switch (i) {
                    case 0: if (student > 0) Console.Write("しかし、"); Console.WriteLine("先生はこちらを見ていない！"); break;
                    case 1:
                        if (student > 1) {
                            int rand = rd.Next(100);
                            if (rand ==50) came = true;
                            else
                            {
                                Console.WriteLine("しかし、気付かれなかった！");
                            }
                        }
                        else{
                            if (student > 0) Console.Write("しかし、");
                        Console.WriteLine("先生はこちらを見ていない！");
                        } break;
                    case 2: if (student > 0) came = true;
                        else Console.WriteLine("せっかく先生がこちらを見ていたにも関わらず！"); break;
                }

              Console.WriteLine(Sight[i]);
              Thread.Sleep(1000);
                score++;
            }

            if(HP>0) {
                Console.WriteLine("ｷﾀ━━━━(ﾟ∀ﾟ)━━━━!!");
                Console.WriteLine("君のスコアは"+score+"だ。(低いほど良い)");
            }
            else Console.WriteLine("\n君は力尽きた…。");
            Thread.Sleep(10000);

        }
            
        static void Student() {
            var user = Console.ReadKey(true);
            Console.Clear();
            switch (user.KeyChar) {
                case 'w':student = 1;HP--; break;
                case 's':student = 0;HP++; break;
                case 'q' : case 'e':
                    if (student > 0)
                    {
                        HP -= 3;
                        student = 2;
                    }
                    else {
                        HP++;
                        student = 0;
                    }
                    break;
                default: if (student > 0)
                    {
                        HP--; student = 1;
                    }
                    else HP++; break; 
            }
        }
    }
}
