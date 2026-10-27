using System;

namespace Concept_demo
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        private double price;

        public void setprice(double price)
        {
            this.price = price;
        }

        public double getprice()
        {
            return this.price;
        }

        public void Display()
        {
            Console.WriteLine("Product Id: " + ProductId);
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Product Price: " + price);
            Console.WriteLine();
        }
    }

    class ProductDetails
    {
        static void Main()
        {
            Product product = new Product{ ProductId = 1,ProductName = "Laptop"};

            product.setprice(50000);
            product.Display();

            product.ProductId = 2;
            product.ProductName = "Mobile";
            product.setprice(20000);
            product.Display();

            product.ProductId = 3;
            product.ProductName = "Tablet";
            product.setprice(30000);
            product.Display();

            Console.ReadLine();
        }
    }
}