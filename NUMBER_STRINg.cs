
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial__1
{
    internal class NUMBER_STRINg
    {
        static void Main(string[] args)
        {
            //int number;
            //Console.WriteLine("Enter a number: ");
            //number = Convert.ToInt32(Console.ReadLine());
            //string str = number.ToString();
            //Console.WriteLine("The number in string format is: " + str);

            String number;
            Console.WriteLine("Enter a number: ");
            number = Console.ReadLine();

            foreach (char c in number)
            {
               switch (c)
                {
                    case '0':
                        Console.Write("Zero");
                        break;
                    case '1':
                        Console.Write("One");
                        break;
                    case '2':
                        Console.Write("Two");
                        break;
                    case '3':
                        Console.Write("Three");
                        break;
                    case '4':
                        Console.Write("Four");
                        break;
                    case '5':
                        Console.Write("Five");
                        break;
                    case '6':
                        Console.Write("Six");
                        break;
                    case '7':
                        Console.Write("Seven");
                        break;
                    case '8':
                        Console.Write("Eight");
                        break;
                    case '9':
                        Console.Write("Nine");
                        break;
                    default:
                        Console.Write("Invalid input");
                        break;
                }
            }
        }
    }
}
