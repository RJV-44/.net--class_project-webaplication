using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Rajvi lunagaruya");
        Console.WriteLine("enroll no : 24SOECE11019");
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

  
        string upperCase = sentence.ToUpper();

        string trimmed = sentence.Trim();

        string replaced = trimmed.Replace(" ", "-");

       
        int length = trimmed.Length;

        Console.WriteLine("\n--- String Operations ---");
        Console.WriteLine("Uppercase: " + upperCase);
        Console.WriteLine("After replacing spaces: " + replaced);
        Console.WriteLine("After trimming spaces: " + trimmed);
        Console.WriteLine("Length: " + length);
    }
}