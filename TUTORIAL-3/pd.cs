using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    class pd
    {
        public int prodid { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public double CalculateBill()
        {
            return price * quantity;
        }
    }

    class Class13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");



            pd product = new pd();
            Console.Write("Enter Product ID: ");
            product.prodid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: "); product.name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            product.price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Product Quantity: ");
            product.quantity = Convert.ToInt32(Console.ReadLine());
            double totalBill = product.CalculateBill();
            Console.WriteLine("=========Product Details:===========");
            Console.WriteLine("Product ID: " + product.prodid);
            Console.WriteLine("Product Name: " + product.name);
            Console.WriteLine("Product Price: " + product.price);
            Console.WriteLine("Product Quantity: " + product.quantity);
            Console.WriteLine("Total Bill Amount: " + totalBill);
            Console.ReadLine();
        }
    }

}
