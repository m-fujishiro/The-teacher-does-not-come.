using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ���搶�����Ȃ���_
{
    class Program
    {
       static int student = 0;
        static int HP=100;
        static void Main(string[] args)
        {
            string[] Sight = new string[3];
            Sight[0] = @"
   (�@߄t�)
�Q(�Q��/�P�P�P/�Q
�@�@�_/�@�@�@/
�@�@�@ �P�P�P
";

            Sight[1] = @"
   ( ߄t� )
�Q(�Q��/�P�P�P/�Q
�@�@�_/�@�@�@/
�@�@�@ �P�P�P
";
            Sight[2] = @"
   ((��)��(��))
�Q(�Q�� /�P�P�P/�Q
�@�@�_/         /
�@�@�@ �P�P�P
";
            Random rd = new Random();
            rd.Next(1);//�Ƃ肠������ł�
            var str="���Ăق����Ƃ���w�L�[�Ŏ���グ�悤�B�����������Ԃ�q�L�[��e�L�[�������Ǝ��U�邱�Ƃ��ł����B\n���낷�Ƃ���s�L�[�������ĂˁI\n�Ƃ肠�����Ȃ񂩃L�[�����Ȃ��Ɛi�܂Ȃ��ł��c�B��ŗ]�T����������Ȃ����܂��c�B";

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
                Console.Write("\n�N��");
                switch (student) {
                    case 0: Console.WriteLine("�x�e���Ă���I");break;
                    case 1: Console.WriteLine("��������Ă���I");break;
                    case 2: Console.WriteLine("���U���Ă���I");break;
                }

                switch (i) {
                    case 0: if (student > 0) Console.Write("�������A"); Console.WriteLine("�搶�͂���������Ă��Ȃ��I"); break;
                    case 1:
                        if (student > 1) {
                            int rand = rd.Next(100);
                            if (rand ==50) came = true;
                            else
                            {
                                Console.WriteLine("�������A�C�t����Ȃ������I");
                            }
                        }
                        else{
                            if (student > 0) Console.Write("�������A");
                        Console.WriteLine("�搶�͂���������Ă��Ȃ��I");
                        } break;
                    case 2: if (student > 0) came = true;
                        else Console.WriteLine("���������搶������������Ă����ɂ��ւ�炸�I"); break;
                }

              Console.WriteLine(Sight[i]);
              Thread.Sleep(1000);
                score++;
            }

            if(HP>0) {
                Console.WriteLine("����������(߁��)��������!!");
                Console.WriteLine("�N�̃X�R�A��"+score+"���B(�Ⴂ�قǗǂ�)");
            }
            else Console.WriteLine("\n�N�͗͐s�����c�B");
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
