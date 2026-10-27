
using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    class BankAccount
    {
        public event EventHandler MoneyDeposited;

        public double Balance { get; private set; }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Please enter a valid deposit amount.");
                return;
            }

            Balance += amount;

            MoneyDeposited?.Invoke(this, EventArgs.Empty);
        }

        public void DisplayMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Money deposited successfully!");
            Console.WriteLine("Current Balance: " + Balance);
        }
    }

    class Program5
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.MoneyDeposited += account.DisplayMessage;

            Console.Write("Enter deposit amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Deposit(amount);

            Console.ReadLine();
        }
    }
}
