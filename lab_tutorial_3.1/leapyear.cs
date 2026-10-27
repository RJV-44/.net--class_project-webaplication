using System;

class leapyear
{
    static void Main()
    {
        Console.WriteLine("Rajvi lunagaruya");
        Console.WriteLine("enroll no : 24SOECE11019");

        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
        {
            Console.WriteLine("The year is a Leap Year.");
        }
        else
        {
            Console.WriteLine("The year is not a Leap Year.");
        }
    }
}