using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    internal class Shape

    //virtual will allow the method to be overridden in derived classes     //override keyword weitten in the child class method     //virtual keyword written in the parent class method 
    {

        public virtual void CalculateArea()
        {
            Console.WriteLine("Calculating area of shape:");
        }
    }

    class Circle : Shape
    {
        public override void CalculateArea()
        {
            double radius = 5;
            double area = Math.PI * radius * radius;

            Console.WriteLine("Calculating area of circle :" + area.ToString("0.00"));
        }
    }

    class Rectangle : Shape
    {
        public override void CalculateArea()
        {
            double length = 10; double width = 5;
            double area = length * width;
            Console.WriteLine("Calculating area of rectangle:" + area);
        }
    }

    class Triangle : Shape
    {
        public override void CalculateArea()
        {
            double b = 10; double h = 5; double area = 0.5 * b * h;
            Console.WriteLine("Calculating area of triangle:" + area);
        }
    }

    class Class17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");

            Shape shape;

            shape = new Circle(); shape.CalculateArea();


            shape = new Rectangle(); shape.CalculateArea();

            shape = new Triangle(); shape.CalculateArea();

            Console.ReadLine();
        }
    }

}
