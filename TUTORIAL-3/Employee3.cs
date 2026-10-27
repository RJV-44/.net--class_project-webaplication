using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    internal class Employee3
    {

        protected string designation; protected double salary;

        public Employee3(string designation, double salary)
        {
            this.designation = designation;
            this.salary = salary;
        }
    }

    class Department : Employee3
    {

        private string dept_name;
        public Department(string designation, double salary, string dept_name) : base(designation, salary)
        {
            this.dept_name = dept_name;

        }
        public void Display()
        {

            Console.WriteLine("Employee Designation: " + designation);
            Console.WriteLine("Employee Salary: " + salary);
            Console.WriteLine("Department Name: " + dept_name);
        }
    }

    class Class21
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");

            Department d = new Department("software engineering", 50000, "backend"); d.Display();
        }
    }

}
