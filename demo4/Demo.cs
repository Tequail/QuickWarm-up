using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.demo4
{
    class Demo
    {
        static void Main(string[] args)
        {
            // 1.外层循环用来可控制行数  内层循环控制打印的次数
            // 2.外层循环一次 内层循环一遍
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j+1);
                }
                Console.WriteLine();
            }
        }
    }
}
