using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.HomeWork.work2
{
    class User
    {
        public string userName;
        public string password;
        public string idCardNo;
        public double accountMoney;
        public long accountNo;

        /// <summary>
        /// 存款
        /// </summary>
        public void Withdrawal()
        {

        }
        /// <summary>
        /// 取款
        /// </summary>
        public void Deposit(double money)
        {
            if (accountMoney > money && money > 0)
            {
                accountMoney -= money;
                Console.WriteLine("取款成功!当前余额:"+accountMoney);
            }
            else
            {
                Console.WriteLine("取款金额不足!");
            }

        }
    }
}
