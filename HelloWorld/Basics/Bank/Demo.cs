using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Basics.Bank
{
    class Demo
    {
        public static void BankDemo()
        {
            var account = new BankAccount("John Doe", 10);
            Console.WriteLine($"Account {account.Number} has been created for {account.Owner} with ${account.Balance}");
            account.MakeDeposit(500, DateTime.Now, "Paycheck");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine($"New balance is ${account.Balance}");

            try
            {
                account.MakeDeposit(-300, DateTime.Now, "Stealing");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Caught an exception: " + e);
                Console.WriteLine($"New balance is ${account.Balance}");

            }

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
