using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUTORIAL_3
{
    class Line

    {
        private double length;   // Length of a line 
        public Line()
        {
 

            Console.WriteLine("Object is being creating value length = 10");

                   length = 10; 
        }
        public void setLength(double len)

        {

                            length = len;  
        }

        public double getLength()

        {

                       return length;  
        }
    }

    class Class6

    {
        static void Main(string[] args)

        {
            Console.WriteLine("Name : rajvi lunagariya");
            Console.WriteLine("Enrollment No : 24SOECE11019 ");


            Line line = new Line();

            

            Console.WriteLine("Length of line : {0}", line.getLength());

            line.setLength(6);  
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();

        }

    }
}
