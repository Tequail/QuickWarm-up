using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace QuickWarm_up
{
    class demo5
    {
        static void Main(string[] args)
        {
            //交换两个数据
            /*int a = 16;
            int b = 25;
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine(a);
            Console.WriteLine(b);*/
            /*
             * 冒泡排序
             * 1.外层循环控制比较的轮数
             * 2.内层循环控制比较的次数
             *   数组的长度是5  比较的轮数却是 4轮
             * 口诀:外层循环 n - 1
             *      内层循环 n - 1 - i
             */
            int[] arr = { 16, 25, 9, 90, 23 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    /*数据之间的比较和交换*/
                    /*
                     16 25比较
                     两瓶水 一瓶可乐  一瓶雪碧  
                     需要一个空瓶子才能保证两个数据的交换
                     */
                    // 判断 如果第二个数比第一个数要小 进行交换
                    if (arr[j] > arr[j+1])
                    {
                        int temp;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }  
                }   
            }
            foreach (var a in arr)
            {
                Console.Write(a+" ");
            }
        }
    }
}
