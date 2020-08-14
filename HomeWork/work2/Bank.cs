using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.HomeWork.work2
{
    class Bank
    {
        public User user ;

        public void Menu()
        {
            Console.WriteLine("==========欢迎使用自动银行服务===========");
            Console.WriteLine("1.存款 2.取款 3.转账 4.查询余额 5.退出");
            Console.WriteLine("=========================================");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.WriteLine("欢迎下次再来!");
                    break;

                default:
                    Console.WriteLine("输入错误!");
                    break;
            }
        }

        /// <summary>
        /// 创建账户
        /// </summary>
        public void CreateUser()
        {
            user = new User();
            Console.WriteLine("请输入用户名:");
            user.userName = Console.ReadLine();
            Console.WriteLine("请输入用户密码:");
            user.password = Console.ReadLine();
            Console.WriteLine("请输入用户身份证号:");
            user.idCardNo = Console.ReadLine();
            Console.WriteLine("请输入用户存款金额:");
            user.accountMoney = int.Parse(Console.ReadLine());
            //生成账户
            Random random = new Random();
            //Math.Abs:绝对值  不管随机出来的是正数还是负数   都将变为正数 absolute:在html绝对定位
            //user.accountNo = (long)(Math.Abs( random.NextDouble() * 100000000000));
            user.accountNo = (long)(random.NextDouble() * (199999999999 - 100000000000) + 100000000000);
            Console.WriteLine("账户:{0},用户名:{1},存款金额:{2}创建成功!",user.accountNo,user.userName,user.accountMoney);
        }

        /// <summary>
        /// 转账
        /// </summary>
        public void TransferAccount()
        {

        }
        /// <summary>
        /// 存款
        /// </summary>
        public  void Withdrawal()
        {

        }
        /// <summary>
        /// 取款
        /// </summary>
        public void Deposit()
        {
            Console.WriteLine("请输入账号:");
            long accountNo = long.Parse( Console.ReadLine());
            Console.WriteLine("请输入密码:");
            string password = Console.ReadLine();
            //判断是否正确
            if (accountNo == user.accountNo && password.Equals(user.password))
            {
                Console.WriteLine("请输入取款金额:");
                double money = double.Parse( Console.ReadLine());
                //执行取款操作
                user.Deposit(money);
            }
            else
            {
                Console.WriteLine("用户名或者密码不正确!");
            }

        }
        /// <summary>
        /// 显示余额
        /// </summary>
        public void ShowMoney()
        {

        }
    }
}
