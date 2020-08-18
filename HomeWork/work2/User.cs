using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.HomeWork.work2
{
    class User
    {
        /*1.属性私有化*/
        private string userName;
        private string password;
        private string idCardNo;
        private double accountMoney;
        private long accountNo;
        // ctrl + r + e
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string IdCardNo { get => idCardNo; set => idCardNo = value; }
        public double AccountMoney { get => accountMoney; set => accountMoney = value; }
        public long AccountNo { get => accountNo; set => accountNo = value; }

        /*2.使用属性封装提供get和set方法*/



        /// <summary>
        /// 存款
        /// </summary>
        public void Withdrawal(double money)
        {
            AccountMoney += money;
            Console.WriteLine("存款成功!当前余额:"+AccountMoney);
        }
        /// <summary>
        /// 取款
        /// </summary>
        public void Deposit(double money)
        {
            if (AccountMoney > money && money > 0)
            {
                AccountMoney -= money;
                Console.WriteLine("取款成功!当前余额:"+AccountMoney);
            }
            else
            {
                Console.WriteLine("取款金额不足!");
            }

        }
    }
}
