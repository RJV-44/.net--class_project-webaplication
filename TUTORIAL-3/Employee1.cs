using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    internal class Employee1
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public double BasicSalary { get; set; }

    }

    class PermanentEmployee : Employee1
    {

        public void CalculateSalary()
        {

            double hra = BasicSalary * 0.20; double da = BasicSalary * 0.10; double netSalary = BasicSalary + hra + da;


            Console.WriteLine("Permanent Employee Salary:");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary: " + BasicSalary);
            Console.WriteLine("HRA: " + hra); Console.WriteLine("DA: " + da);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    class ContractEmployee : Employee1
    {
        public void CalculateSalary()
        {

            double netSalary = BasicSalary;
            Console.WriteLine("Contract Employee Salary:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }

    class Class16
    {
        public static void Main(string[] args)
        {

            PermanentEmployee p = new PermanentEmployee();

            p.EmployeeId = 101;
            p.Name = "shreeya";
            p.BasicSalary = 500000;

            p.CalculateSalary();
            ContractEmployee c = new ContractEmployee();

            c.EmployeeId = 102;
            c.Name = "Mahi";
            c.BasicSalary = 300000;

            c.CalculateSalary();


        }


    }

}
