using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_lunagariya_rajvi_Tutorial_4
{
    class Employee
    {
        private int emp_code;
        private string emp_name;
        private string designation;
        private double basicPay;

        public Employee(int emp_code, string emp_name, string designation, double basicPay)
        {
            this.emp_code = emp_code;
            this.emp_name = emp_name;
            this.designation = designation;
            this.basicPay = basicPay;
        }

        public void CalculatePay()
        {
            double hra = basicPay * 0.10;
            double da = basicPay * 0.45;
            double netSalary = basicPay + hra + da;

            Console.WriteLine("Employee Code: " + emp_code);
            Console.WriteLine("Employee Name: " + emp_name);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Basic Pay: " + basicPay);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("Gross Pay: " + netSalary);
        }


    }

    class Employee1
    {
        public static void Main()
        {

            Employee e1 = new Employee(101, "MAHI", "Software Engineer", 50000);
            e1.CalculatePay();

            Employee e2 = new Employee(101, "rajvu", " backend devloper", 50000);
            e2.CalculatePay();

            Employee e3 = new Employee(101, "krisha", "computer engineering", 50000);
            e3.CalculatePay();

          


            Console.ReadLine();
        }
    }
}
