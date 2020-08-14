using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.demo1
{
    /// <summary>
    /// 数组的创建
    /// </summary>
    class Demo4
    {
        static void Main(string[] args)
        {
            // int类型的数组
            int[] arr;// c#只能这么创建数组

            // 数组长度的定义
            arr = new int[5];
            arr[0] = 34;
            // 数组的初始化
            int[] arr1;
            arr1 = new int[5]{1,2,3,4,5 };//定义长度并且赋值
            int[] arr2 = new int[] { 2, 3, 4, 5, 6 };//数组的长度是根据大括号中数据长度而定的
            // 不能声明后创建
            int[] arr3 = { 3, 4, 5, 7, 8, 9 };//直接赋值 长度根据括号里面的数据而定
            // 获取数组的长度
            Console.WriteLine("arr数组的长度是:"+arr.Length);
        }
    }
}
