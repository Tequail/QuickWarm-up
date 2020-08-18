using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.HomeWork_8_15.work1
{
    class Work1
    {
        static void Main(string[] args)
        {
            //直角三角形
            /* for (int i = 0; i < 5; i++)
             {
                 for (int j = 0; j <= i; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/
            //等腰三角形
            for (int i = 1; i <= 5; i++)
            {
                /*旁边倒三角的空白*/
                for (int j = 5-i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                /*等腰三角形*/
                for (int k = 0; k < 2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
