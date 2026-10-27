
using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    interface IEmployee
    {
        void AcceptDetails();
        void DisplayDetails();
    }

    class Employee : IEmployee
    {
        int id;
        string name;
        double salary;

        public void AcceptDetails()
        {
            Console.Write("Enter Employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            emp.AcceptDetails();
            emp.DisplayDetails();

            Console.ReadLine();
        }
    }
}
