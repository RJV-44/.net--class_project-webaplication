using System;

class Book
{
    
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    
    public Book(int id, string title, string author, double price)
    {
        BookId = id;
        Title = title;
        Author = author;
        Price = price;
    }

    
    public void DisplayDetails()
    {
        Console.WriteLine("Book ID: " + BookId);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("------------------------");
    }
}

class Program1
{
    static void Main()
    {

        Console.WriteLine("Rajvi lunagaruya");
        Console.WriteLine("enroll no : 24SOECE11019");
        // Creating multiple Book objects
        Book book1 = new Book(101, "C# Programming", "John Smith", 450);
        Book book2 = new Book(102, "Java Programming", "James Gosling", 550);
        Book book3 = new Book(103, "Python Basics", "Mark Lee", 400);

        // Displaying book details
        Console.WriteLine("Book Details");
        Console.WriteLine("========================");

        book1.DisplayDetails();
        book2.DisplayDetails();
        book3.DisplayDetails();
    }
}