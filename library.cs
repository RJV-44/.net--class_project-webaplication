using System;


class Library
{
    public string LibraryName;

    public static int TotalBooks = 0;

    public Library(string name)
    {
        LibraryName = name;
    }

    public void DisplayLibrary()
    {
        Console.WriteLine("Library Name: " + LibraryName);
    }
}

class Book1 : Library
{
    public string BookName;
    public string Author;


    public Book1(string name, string bookName, string author)
        : base(name)     
    {
        this.BookName = bookName;
        this.Author = author;

        Library.TotalBooks++;
    }

    public void DisplayBook()
    {
        base.DisplayLibrary();   

        Console.WriteLine("Book Name: " + this.BookName);
        Console.WriteLine("Author: " + this.Author);
    }

    public new void DisplayLibrary()
    {
        Console.WriteLine("This is the Book Library.");
    }
}

class Program5
{
    static void Main()
    {

        Console.WriteLine("Rajvi lunagaruya");
        Console.WriteLine("enroll no : 24SOECE11019");

        Book1 book1 = new Book1("Central Library",
                              "C# Programming",
                              "John Smith");

        Book1 book2 = new Book1("Central Library",
                              "Java Programming",
                              "James Gosling");

        Console.WriteLine("--- Book 1 Details ---");
        book1.DisplayBook();

        Console.WriteLine("\n--- Book 2 Details ---");
        book2.DisplayBook();

        Console.WriteLine("\n--- new Keyword ---");
        book1.DisplayLibrary();


        Console.WriteLine("\n--- static Keyword ---");
        Console.WriteLine("Total Books: " + Library.TotalBooks);
    }
}