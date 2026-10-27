using System;

class libraryaccount
{
    
    private int issuedBooks;

    public libraryaccount()
    {
        issuedBooks = 0;
    }

   
    public void IssueBook()
    {
        issuedBooks++;
        Console.WriteLine("Book issued successfully.");
    }

 
    public void ReturnBook()
    {
        if (issuedBooks > 0)
        {
            issuedBooks--;
            Console.WriteLine("Book returned successfully.");
        }
        else
        {
            Console.WriteLine("No books to return.");
        }
    }

 
    public void DisplayBooks()
    {
        Console.WriteLine("Number of issued books: " + issuedBooks);
    }
}

class Program6
{
    static void Main()
    {
        Console.WriteLine("Rajvi lunagaruya");
        Console.WriteLine("enroll no : 24SOECE11019");
        LibraryAccount account1 = new LibraryAccount();
        LibraryAccount account2 = new LibraryAccount();

        Console.WriteLine("--- Account 1 ---");
        account1.IssueBook();
        account1.IssueBook();
        account1.DisplayBooks();

        account1.ReturnBook();
        account1.DisplayBooks();

        Console.WriteLine("\n--- Account 2 ---");
        account2.IssueBook();
        account2.DisplayBooks();

        account2.ReturnBook();
        account2.DisplayBooks();
    }
}