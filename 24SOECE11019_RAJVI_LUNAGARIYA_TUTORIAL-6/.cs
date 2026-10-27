using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{

    class que8 : Exception
    {
        public que8(string message) : base(message)
        {
        }
    }

    class BankAccount
    {
        double balance = 50000;

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientFundsException("Error:Amount withdrawal failed.");
            }
            balance -= amount;
            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Current balance: " + balance);
        }
    }
    internal class que8
    {
        public static void main(string[] args)
        {
            Console.WriteLine("24SOECE11007_Khush Dobariya");

            BankAccount b = new BankAccount();
            try
            {
                Console.Write("Enter amount to withdraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                b.Withdraw(amount);

            }
            catch (que8 ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

