using System;


abstract class Payment
{
    public double Amount { get; set; }

    public Payment(double amount)
    {
        Amount = amount;
    }

  
    public abstract double CalculatePayment();
}


class CreditCardPayment : Payment
{
    public CreditCardPayment(double amount) : base(amount)
    {
    }

    // Override abstract method
    public override double CalculatePayment()
    {
        // 2% processing fee
        return Amount + (Amount * 0.02);
    }
}


class CashPayment : Payment
{
    public CashPayment(double amount) : base(amount)
    {
    }

   
    public override double CalculatePayment()
    {
        return Amount;
    }
}


class UPIPayment : Payment
{
    public UPIPayment(double amount) : base(amount)
    {
    }

    // Override abstract method
    public override double CalculatePayment()
    {
        // 1% processing fee
        return Amount + (Amount * 0.01);
    }
}

class Program4
{
    static void Main()
    {

        Console.WriteLine("Rajvi lunagaruya");
        Console.WriteLine("enroll no : 24SOECE11019");
        Payment creditCard = new CreditCardPayment(10000);
        Payment cash = new CashPayment(10000);
        Payment upi = new UPIPayment(10000);

        Console.WriteLine("Credit Card Payment: " +
                          creditCard.CalculatePayment());

        Console.WriteLine("Cash Payment: " +
                          cash.CalculatePayment());

        Console.WriteLine("UPI Payment: " +
                          upi.CalculatePayment());
    }
}