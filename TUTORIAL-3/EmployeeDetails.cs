using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    class EmployeeDetails
    {
        private int empid; private string empName; private double basicSalary; private double netsalary;

        public EmployeeDetails(int id, string name, double salary)
        {
            empid = id; empName = name; basicSalary = salary;
        }
        public void CalculateSalary()

        {

            double hra = basicSalary * 0.20; // Assuming 20% HRA             double da = basicSalary * 0.10; // Assuming 10% DA 
            netsalary = basicSalary + hra ; // Assuming 10% deduction for taxes 
        }

        public void DisplayEmployeeDetails()
        {

            Console.WriteLine("----Employee Details------");
            Console.WriteLine("Employee id is:" + empid);
            Console.WriteLine("Employee name is:" + empName);
            Console.WriteLine("Employee basic salary is:" + basicSalary);
            Console.WriteLine("Employee net salary is:" + netsalary);
        }
    }
    class Class10
    {
        public static void Main(string[] args)

        {

            Console.WriteLine("Name : shreeya vekariya");
            Console.WriteLine("Enrollment No : 24SOECE11050 ");


            Console.Write("enter Employee id:"); int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter name:"); string name = Console.ReadLine(); Console.Write("enter salary:");
            double salary = Convert.ToDouble(Console.ReadLine());

            EmployeeDetails emp = new EmployeeDetails(id, name, salary); emp.CalculateSalary(); emp.DisplayEmployeeDetails();

            Console.ReadLine();

        }
    }

}
