using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    internal class Employee2
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public virtual void GenerateSalarySlip()
        {

            Console.WriteLine("Employee Salary Slip");
        }
    }

    class PermanentEmployee2 : Employee2
    {
        public override void GenerateSalarySlip()
        {
            double hra = Salary * 0.20; double da = Salary * 0.10; double netSalary = Salary + hra + da;


            Console.WriteLine("Permanent Employee Salary Slip:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Basic Salary: " + Salary);
            Console.WriteLine("HRA: " + hra); Console.WriteLine("DA: " + da);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }
    class ContractEmployee2 : Employee2
    {
        public override void GenerateSalarySlip()
        {
            double netSalary = Salary;
            Console.WriteLine("Contract Employee Salary Slip:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Net Salary: " + Salary);
        }
    }

    class Class18
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");

            PermanentEmployee2 emp = new PermanentEmployee2();


            emp.Name = "shreeya"; emp.Salary = 30000;


            emp.GenerateSalarySlip();


            Console.WriteLine();
            ContractEmployee2 c = new ContractEmployee2(); c.Name = "mitu";
            c.Salary = 30000;

            c.GenerateSalarySlip();
            Console.Read();
        }
    }

}
