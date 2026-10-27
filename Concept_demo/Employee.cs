using System;

namespace Concept_demo
{
    class Employee
    {
        public string Name { get; set; }

        private int age;  
        private double salary;

        public void setslary(double salary)
        {
            this.salary = salary;
        }

        public double getsalary()
        {
            return this.salary;
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Department { get; set; }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            e1.Name = "rajvi";
            e1.Age = 18;
            e1.Department = "IT";
            e1.setslary(50000);

            Employee e2 = new Employee();

            e2.Name = "abhay";
            e2.Age = 20;
            e2.Department = "CE";
            e2.setslary(60000); 

            e1.Display();
            Console.WriteLine();

            e2.Display();
        }
    }
}