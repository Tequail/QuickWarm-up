using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.demo2
{
    class Test
    {
        static void Main(string[] args)
        {
            //创建学生数组
            Student[] stus = new Student[3];
            // 创建第一个学生对象
            Student stu1 = new Student();
            stu1.name = "刘少";
            stu1.score = 88;
            // 创建第二个学生对象
            Student stu2 = new Student();
            stu2.name = "赵少";
            stu2.score = 98;
            // 创建第三个学生对象
            Student stu3 = new Student();
            stu3.name = "段少";
            stu3.score = 100;

            // 将三个学生对象 存储到学生数组中
            stus[0] = stu1;
            stus[1] = stu2;
            stus[2] = stu3;

            // 遍历学生数组 并显示每位学生信息
            // var = Object  代表任意类型 遍历出来的每一项的数据类型 
            // item :遍历出来的一个又一个的学生对象   遍历出来的每一项
            // in: 在..里面
            // collection:要遍历的集合
            // 增强for循环
            /*
                for (Student stu : stus) {
			
		        }
             */
            foreach (Student stu in stus)
            {
                stu.show();
            }





        }
    }
}
