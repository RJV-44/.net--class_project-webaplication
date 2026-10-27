using System;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_6
{
    interface IPersonalDetails
    {
        void AcceptPersonalDetails();
        void DisplayPersonalDetails();
    }

    interface IProfessionalDetails
    {
        void AcceptProfessionalDetails();
        void DisplayProfessionalDetails();
    }

    class Employee2 : IPersonalDetails, IProfessionalDetails
    {
        int id;
        string name = "";
        string address = "";
        string designation = "";
        double salary;

        public void AcceptPersonalDetails()
        {
            Console.Write("Enter Employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Employee Address: ");
            address = Console.ReadLine();
        }

        public void AcceptProfessionalDetails()
        {
            Console.Write("Enter Employee Designation: ");
            designation = Console.ReadLine();

            Console.Write("Enter Employee Salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayPersonalDetails()
        {
            Console.WriteLine("\n--- Personal Details ---");
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Address: " + address);
        }

        public void DisplayProfessionalDetails()
        {
            Console.WriteLine("\n--- Professional Details ---");
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Program2
    {
        static void Main(string[] args)
        {
            Employee2 emp = new Employee2();

            emp.AcceptPersonalDetails();
            emp.AcceptProfessionalDetails();

            emp.DisplayPersonalDetails();
            emp.DisplayProfessionalDetails();

            Console.ReadLine();
        }
    }
}