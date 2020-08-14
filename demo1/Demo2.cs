using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.demo1
{
    /// <summary>
    /// 条件语句
    /// </summary>
    class Demo2
    {

        // 一次对比C#中的条件语句与java中的条件语句
        static void Main(string[] args)
        {
             /*if语句*/
            if (true)
            {

            }
             /*if-else*/
            if (true)
            {

            }
            else
            {

            }
             /*if -else if-else*/
            if (true)
            {

            }
            else if (true)
            {

            }
             /*嵌套if*/
            if (true)
            {
                if (true)
                {

                }
            }
            /*向下开一行:ctrl+shift+回车*/
            /*向上开一行:ctrl+回车*/
            /*switch选择结构与java中的区别:java中的break可以没有,C#中的break必须有*/
            /*输入银行的简称展示对应的全程*/
            Console.WriteLine("请输入银行的简称:");
            string bank = Console.ReadLine();
            switch (bank)
            {
                case "ICBC":
                    Console.WriteLine("中国工商银行");
                    break;
                case "CBC":
                    Console.WriteLine("建设银行");
                    break;
                case "ABC":
                    Console.WriteLine("农业银行");
                    break;
                default:
                    Console.WriteLine("输入错误");
                    break;
            }


        }


    }
}
