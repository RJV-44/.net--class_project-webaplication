using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    internal class Employee
    {
        private double salary;         //public method set salary 

        public void SetSalary(double amount)
        {
            salary = amount;
        }

        public double GetSalary()
        {
            return salary;
        }
    }

    class Class14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");



            Employee emp = new Employee();

            Console.Write("Enter Employee Salary: "); double amount = Convert.ToDouble(Console.ReadLine());
            emp.SetSalary(amount);

            Console.WriteLine("Employee Salary: " + emp.GetSalary());
            Console.ReadLine();
        }
    }


}
