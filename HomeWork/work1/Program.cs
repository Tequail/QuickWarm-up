using System;

namespace QuickWarm_up
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic a = new Arithmetic();
            Console.WriteLine("请输入第一个数:");
            a.num1 =int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数:");
            a.num2 =int.Parse(Console.ReadLine());
            // 复制到下一行 ctrl + d
            // 删除一行 ctrl + l
            // 向下移动 alt +  ↓
            // 撤销 ctrl + z
            // 调用求和的方法
            a.Add();
        }
    }
}
