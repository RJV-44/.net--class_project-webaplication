using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_tutorial_3._1
{
    internal class Product
    {
       
        private int productCode;
        private string productName;
        private double price;

       
        public Product(int code, string name, double p)
        {
            productCode = code;
            productName = name;
            price = p;
        }

        
        public double CalculateDiscount()
        {
            return price * 0.10;
        }

     
        public double CalculateFinalPrice()
        {
            return price - CalculateDiscount();
        }

        // Method to display product details
        public void Display()
        {
            Console.WriteLine("Product Code: " + productCode);
            Console.WriteLine("Product Name: " + productName);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Discount: " + CalculateDiscount());
            Console.WriteLine("Final Price: " + CalculateFinalPrice());
        }
    }

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Rajvi lunagaruya");
            Console.WriteLine("enroll no : 24SOECE11019");
            Console.Write("Enter Product Code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Product p = new Product(code, name, price);

            Console.WriteLine("\n--- Product Details ---");
            p.Display();
        }
    }
}
