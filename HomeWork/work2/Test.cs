using System;
using System.Collections.Generic;
using System.Text;

namespace QuickWarm_up.HomeWork.work2
{
    class Test
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            /* bank.CreateUser();
             bank.Menu();*/
            //Console.WriteLine("陶老师很帅，掉渣的那种！");

            bank.Init();
             foreach (var user in bank.users)
             {
                 Console.WriteLine("用户名:{0},密码:{1},身份证号:{2},余额:{3},账号:{4}",user.UserName,user.Password,user.IdCardNo,user.AccountMoney,user.AccountNo);
             }
            bank.Menu();
        }
    }
}
