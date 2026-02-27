using System;

class Program
{
    static void Main(string[] args)
    {
        // Create objects
        Member member1 = new Member(24006081, "Ali");
        Book book1 = new Book(101, "C# Programming");
        Book book2 = new Book(102, "Object-Oriented Design");

        Library library = new Library();

        // Object interaction
        library.AddBook(book1);
        library.AddBook(book2);

        member1.DisplayInfo();
        library.DisplayBooks();

        library.BorrowBook(member1, book1);
        library.DisplayBooks();

        Console.ReadLine();
    }
}

