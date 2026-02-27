public class Book
{
    private int bookId;
    private string title;
    private bool isAvailable;

    public int BookId
    {
        get { return bookId; }
        private set { bookId = value; }
    }

    public string Title
    {
        get { return title; }
        private set { title = value; }
    }

    public bool IsAvailable
    {
        get { return isAvailable; }
        private set { isAvailable = value; }
    }

    public Book(int bookId, string title)
    {
        BookId = bookId;
        Title = title;
        IsAvailable = true;
    }

    public void BorrowBook()
    {
        IsAvailable = false;
    }

    public void ReturnBook()
    {
        IsAvailable = true;
    }
}

