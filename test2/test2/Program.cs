using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 設定字的顏色
            Console.ForegroundColor = ConsoleColor.Blue;

            // 設定底色
            Console.BackgroundColor = ConsoleColor.Black;

            // 宣告Random變數ran
            Random ran = new Random();

            // 字串
            Console.WriteLine("樂透號碼生成器");

            // 計算第幾組好碼;
            int i = 1;
            // 迴圈 , 讓使用者可以重複使用
            while (true)
            {

                // 產生號碼 ， 範圍介於 1-42
                int r1 = ran.Next(1, 43);
                int r2 = ran.Next(1, 43);
                int r3 = ran.Next(1, 43);
                int r4 = ran.Next(1, 43);
                int r5 = ran.Next(1, 43);
                int r6 = ran.Next(1, 43);

                // 不重複
                if (r1 != r2 && r1 != r3 && r1 != r4 && r1 != r5 && r1 != r6  && r2 != r3 && r2 != r4 && r2 != r5 && r2 != r6  && r3 != r4 && r3 != r5 && r3 != r6 &&  r4 != r5 && r5 != r6 )
                {
                    Console.WriteLine("");
                    Console.WriteLine("您的第"+ i +"組號碼");
                    Console.WriteLine(" ╔═════════════════════════════╗ ");
                    Console.WriteLine(" ║ {0:00} ║ {1:00} ║ {2:00} ║ {3:00} ║ {4:00} ║ {5:00} ║", r1, r2, r3, r4, r5, r6);
                    Console.WriteLine(" ╚═════════════════════════════╝ ");

                    i = i + 1;
                }
  
                Console.ReadKey();
            }
        }
    }
}

