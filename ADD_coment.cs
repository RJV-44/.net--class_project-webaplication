using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class ADD_coment
    {
        static void Main(string[] args)

        {

            int n, fact = 1;   //variable declaration

            Console.WriteLine("Enter Number : ");   //fetch the number from user

            string str = Console.ReadLine();    //read the number from user

            n = Convert.ToInt32(str);      //convert the  string into integer

            for (int i = 1; i <= n; i++)    //for loop

            {

                fact = fact * i;        //calculation of factorial

            }

            Console.WriteLine("Factorial : {0}", fact);    // final factorial value 



            Console.Read();  //wait for user input before closing the console window

        }
    }
}
