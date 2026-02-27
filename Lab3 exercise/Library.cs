using System.Collections.Generic;

public class Library
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void BorrowBook(Member member, Book book)
    {
        if (book.IsAvailable)
        {
            book.BorrowBook();
            Console.WriteLine($"{member.Name} borrowed \"{book.Title}\"");
        }
        else
        {
            Console.WriteLine($"\"{book.Title}\" is not available.");
        }
    }

    public void DisplayBooks()
    {
        Console.WriteLine("\nLibrary Books:");
        foreach (Book book in books)
        {
            Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Available: {book.IsAvailable}");
        }
    }
}

