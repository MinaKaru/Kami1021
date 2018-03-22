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
            Random rand = new Random();

            while (true)
            {
                int r1 = rand.Next(0, 43);
                int r2 = rand.Next(0, 43);
                int r3 = rand.Next(0, 43);
                int r4 = rand.Next(0, 43);
                int r5 = rand.Next(0, 43);
                int r6 = rand.Next(0, 43);
                int r7 = rand.Next(0, 43);

                Console.WriteLine("號碼 : {0} {1} {2} {3} {4} {5} {6}", r1, r2, r3, r4, r5, r6, r7);
            }
            Console.ReadLine();
        }
    }
}
