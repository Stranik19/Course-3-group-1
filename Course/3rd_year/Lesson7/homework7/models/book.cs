public class book
{
    public int bookId {get;set;}
    public string bookName {get; set;}
    public string Author {get;set;}
    public int yearRelease {get; set;}

    public void Update(Book otherBook)
    {
        bookId = otherBook.bookId;
        bookName = otherBook.bookName;
        Author = otherBook.Author;
        yearRelease = otherBook.yearRelease; 
    }
}