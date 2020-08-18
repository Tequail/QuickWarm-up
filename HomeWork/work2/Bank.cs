using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.HomeWork.work2
{
    class Bank
    {
        public User user ;

        public User[] users = new User[3];
        /// <summary>
        /// 初始化账户对象
        /// </summary>
        public void Init()
        {
            users[0] = new User();
            users[0].UserName = "刘睿鑫";
            users[0].Password = "123456";
            users[0].AccountNo = 1325468907644;
            users[0].AccountMoney = 300;
            users[0].IdCardNo = "420384967486736583";

            users[1] = new User();
            users[1].UserName = "李涛";
            users[1].Password = "123456";
            users[1].AccountNo = 1355668503694;
            users[1].AccountMoney = 500;
            users[1].IdCardNo = "420234967469632349";

            users[2] = new User();
            users[2].UserName = "赵瑞";
            users[2].Password = "1234";
            users[2].AccountNo = 1354267695644;
            users[2].AccountMoney = 800;
            users[2].IdCardNo = "420284937965436690";
        }

        public void Menu()
        {
            Init();
            Console.WriteLine("==========欢迎使用自动银行服务===========");
            Console.WriteLine("1.存款 2.取款 3.转账 4.查询余额 5.退出");
            Console.WriteLine("=========================================");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Withdrawal();
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
            user.UserName = Console.ReadLine();
            Console.WriteLine("请输入用户密码:");
            user.Password = Console.ReadLine();
            Console.WriteLine("请输入用户身份证号:");
            user.IdCardNo = Console.ReadLine();
            Console.WriteLine("请输入用户存款金额:");
            user.AccountMoney = int.Parse(Console.ReadLine());
            //生成账户
            Random random = new Random();
            //Math.Abs:绝对值  不管随机出来的是正数还是负数   都将变为正数 absolute:在html绝对定位
            //user.accountNo = (long)(Math.Abs( random.NextDouble() * 100000000000));
            user.AccountNo = (long)(random.NextDouble() * (199999999999 - 100000000000) + 100000000000);
            Console.WriteLine("账户:{0},用户名:{1},存款金额:{2}创建成功!",user.AccountNo,user.UserName,user.AccountMoney);
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
            Console.WriteLine("请输入账号");
            long accountNo = long.Parse(Console.ReadLine());
            bool flag = false;
            User account = null;
            /*遍历判断是否有这个账户*/
            foreach (User user in users)
            {
                if (user.AccountNo == accountNo)
                {
                    account = user;
                    flag = true;
                } 
            }
            if (flag)
            {
                Console.WriteLine("请输入存款金额:");
                double money = double.Parse(Console.ReadLine());
                account.Withdrawal(money);
            }
            else
            {
                Console.WriteLine("没有这个账号!");
            }
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
            if (accountNo == user.AccountNo && password.Equals(user.Password))
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
