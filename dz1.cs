using System;
using System.Collections.Generic;

class Book
{
    public string Name;
    public string Author;
    public int ISBN;
    public int Count;
    public Book(string name, string author, int isbn, int count)
    {
        Name = name;
        Author = author;
        ISBN = isbn;
        Count = count;
    }
}
class Reader
{
    public string Name;
    public int Id;
    public Reader(string name, int id)
    {
        Name = name;
        Id = id;
    }
}

interface Logging
{
    void Log(string message);
}
class Logger : Logging
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
class Library
{
    private Logging Logging;
    private List<Book> books = new List<Book>();
    private List<Reader> readers = new List<Reader>();
    public Library(Logging logging)
    {
        Logging = logging;
    }
    public void AddBook(Book book)
    {
        books.Add(book);
        Logging.Log($"{book.Name} добавлена в библиотеку");
    }
    public void RemoveBook(Book book)
    {
        if (books.Remove(book))
        {
            Logging.Log($"{book.Name} удалена из библиотеки");
        }
    }
    public bool ContainsBook(Book book)
    {
        return books.Contains(book);
    }
    public void AddReader(Reader reader)
    {
        readers.Add(reader);
        Logging.Log($"{reader.Name} зарегистрирован в библиотеке");
    }
    public void RemoveReader(Reader reader)
    {
        if (readers.Remove(reader))
            Logging.Log($"{reader.Name} удален из библиотеки");
    }
    public bool ContainsReader(Reader reader)
    {
        return readers.Contains(reader);
    }


}
class ReaderManagement
{
    private Library Library;
    public ReaderManagement(Library library)
    {
        Library = library;
    }
    public void AddReader(Reader reader)
    {
        Library.AddReader(reader);
    }
    public void RemoveReader(Reader reader)
    {
        Library.RemoveReader(reader);
    }
    
}
class BookManagement
{
    private Library Library;
    private Logging Logging;
    public BookManagement(Logging logging, Library library)
    {
        Logging = logging;
        Library = library;
    }
    public void GiveBook(Reader reader, Book book)
    {
        if (Library.ContainsBook(book) && Library.ContainsReader(reader) && book.Count > 0)
        {
            book.Count--;
            Logging.Log($"{book.Name} выдан {reader.Name}");
        }
        else
            Logging.Log($"{book.Name} не может быть выдана");
    }
    public void ReturnBook(Reader reader, Book book)
    {
        book.Count++;
        if (Library.ContainsReader(reader))
            Logging.Log($"{reader.Name} вернул {book.Name}");
        else
            Logging.Log($"{reader.Name} не зарегистрирован, книгу возьмем");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Logging logging = new Logger();
        Library library = new Library(logging);
        ReaderManagement readerManagement = new ReaderManagement(library);
        BookManagement bookManagement = new BookManagement(logging, library);

        Book book1 = new Book("Голодные игры", "Сьюзен Коллинз", 10321, 10);
        Book book2 = new Book("1984", "Джордж Оруэлл", 20321, 5);
        Book book3 = new Book("Послемрак", "Харуки Мураками", 30321, 1);

        Reader reader1 = new Reader("Дидар", 101);
        Reader reader2 = new Reader("Айдана", 102);
        Reader reader3 = new Reader("Алишер", 103);

        library.AddBook(book1);
        library.AddBook(book3);
        Console.WriteLine("\n");

        readerManagement.AddReader(reader1);
        readerManagement.AddReader(reader2);
        Console.WriteLine("\n");

        bookManagement.GiveBook(reader1, book1);
        bookManagement.GiveBook(reader2, book3);
        bookManagement.GiveBook(reader1, book3);
        Console.WriteLine("\n");

        bookManagement.ReturnBook(reader1, book1);
        Console.WriteLine("\n");

        library.RemoveBook(book3);
        readerManagement.RemoveReader(reader3);

    }
}