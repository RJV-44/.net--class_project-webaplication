
using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    // Custom Exception
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }

    // Bank Account Class
    class BankAccount1
    {
        double balance = 50000;

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException(
                    "Error: Insufficient balance for withdrawal.");
            }

            balance -= amount;

            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Remaining Balance: " + balance);
        }
    }

    class Program8
    {
        static void Main(string[] args)
        {
            BankAccount1 account = new BankAccount1();

            try
            {
                Console.Write("Enter amount to withdraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                account.Withdraw(amount);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
