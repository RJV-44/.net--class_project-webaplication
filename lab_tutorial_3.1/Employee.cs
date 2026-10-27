using System;


class Employee
{
    public virtual double CalculateSalary()
    {
        return 0;
    }
}


class Manager : Employee
{
    public double BasicSalary { get; set; }

    public Manager(double salary)
    {
        BasicSalary = salary;
    }

  
    public override double CalculateSalary()
    {
        return BasicSalary + (BasicSalary * 0.20);
    }
}


class Developer : Employee
{
    public double BasicSalary { get; set; }

    public Developer(double salary)
    {
        BasicSalary = salary;
    }

    public override double CalculateSalary()
    {
        return BasicSalary + (BasicSalary * 0.10);
    }
}

class Program3
{
    static void Main()
    {

        Console.WriteLine("Rajvi lunagaruya");
        Console.WriteLine("enroll no : 24SOECE11019");
        Manager manager = new Manager(50000);
        Developer developer = new Developer(40000);

        Console.WriteLine("Manager Salary: " + manager.CalculateSalary());
        Console.WriteLine("Developer Salary: " + developer.CalculateSalary());
    }
}