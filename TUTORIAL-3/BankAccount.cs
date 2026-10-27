using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    class BankAccount
    {
        private string accountNo; private string accountHolder; private double balance;
        public BankAccount(string accNo, string Holder, double amount)
        {
            accountNo = accNo; accountHolder = Holder;
            balance = amount;
        }
        public void Deposit(double amount)
        {

            balance += amount;
            Console.WriteLine("amount deposited successfully.");

        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("amount withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
        public void BalancsEnquiry()
        {
            Console.WriteLine("Account Number: " + accountNo);
            Console.WriteLine("Account Holder Name:" + accountHolder);
            Console.WriteLine("Balance balance :" + balance);
        }
    }

    class Class11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");
            BankAccount acc1 = new BankAccount("1001", "rajvi vekariya", 10000);
            BankAccount acc2 = new BankAccount("1002", "mahi vekariya", 15000);

            Console.WriteLine("Account 1 Transactions:");
            acc1.Deposit(2000); acc1.Withdraw(3000); acc1.BalancsEnquiry();

            Console.WriteLine("========================");

            Console.WriteLine("Account 2 Transactions:");
            acc2.Deposit(5000); acc2.Withdraw(2000); acc2.BalancsEnquiry(); Console.ReadLine();
        }
    }

}
