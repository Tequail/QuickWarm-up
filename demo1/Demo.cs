using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.demo1
{
    class Demo
    {
        static void Main(string[] args)
        {
            // 随机数
            Random random = new Random();
            int ran = random.Next();
            /*随机数公式:(最大值-最小值)+最小值*/
            Console.WriteLine("整数类型随机数:"+ran);
            long douRan = (long)(random.NextDouble()*(199999999999-100000000000)+ 100000000000);
            Console.WriteLine("小数类型随机数:" + douRan);
           

        }
    }
}
