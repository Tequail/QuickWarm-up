using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.demo3
{
    class Demo
    {

        static void Main(string[] args)
        {

            int[] arr = { 9, 5, 2, 8 };
            /*while循环特点:先判断后执行*/
            // 初始化循环变量
            int i = 0;
            // 循环条件   
            while (i < arr.Length)
            {
                //循环操作
                Console.WriteLine(arr[i]);
                // 循环变量的更新
                /*在循环中加入break*/
                if (arr[i] == 2)
                {
                    break;
                }
                i++;
            }
            /*do-while循环特点:先执行后判断 不管条件成不成立至少执行一次*/
            int j = 0;
            do
            {
                /*在循环中加入continue*/
                if (arr[j]==5)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(arr[j]);
                j++;

            } while (j<arr.Length);

            /*for循环特点:先判断后执行   适合循环次数明确的循环  */
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }

            /*增强for循环 没有循环变量 直接迭代出数组或者集合中的对象*/
            foreach (var a in arr)
            {
                Console.WriteLine(a);
            }

            /*
             * break:打断 立即终止循环
             * continue: 跳过  跳过本次循环 进入下次循环
             */
        }

    }
}
